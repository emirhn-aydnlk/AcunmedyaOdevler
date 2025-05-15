using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using HastaRandevuSistemi.Models;
using System.Reflection;

namespace HastaRandevuSistemi
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HastaKayitSistemi;Integrated Security=True";
        int bransID;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen hasta adı ve soyadını giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        int BransID = Convert.ToInt32(cmbBrans.SelectedValue);
                        int DoktorID = Convert.ToInt32(cmbDoktor.SelectedValue);
                        DateTime Tarih = dateTimePicker1.Value;
                        string Saat = cmbSaat.SelectedItem.ToString();

                        string sorgu = "INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih, Saat) VALUES (@HastaAdi, @HastaSoyadi, @BransID, @DoktorID, @Tarih, @Saat)";
                        SqlCommand command = new SqlCommand(sorgu, connection);

                        command.Parameters.AddWithValue("@HastaAdi", SqlDbType.NVarChar).Value = txtAd.Text;
                        command.Parameters.AddWithValue("@HastaSoyadi", SqlDbType.NVarChar).Value = txtSoyad.Text;
                        command.Parameters.AddWithValue("@BransID", SqlDbType.Int).Value = BransID;
                        command.Parameters.AddWithValue("@DoktorID", SqlDbType.Int).Value = DoktorID;
                        command.Parameters.AddWithValue("@Tarih", SqlDbType.Date).Value = Tarih;
                        command.Parameters.AddWithValue("@Saat", SqlDbType.Time).Value = Saat;

                        int sonuc = command.ExecuteNonQuery();
                        if (sonuc > 0)
                        {
                            MessageBox.Show("Randevu başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Randevu kaydedilirken hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void BransListele()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Branslar> branslistesi = null;
                try
                {
                    connection.Open();
                    string sorgu = "SELECT * FROM Branslar";
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    branslistesi = new List<Branslar>();
                    branslistesi.Add(new Branslar
                    {
                        id = -1,
                        bransAdi = "Branş Seçiniz"
                    });
                    while (reader.Read())
                    {

                        branslistesi.Add(new Branslar
                        {
                            id = Convert.ToInt32(reader["Id"]),
                            bransAdi = reader["BransAdi"].ToString()
                        });
                    }

                    cmbBrans.DataSource = branslistesi;
                    cmbBrans.DisplayMember = "bransAdi";
                    cmbBrans.ValueMember = "id";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void DoktorListele(int bransID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Doktorlar> doktorListesi = null;
                try
                {
                    connection.Open();
                    string sorgu = "SELECT * FROM Doktorlar WHERE BransID=" + bransID;
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    doktorListesi = new List<Doktorlar>();
                    doktorListesi.Add(new Doktorlar
                    {
                        id = -1,
                        doktorAdiSoyadi = "Doktor Seçiniz"
                    });
                    while (reader.Read())
                    {
                        int doktorId = Convert.ToInt32(reader["Id"]);
                        string doktorAdiSoyadi = reader["DoktorAdi"].ToString() + " " + reader["DoktorSoyadi"].ToString();
                        doktorListesi.Add(new Doktorlar
                        {
                            id = doktorId,
                            doktorAdiSoyadi = doktorAdiSoyadi
                        });

                    }

                    cmbDoktor.DataSource = doktorListesi;
                    cmbDoktor.DisplayMember = "doktorAdiSoyadi";
                    cmbDoktor.ValueMember = "id";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BransListele();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            Branslar secilenBrans = (Branslar)cmbBrans.SelectedItem;
            if (secilenBrans.id > 0)
            {
                DoktorListele(secilenBrans.id);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime secilenTarih = dateTimePicker1.Value;

            // haftasonu bir gün seçmeyi engelliyoruz
            if (secilenTarih.DayOfWeek == DayOfWeek.Saturday || secilenTarih.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Hafta sonu seçilemez! Lütfen hafta içi bir gün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.Value = DateTime.Today;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int secilenBransID = Convert.ToInt32(cmbBrans.SelectedValue);
                int secilenDoktorID = Convert.ToInt32(cmbDoktor.SelectedValue);

                // burada mevcut randevuları kontrol ediyoruz
                string sorgu = "SELECT Saat FROM Randevular WHERE BransID = @BransID AND DoktorID = @DoktorID AND Tarih = @Tarih";
                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@BransID", secilenBransID);
                command.Parameters.AddWithValue("@DoktorID", secilenDoktorID);
                command.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value.Date);

                SqlDataReader reader = command.ExecuteReader();

                List<string> doluSaatler = new List<string>();
                while (reader.Read())
                {
                    doluSaatler.Add(reader["Saat"].ToString());
                }
                reader.Close();

                // eğer seçilen branşta, seçilen doktorda, seçilen saatte zaten randevu varsa o saat combox'tan kalkacak
                foreach (var item in cmbSaat.Items.Cast<string>().ToList())
                {
                    if (doluSaatler.Contains(item))
                    {
                        cmbSaat.Items.Remove(item);
                    }
                }
            }
        }

        private void cmbSaat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
