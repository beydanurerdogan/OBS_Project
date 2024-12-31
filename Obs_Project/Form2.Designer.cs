namespace Obs_Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            lblDersler = new Label();
            lblOgrenciBilgi = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(257, 448);
            button1.Name = "button1";
            button1.Size = new Size(291, 57);
            button1.TabIndex = 7;
            button1.Text = "Öğrencinin Derslerini Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(709, 301);
            dataGridView1.TabIndex = 6;
            // 
            // lblDersler
            // 
            lblDersler.AutoSize = true;
            lblDersler.Location = new Point(63, 99);
            lblDersler.Name = "lblDersler";
            lblDersler.Size = new Size(56, 20);
            lblDersler.TabIndex = 5;
            lblDersler.Text = "Dersler";
            // 
            // lblOgrenciBilgi
            // 
            lblOgrenciBilgi.AutoSize = true;
            lblOgrenciBilgi.Location = new Point(63, 53);
            lblOgrenciBilgi.Name = "lblOgrenciBilgi";
            lblOgrenciBilgi.Size = new Size(50, 20);
            lblOgrenciBilgi.TabIndex = 4;
            lblOgrenciBilgi.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 563);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(lblDersler);
            Controls.Add(lblOgrenciBilgi);
            Name = "Form2";
            Text = "Ders Ekleme";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label lblDersler;
        private Label lblOgrenciBilgi;
    }
}