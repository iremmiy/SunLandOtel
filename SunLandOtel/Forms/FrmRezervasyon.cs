using SunLandOtel.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SunLandOtel.Forms
{
    public partial class FrmRezervasyon : Form
    {
        public FrmRezervasyon()
        {
            InitializeComponent();

            this.Load += FrmRezervasyon_Load;
            btnResEkle.Click += BtnResEkle_Click;
            btnResGuncelle.Click += BtnResGuncelle_Click;
            btnResSil.Click += BtnResSil_Click;
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void FrmRezervasyon_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Rezervasyon", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }

        private bool CheckForeignKeys(int musteriId, int odaId, int personelId)
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();
                int musteriCount = (int)new SqlCommand("SELECT COUNT(*) FROM Musteri WHERE musteri_id=@musteri", conn)
                {
                    Parameters = { new SqlParameter("@musteri", musteriId) }
                }.ExecuteScalar();

                int odaCount = (int)new SqlCommand("SELECT COUNT(*) FROM Oda WHERE oda_id=@oda", conn)
                {
                    Parameters = { new SqlParameter("@oda", odaId) }
                }.ExecuteScalar();

                int personelCount = (int)new SqlCommand("SELECT COUNT(*) FROM Personel WHERE personel_id=@personel", conn)
                {
                    Parameters = { new SqlParameter("@personel", personelId) }
                }.ExecuteScalar();

                return musteriCount > 0 && odaCount > 0 && personelCount > 0;
            }
        }

        private void BtnResEkle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtresrezid.Text, out int rezId) ||
                !int.TryParse(txtResMusteriId.Text, out int musteriId) ||
                !int.TryParse(txtResOdaId.Text, out int odaId) ||
                !int.TryParse(txtResPersonelId.Text, out int personelId) ||
                !decimal.TryParse(txtToplamUcret.Text, out decimal toplamUcret))
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurun.");
                return;
            }

            if (!CheckForeignKeys(musteriId, odaId, personelId))
            {
                MessageBox.Show("Müşteri, Oda veya Personel bilgisi geçerli değil.");
                return;
            }

            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    string sql = @"INSERT INTO Rezervasyon 
                                   (rezervasyon_id, musteri_id, oda_id, personel_id, giris_tarihi, cikis_tarihi, toplam_ucret)
                                   VALUES (@id, @musteri, @oda, @personel, @giris, @cikis, @ucret)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", rezId);
                        cmd.Parameters.AddWithValue("@musteri", musteriId);
                        cmd.Parameters.AddWithValue("@oda", odaId);
                        cmd.Parameters.AddWithValue("@personel", personelId);
                        cmd.Parameters.AddWithValue("@giris", dtpGirisTarihi.Value);
                        cmd.Parameters.AddWithValue("@cikis", dtpCikisTarihi.Value);
                        cmd.Parameters.AddWithValue("@ucret", toplamUcret);

                        conn.Open();
                        int sonuc = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Rezervasyon başarıyla eklendi.");
                            Listele();
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Ekleme başarısız.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void BtnResGuncelle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtresrezid.Text, out int rezId))
            {
                MessageBox.Show("Geçerli Rezervasyon ID giriniz.");
                return;
            }

            if (!int.TryParse(txtResMusteriId.Text, out int musteriId) ||
                !int.TryParse(txtResOdaId.Text, out int odaId) ||
                !int.TryParse(txtResPersonelId.Text, out int personelId) ||
                !decimal.TryParse(txtToplamUcret.Text, out decimal toplamUcret))
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurun.");
                return;
            }

            if (!CheckForeignKeys(musteriId, odaId, personelId))
            {
                MessageBox.Show("Müşteri, Oda veya Personel bilgisi geçerli değil.");
                return;
            }

            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    string sql = @"UPDATE Rezervasyon 
                                   SET musteri_id=@musteri, oda_id=@oda, personel_id=@personel, 
                                       giris_tarihi=@giris, cikis_tarihi=@cikis, toplam_ucret=@ucret
                                   WHERE rezervasyon_id=@id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", rezId);
                        cmd.Parameters.AddWithValue("@musteri", musteriId);
                        cmd.Parameters.AddWithValue("@oda", odaId);
                        cmd.Parameters.AddWithValue("@personel", personelId);
                        cmd.Parameters.AddWithValue("@giris", dtpGirisTarihi.Value);
                        cmd.Parameters.AddWithValue("@cikis", dtpCikisTarihi.Value);
                        cmd.Parameters.AddWithValue("@ucret", toplamUcret);

                        conn.Open();
                        int etkilenen = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (etkilenen > 0)
                        {
                            MessageBox.Show("Rezervasyon güncellendi.");
                            Listele();
                            Temizle();
                        }
                        else
                        {
                            MessageBox.Show("Seçilen rezervasyon bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }

        private void BtnResSil_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtresrezid.Text, out int rezId))
            {
                MessageBox.Show("Geçerli Rezervasyon ID giriniz.");
                return;
            }

            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    string sql = "DELETE FROM Rezervasyon WHERE rezervasyon_id=@id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", rezId);
                        conn.Open();
                        try
                        {
                            int etkilenen = cmd.ExecuteNonQuery();
                            if (etkilenen > 0)
                            {
                                MessageBox.Show("Rezervasyon silindi.");
                                Listele();
                                Temizle();
                            }
                            else
                            {
                                MessageBox.Show("Seçilen rezervasyon bulunamadı.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Number == 547) // Foreign key violation
                                MessageBox.Show("Bu rezervasyon başka tablolar tarafından kullanılıyor, silme işlemi yapılamaz.");
                            else
                                MessageBox.Show("Silme hatası: " + ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtresrezid.Text = row.Cells["rezervasyon_id"].Value.ToString();
                txtResMusteriId.Text = row.Cells["musteri_id"].Value.ToString();
                txtResOdaId.Text = row.Cells["oda_id"].Value.ToString();
                txtResPersonelId.Text = row.Cells["personel_id"].Value.ToString();
                dtpGirisTarihi.Value = Convert.ToDateTime(row.Cells["giris_tarihi"].Value);
                dtpCikisTarihi.Value = Convert.ToDateTime(row.Cells["cikis_tarihi"].Value);
                txtToplamUcret.Text = row.Cells["toplam_ucret"].Value.ToString();
            }
        }

        private void Temizle()
        {
            txtresrezid.Clear();
            txtResMusteriId.Clear();
            txtResOdaId.Clear();
            txtResPersonelId.Clear();
            txtToplamUcret.Clear();
            dtpGirisTarihi.Value = DateTime.Now;
            dtpCikisTarihi.Value = DateTime.Now;
        }
    }
}