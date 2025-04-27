namespace OgrenciBilgiFormu
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
            lblBolum = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            btnDogrulama = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(61, 95);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(31, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(61, 153);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(53, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad:";
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Location = new Point(61, 210);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(55, 20);
            lblBolum.TabIndex = 2;
            lblBolum.Text = "Bolum:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(131, 92);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(182, 27);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(131, 150);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(182, 27);
            txtSoyad.TabIndex = 4;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(131, 207);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(182, 27);
            txtBolum.TabIndex = 5;
            // 
            // btnDogrulama
            // 
            btnDogrulama.Location = new Point(365, 129);
            btnDogrulama.Name = "btnDogrulama";
            btnDogrulama.Size = new Size(128, 69);
            btnDogrulama.TabIndex = 6;
            btnDogrulama.Text = "Bilgileri Dogrula";
            btnDogrulama.UseVisualStyleBackColor = true;
            btnDogrulama.Click += btnDogrulama_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(236, 348);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(0, 20);
            lblSonuc.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 585);
            Controls.Add(lblSonuc);
            Controls.Add(btnDogrulama);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(lblBolum);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblBolum;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtBolum;
        private Button btnDogrulama;
        private Label lblSonuc;
    }
}
