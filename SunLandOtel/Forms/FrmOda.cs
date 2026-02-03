using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SunLandOtel.Forms
{
    public partial class FrmOda : Form
    {
        private string connectionString = "Server=localhost;Database=SunLandOtel;Trusted_Connection=True;";
        private SqlConnection conn;

        public FrmOda()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);

            // Olayları bağla
            btnOdaEkle.Click += btnOdaEkle_Click;
            btnOdaSil.Click += btnOdaSil_Click;
            btnOdaGuncelle.Click += btnOdaGuncelle_Click;
            dgvOdalar.CellClick += dgvOdalar_CellClick;

            Listele(); // Form açıldığında odaları listele
        }

        private void Listele()
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Oda", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvOdalar.DataSource = dt;

                    // DataGridView otomatik kolon boyutlandırma
                    dgvOdalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvOdalar.AllowUserToAddRows = false;
                    dgvOdalar.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }

        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOdaNo.Text, out int odaId) ||
                !int.TryParse(txtKat.Text, out int kat) ||
                !int.TryParse(txtFiyat.Text, out int fiyat))
            {
                MessageBox.Show("Oda No, Kat ve Fiyat alanları sayı olmalıdır.");
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Oda (oda_id, oda_numarasi, kat, tip, fiyat, durum) " +
                    "VALUES (@id, @numara, @kat, @tip, @fiyat, @durum)", conn))
                {
                    cmd.Parameters.AddWithValue("@id", odaId);
                    cmd.Parameters.AddWithValue("@numara", odaId);
                    cmd.Parameters.AddWithValue("@kat", kat);
                    cmd.Parameters.AddWithValue("@tip", txtOdaTipi.Text);
                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                    cmd.Parameters.AddWithValue("@durum", txtDurum.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Oda başarıyla eklendi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message);
            }
            finally
            {
                conn.Close();
                Listele();
            }
        }

        private void btnOdaSil_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOdaNo.Text, out int odaId))
            {
                MessageBox.Show("Oda No alanı sayı olmalıdır.");
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Oda WHERE oda_id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", odaId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Oda başarıyla silindi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
            finally
            {
                conn.Close();
                Listele();
            }
        }

        private void btnOdaGuncelle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOdaNo.Text, out int odaId) ||
                !int.TryParse(txtKat.Text, out int kat) ||
                !int.TryParse(txtFiyat.Text, out int fiyat))
            {
                MessageBox.Show("Oda No, Kat ve Fiyat alanları sayı olmalıdır.");
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Oda SET kat=@kat, tip=@tip, fiyat=@fiyat, durum=@durum WHERE oda_id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", odaId);
                    cmd.Parameters.AddWithValue("@kat", kat);
                    cmd.Parameters.AddWithValue("@tip", txtOdaTipi.Text);
                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                    cmd.Parameters.AddWithValue("@durum", txtDurum.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Oda başarıyla güncellendi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
            finally
            {
                conn.Close();
                Listele();
            }
        }

        private void dgvOdalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOdalar.Rows[e.RowIndex];
                txtOdaNo.Text = row.Cells[0].Value.ToString(); // oda_id
                txtKat.Text = row.Cells[2].Value.ToString();   // kat
                txtOdaTipi.Text = row.Cells[3].Value.ToString(); // tip
                txtFiyat.Text = row.Cells[4].Value.ToString();   // fiyat
                txtDurum.Text = row.Cells[5].Value.ToString();   // durum
            }
        }
    }
}