using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obs_Project
{
    public partial class Form2 : Form
    {
        private int ogrenciId;
        public Form2(int ogrId)
        {
            InitializeComponent();
            ogrenciId = ogrId; 
        }
        public void SetOgrenci(string ogrenciAd, string ogrenciSoyad, string ogrenciNumara)
        {
            lblOgrenciBilgi.Text = $"Ad: {ogrenciAd} Soyad: {ogrenciSoyad} Numara: {ogrenciNumara}";
        }

        public void LoadDersler()
        {
            using (var ctx = new ObsDbContext())
            {
                var dersler = ctx.Ders.ToList();
                dataGridView1.DataSource = dersler;

                if (!dataGridView1.Columns.Contains("SelectColumn"))
                {
                    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                    {
                        Name = "SelectColumn",    
                        HeaderText = "Seç",       
                        FalseValue = false,       
                        TrueValue = true          
                    };
                    dataGridView1.Columns.Insert(4, checkBoxColumn); 
                }


                var ogrenciDersler = ctx.OgrenciDers
                                         .Where(od => od.OgrenciID == ogrenciId) 
                                         .Select(od => od.DersID)
                                         .ToList();


                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var dersId = Convert.ToInt32(row.Cells["DersId"].Value);
                    if (ogrenciDersler.Contains(dersId))
                    {
                        row.Cells["SelectColumn"].Value = true; 
                    }
                }
            }
        }
        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            var selectedDersler = new List<int>(); 

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var isSelected = Convert.ToBoolean(row.Cells["SelectColumn"].Value);
                if (isSelected)
                {
                    var dersId = Convert.ToInt32(row.Cells["DersId"].Value); 
                    selectedDersler.Add(dersId); 
                }
            }


            if (selectedDersler.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir ders seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

 
            using (var ctx = new ObsDbContext())
            {
                foreach (var dersId in selectedDersler)
                {
                    var ogrenciDers = new OgrenciDers
                    {
                        OgrenciID = ogrenciId, 
                        DersID = dersId        
                    };

                    ctx.OgrenciDers.Add(ogrenciDers);
                }

                try
                {

                    ctx.SaveChanges();
                    MessageBox.Show("Dersler başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
