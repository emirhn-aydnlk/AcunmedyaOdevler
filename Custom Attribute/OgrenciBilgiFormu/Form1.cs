namespace OgrenciBilgiFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogrulama_Click(object sender, EventArgs e)
        {
            OgrenciBilgileri ob = new OgrenciBilgileri();
            ob.ad = txtAd.Text;
            ob.soyad = txtSoyad.Text;
            ob.bolum = txtBolum.Text;

            txtAd.BackColor = SystemColors.Window;
            txtSoyad.BackColor = SystemColors.Window;
            txtBolum.BackColor = SystemColors.Window;

            if (!ZorunluAlanKontrolu.Dogrula(ob))
            {
                string hataMesaji = "Lutfen asagidaki alanlari doldurunuz:\n";
                for (int i = 0; i < ZorunluAlanKontrolu.bosAlanlar.Count; i++)
                {
                    hataMesaji += $"{ZorunluAlanKontrolu.bosAlanlar[i]} bos birakilamaz.\n";
                }

                MessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                foreach (string bosAlan in ZorunluAlanKontrolu.bosAlanlar)
                {
                    if (bosAlan == nameof(ob.ad))
                    {
                        txtAd.BackColor = Color.LightCoral;
                    }
                    else if (bosAlan == nameof(ob.soyad))
                    {
                        txtSoyad.BackColor = Color.LightCoral;
                    }
                    else if (bosAlan == nameof(ob.bolum))
                    {
                        txtBolum.BackColor = Color.LightCoral;
                    }
                }
            }
            else
            {
                lblSonuc.Text = $"Kayit Basarili\n Ogrenci Adi: {ob.ad}\n Ogrenci Soyadi: {ob.soyad}\n Ogrenci Bolumu: {ob.bolum}";
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtBolum.Text = "";
            }
        }
    }
}
