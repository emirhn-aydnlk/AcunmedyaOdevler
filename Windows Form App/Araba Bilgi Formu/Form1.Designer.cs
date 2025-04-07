namespace Araba_Bilgi_Formu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pencereSayisi = new System.Windows.Forms.TextBox();
            this.yakitTuketimi = new System.Windows.Forms.TextBox();
            this.kapiSayisi = new System.Windows.Forms.TextBox();
            this.renk = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kapı Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pencere Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yakıt Tüketimi";
            // 
            // pencereSayisi
            // 
            this.pencereSayisi.Location = new System.Drawing.Point(176, 259);
            this.pencereSayisi.Name = "pencereSayisi";
            this.pencereSayisi.Size = new System.Drawing.Size(127, 22);
            this.pencereSayisi.TabIndex = 6;
            // 
            // yakitTuketimi
            // 
            this.yakitTuketimi.Location = new System.Drawing.Point(176, 304);
            this.yakitTuketimi.Name = "yakitTuketimi";
            this.yakitTuketimi.Size = new System.Drawing.Size(127, 22);
            this.yakitTuketimi.TabIndex = 7;
            // 
            // kapiSayisi
            // 
            this.kapiSayisi.Location = new System.Drawing.Point(176, 207);
            this.kapiSayisi.Name = "kapiSayisi";
            this.kapiSayisi.Size = new System.Drawing.Size(127, 22);
            this.kapiSayisi.TabIndex = 8;
            // 
            // renk
            // 
            this.renk.Location = new System.Drawing.Point(176, 156);
            this.renk.Name = "renk";
            this.renk.Size = new System.Drawing.Size(127, 22);
            this.renk.TabIndex = 9;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(176, 108);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(127, 22);
            this.model.TabIndex = 10;
            // 
            // marka
            // 
            this.marka.Location = new System.Drawing.Point(176, 62);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(127, 22);
            this.marka.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Bilgileri Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.model);
            this.Controls.Add(this.renk);
            this.Controls.Add(this.kapiSayisi);
            this.Controls.Add(this.yakitTuketimi);
            this.Controls.Add(this.pencereSayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pencereSayisi;
        private System.Windows.Forms.TextBox yakitTuketimi;
        private System.Windows.Forms.TextBox kapiSayisi;
        private System.Windows.Forms.TextBox renk;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.Button button1;
    }
}

