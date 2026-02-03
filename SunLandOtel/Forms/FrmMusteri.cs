using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SunLandOtel.Forms
{
    public partial class FrmMusteri : Form
    {
        private string connectionString = @"Server=.;Database=SunLandOtel;Trusted_Connection=True;";
        private int selectedMusteriID = -1;

        public FrmMusteri()
        {
            InitializeComponent();
            LoadMusteriler();

            btnEkle.Click += BtnEkle_Click;
            btnGuncelle.Click += BtnGuncelle_Click;
            btnSil.Click += BtnSil_Click;
            dgvMusteriler.CellClick += DgvMusteriler_CellClick;
        }

        // READ
        private void LoadMusteriler()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT musteri_id, ad, soyad, telefon, email, dogum_tarihi FROM Musteri";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMusteriler.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata: " + ex.Message);
            }
        }

        // FORM TEMİZLE
        private void ClearForm()
        {
            txtMusteriId.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            dtpDogumTarihi.Value = DateTime.Now;
            selectedMusteriID = -1;
        }

        // CREATE
        private void AddMusteri()
        {
            if (string.IsNullOrWhiteSpace(txtMusteriId.Text) ||
                string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("ID, Ad ve Soyad zorunludur!");
                return;
            }

            try
            {
                int newId = Convert.ToInt32(txtMusteriId.Text);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Musteri (musteri_id, ad, soyad, telefon, email, dogum_tarihi)
                                     VALUES (@id, @ad, @soyad, @tel, @email, @dogum)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", newId);
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@tel", string.IsNullOrWhiteSpace(txtTelefon.Text) ? (object)DBNull.Value : txtTelefon.Text);
                    cmd.Parameters.AddWithValue("@email", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text);
                    cmd.Parameters.AddWithValue("@dogum", dtpDogumTarihi.Value.Date);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Müşteri eklendi!");
                ClearForm();
                LoadMusteriler();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("ID sadece sayı olmalıdır!");
            }
        }

        // UPDATE
        private void UpdateMusteri()
        {
            if (selectedMusteriID == -1)
            {
                MessageBox.Show("Güncellemek için müşteri seçin.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Musteri 
                                     SET ad=@ad, soyad=@soyad, telefon=@tel, email=@email, dogum_tarihi=@dogum
                                     WHERE musteri_id=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@tel", string.IsNullOrWhiteSpace(txtTelefon.Text) ? (object)DBNull.Value : txtTelefon.Text);
                    cmd.Parameters.AddWithValue("@email", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text);
                    cmd.Parameters.AddWithValue("@dogum", dtpDogumTarihi.Value.Date);
                    cmd.Parameters.AddWithValue("@id", selectedMusteriID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Müşteri güncellendi!");
                ClearForm();
                LoadMusteriler();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        // DELETE
        private void DeleteMusteri()
        {
            if (selectedMusteriID == -1)
            {
                MessageBox.Show("Silmek için müşteri seçin.");
                return;
            }

            var result = MessageBox.Show("Bu müşteriyi silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Musteri WHERE musteri_id=@id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedMusteriID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Müşteri silindi!");
                    ClearForm();
                    LoadMusteriler();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("HATA: " + ex.Message);
                }
            }
        }

        // DataGridView satır seçimi
        private void DgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMusteriler.Rows[e.RowIndex];
                selectedMusteriID = Convert.ToInt32(row.Cells["musteri_id"].Value);
                txtMusteriId.Text = selectedMusteriID.ToString();
                txtAd.Text = row.Cells["ad"].Value?.ToString();
                txtSoyad.Text = row.Cells["soyad"].Value?.ToString();
                txtTelefon.Text = row.Cells["telefon"].Value?.ToString();
                txtEmail.Text = row.Cells["email"].Value?.ToString();

                if (row.Cells["dogum_tarihi"].Value != DBNull.Value)
                    dtpDogumTarihi.Value = Convert.ToDateTime(row.Cells["dogum_tarihi"].Value);
                else
                    dtpDogumTarihi.Value = DateTime.Now;
            }
        }

        // Butonlar
        private void BtnEkle_Click(object sender, EventArgs e) => AddMusteri();
        private void BtnGuncelle_Click(object sender, EventArgs e) => UpdateMusteri();
        private void BtnSil_Click(object sender, EventArgs e) => DeleteMusteri();
    }
}