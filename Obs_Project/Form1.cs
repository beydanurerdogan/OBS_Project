using Microsoft.EntityFrameworkCore;

namespace Obs_Project
{
    public partial class Form1 : Form
    {
        Ogrenci? ogr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new ObsDbContext())
                {
                    var siniflar = ctx.Siniflar.ToList();


                    cbxS�n�fSe�.DataSource = siniflar;
                    cbxS�n�fSe�.DisplayMember = "SinifAd";  
                    cbxS�n�fSe�.ValueMember = "SinifID"; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata olu�tu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var ogrenciAd = txtAd.Text.Trim();
            var ogrenciSoyad = txtSoyad.Text.Trim();
            var ogrenciNumara = txtNumara.Text.Trim();
            var selectedSinifId = (int)cbxS�n�fSe�.SelectedValue; 

 
            if (string.IsNullOrWhiteSpace(ogrenciAd) ||
                string.IsNullOrWhiteSpace(ogrenciSoyad) ||
                string.IsNullOrWhiteSpace(ogrenciNumara))
            {
                MessageBox.Show("L�tfen t�m alanlar� doldurun.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var ctx = new ObsDbContext())
                {
                    var sinif = ctx.Siniflar.Include(s => s.Ogrenciler).FirstOrDefault(s => s.SinifID == selectedSinifId);

                    if (sinif == null)
                    {
                        MessageBox.Show("Ge�ersiz s�n�f se�imi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!int.TryParse(sinif.Kontenjan, out int kontenjan))
                    {
                        MessageBox.Show("S�n�f�n kontenjan de�eri ge�ersiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (sinif.Ogrenciler.Count >= kontenjan)
                    {
                        MessageBox.Show("Se�ilen s�n�f�n kontenjan� dolmu�.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var yeniOgrenci = new Ogrenci
                    {
                        Ad = ogrenciAd,
                        Soyad = ogrenciSoyad,
                        Numara = ogrenciNumara,
                        SinifID = selectedSinifId
                    };

                    ctx.Ogrenciler.Add(yeniOgrenci);
                    int sonuc = ctx.SaveChanges();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("��renci ba�ar�yla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAd.Clear();
                        txtSoyad.Clear();
                        txtNumara.Clear();
                        cbxS�n�fSe�.SelectedIndex = -1;
                        txtAd.Focus();
                    }
                    else
                    {
                        MessageBox.Show("��renci eklenirken bir hata olu�tu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata olu�tu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            var ogrenciNumara = txtNumara.Text.Trim();

            if (string.IsNullOrWhiteSpace(ogrenciNumara))
            {
                MessageBox.Show("L�tfen bir ��renci numaras� giriniz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var ctx = new ObsDbContext())
                {
                    var ogrenci = ctx.Ogrenciler.Include(o => o.Siniflar).FirstOrDefault(o => o.Numara == ogrenciNumara);

                    if (ogrenci != null)
                    {
                        txtAd.Text = ogrenci.Ad;
                        txtSoyad.Text = ogrenci.Soyad;

                        if (ogrenci.Siniflar != null)
                        {
                            cbxS�n�fSe�.SelectedValue = ogrenci.Siniflar.SinifID;
                        }

                        ogr = ogrenci;
                        btnGuncelle.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("��renci bulunamad�.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGuncelle.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata olu�tu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (ogr == null)
            {
                MessageBox.Show("L�tfen �nce bir ��renci se�iniz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var ctx = new ObsDbContext())
                {
                    ctx.Entry(ogr).State = EntityState.Modified;

                    ogr.Ad = txtAd.Text.Trim();
                    ogr.Soyad = txtSoyad.Text.Trim();
                    ogr.Numara = txtNumara.Text.Trim();

                    int sonuc = ctx.SaveChanges();

                    MessageBox.Show(sonuc > 0 ? "G�ncelleme ba�ar�l�!" : "G�ncelleme ba�ar�s�z!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata olu�tu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDersSe�_Click(object sender, EventArgs e)
        {
            if (ogr == null)
            {
                MessageBox.Show("L�tfen �nce bir ��renci se�iniz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm2 = new Form2(ogr.OgrenciID);
            frm2.SetOgrenci(ogr.Ad, ogr.Soyad, ogr.Numara);
            frm2.LoadDersler();
            frm2.Show();
        }
    }
}
