namespace HastaRandevuSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAd = new Label();
            lblSoyad = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            lblBrans = new Label();
            lblDoktor = new Label();
            cmbDoktor = new ComboBox();
            cmbBrans = new ComboBox();
            lblTarih = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblSaat = new Label();
            cmbSaat = new ComboBox();
            btnRandevu = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(314, 77);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(77, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Hasta Adı:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(292, 126);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(99, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Hasta Soyadı:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(408, 74);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(180, 27);
            txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(408, 126);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(180, 27);
            txtSoyad.TabIndex = 3;
            // 
            // lblBrans
            // 
            lblBrans.AutoSize = true;
            lblBrans.Location = new Point(343, 188);
            lblBrans.Name = "lblBrans";
            lblBrans.Size = new Size(48, 20);
            lblBrans.TabIndex = 4;
            lblBrans.Text = "Branş:";
            // 
            // lblDoktor
            // 
            lblDoktor.AutoSize = true;
            lblDoktor.Location = new Point(333, 253);
            lblDoktor.Name = "lblDoktor";
            lblDoktor.Size = new Size(58, 20);
            lblDoktor.TabIndex = 6;
            lblDoktor.Text = "Doktor:";
            // 
            // cmbDoktor
            // 
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(408, 250);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(180, 28);
            cmbDoktor.TabIndex = 7;
            cmbDoktor.SelectedIndexChanged += cmbDoktor_SelectedIndexChanged;
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(408, 188);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(180, 28);
            cmbBrans.TabIndex = 8;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(348, 317);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(43, 20);
            lblTarih.TabIndex = 9;
            lblTarih.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(408, 317);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 27);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Location = new Point(350, 387);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(41, 20);
            lblSaat.TabIndex = 11;
            lblSaat.Text = "Saat:";
            // 
            // cmbSaat
            // 
            cmbSaat.FormattingEnabled = true;
            cmbSaat.Items.AddRange(new object[] { "09:00", "10:00", "11:00", "12:00", "14:00", "15:00", "16:00" });
            cmbSaat.Location = new Point(408, 384);
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new Size(180, 28);
            cmbSaat.TabIndex = 12;
            cmbSaat.SelectedIndexChanged += cmbSaat_SelectedIndexChanged;
            // 
            // btnRandevu
            // 
            btnRandevu.Location = new Point(395, 472);
            btnRandevu.Name = "btnRandevu";
            btnRandevu.Size = new Size(211, 55);
            btnRandevu.TabIndex = 13;
            btnRandevu.Text = "Randevu Oluştur";
            btnRandevu.UseVisualStyleBackColor = true;
            btnRandevu.Click += btnRandevu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 583);
            Controls.Add(btnRandevu);
            Controls.Add(cmbSaat);
            Controls.Add(lblSaat);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblTarih);
            Controls.Add(cmbBrans);
            Controls.Add(cmbDoktor);
            Controls.Add(lblDoktor);
            Controls.Add(lblBrans);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label lblBrans;
        private Label lblDoktor;
        private ComboBox cmbDoktor;
        private ComboBox cmbBrans;
        private Label lblTarih;
        private DateTimePicker dateTimePicker1;
        private Label lblSaat;
        private ComboBox cmbSaat;
        private Button btnRandevu;
    }
}
