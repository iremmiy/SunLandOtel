using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SunLandOtel.Forms
{
    public partial class FrmOdeme : Form
    {
        private string connectionString = @"Server=.;Database=SunLandOtel;Trusted_Connection=True;";
        private int selectedOdemeID = -1;

        public FrmOdeme()
        {
            InitializeComponent();
            LoadOdemeYontemi();
            LoadOdemeler();
            LoadMusteriler();
            LoadRezervasyonlar();

            // Buton eventleri
            btnodeEkle.Click += BtnodeEkle_Click;
            btnodeGuncelle.Click += BtnodeGuncelle_Click;
            btnodeSil.Click += BtnodeSil_Click;

            dgvOdemeler.CellClick += dgvOdemeler_CellClick;
        }

        #region Load Methods
        private void LoadOdemeYontemi()
        {
            cmbOdemeYontemi.Items.Clear();
            cmbOdemeYontemi.Items.Add("Nakit");
            cmbOdemeYontemi.Items.Add("Kredi Kartı");
            cmbOdemeYontemi.Items.Add("Havale/EFT");
            cmbOdemeYontemi.SelectedIndex = 0;
        }

        private void LoadMusteriler()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ad + ' ' + soyad AS AdSoyad FROM Musteri", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txtOdemeMusteri.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtOdemeMusteri.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtOdemeMusteri.AutoCompleteCustomSource.Clear();

                foreach (DataRow row in dt.Rows)
                    txtOdemeMusteri.AutoCompleteCustomSource.Add(row["AdSoyad"].ToString());
            }
        }

        private void LoadRezervasyonlar()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT rezervasyon_id FROM Rezervasyon", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txtOdemeResId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtOdemeResId.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtOdemeResId.AutoCompleteCustomSource.Clear();

                foreach (DataRow row in dt.Rows)
                    txtOdemeResId.AutoCompleteCustomSource.Add(row["rezervasyon_id"].ToString());
            }
        }

        private void LoadOdemeler()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT Odeme.odeme_id, Odeme.rezervasyon_id, Odeme.musteri_id, 
                                        Odeme.tutar, Odeme.odeme_tipi, Odeme.odeme_tarihi,
                                        Musteri.ad + ' ' + Musteri.soyad AS MusteriAdSoyad
                                 FROM Odeme
                                 JOIN Musteri ON Odeme.musteri_id = Musteri.musteri_id";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOdemeler.DataSource = dt;

                dgvOdemeler.Columns["odeme_id"].HeaderText = "Ödeme ID";
                dgvOdemeler.Columns["rezervasyon_id"].HeaderText = "Rezervasyon ID";
                dgvOdemeler.Columns["musteri_id"].HeaderText = "Müşteri ID";
                dgvOdemeler.Columns["tutar"].HeaderText = "Tutar";
                dgvOdemeler.Columns["odeme_tipi"].HeaderText = "Ödeme Tipi";
                dgvOdemeler.Columns["odeme_tarihi"].HeaderText = "Ödeme Tarihi";
                dgvOdemeler.Columns["MusteriAdSoyad"].HeaderText = "Müşteri Ad Soyad";
            }
        }
        #endregion

        #region CRUD Methods
        private void ClearForm()
        {
            txtOdemeResId.Clear();
            txtOdemeMusteri.Clear();
            txtOdemeTutar.Clear();
            cmbOdemeYontemi.SelectedIndex = 0;
            dtpOdemeTarihi.Value = DateTime.Now;
            selectedOdemeID = -1;
        }

        private void AddOdeme()
        {
            if (string.IsNullOrWhiteSpace(txtOdemeResId.Text) ||
                string.IsNullOrWhiteSpace(txtOdemeMusteri.Text) ||
                string.IsNullOrWhiteSpace(txtOdemeTutar.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmdMusteri = new SqlCommand("SELECT musteri_id FROM Musteri WHERE ad + ' ' + soyad = @AdSoyad", conn);
                cmdMusteri.Parameters.AddWithValue("@AdSoyad", txtOdemeMusteri.Text);

                conn.Open();
                object result = cmdMusteri.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Geçerli bir müşteri seçin.");
                    conn.Close();
                    return;
                }
                int musteri_id = Convert.ToInt32(result);

                string query = @"INSERT INTO Odeme (odeme_id, rezervasyon_id, musteri_id, odeme_tarihi, tutar, odeme_tipi)
                                 VALUES (@odeme_id, @rezervasyon_id, @musteri_id, @odeme_tarihi, @tutar, @odeme_tipi)";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlCommand cmdMax = new SqlCommand("SELECT ISNULL(MAX(odeme_id), 7000) + 1 FROM Odeme", conn);
                int newID = (int)cmdMax.ExecuteScalar();

                cmd.Parameters.AddWithValue("@odeme_id", newID);
                cmd.Parameters.AddWithValue("@rezervasyon_id", txtOdemeResId.Text);
                cmd.Parameters.AddWithValue("@musteri_id", musteri_id);
                cmd.Parameters.AddWithValue("@odeme_tarihi", dtpOdemeTarihi.Value);
                cmd.Parameters.AddWithValue("@tutar", Convert.ToInt32(txtOdemeTutar.Text));
                cmd.Parameters.AddWithValue("@odeme_tipi", cmbOdemeYontemi.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Ödeme eklendi!");
            ClearForm();
            LoadOdemeler();
        }

        private void UpdateOdeme()
        {
            if (selectedOdemeID == -1)
            {
                MessageBox.Show("Güncellemek için bir ödeme seçin!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmdMusteri = new SqlCommand("SELECT musteri_id FROM Musteri WHERE ad + ' ' + soyad = @AdSoyad", conn);
                cmdMusteri.Parameters.AddWithValue("@AdSoyad", txtOdemeMusteri.Text);

                conn.Open();
                object result = cmdMusteri.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Geçerli bir müşteri seçin.");
                    conn.Close();
                    return;
                }
                int musteri_id = Convert.ToInt32(result);

                string query = @"UPDATE Odeme SET rezervasyon_id=@rezervasyon_id, musteri_id=@musteri_id, 
                                 odeme_tarihi=@odeme_tarihi, tutar=@tutar, odeme_tipi=@odeme_tipi
                                 WHERE odeme_id=@odeme_id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rezervasyon_id", txtOdemeResId.Text);
                cmd.Parameters.AddWithValue("@musteri_id", musteri_id);
                cmd.Parameters.AddWithValue("@odeme_tarihi", dtpOdemeTarihi.Value);
                cmd.Parameters.AddWithValue("@tutar", Convert.ToInt32(txtOdemeTutar.Text));
                cmd.Parameters.AddWithValue("@odeme_tipi", cmbOdemeYontemi.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@odeme_id", selectedOdemeID);

                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Ödeme güncellendi!");
            ClearForm();
            LoadOdemeler();
        }

        private void DeleteOdeme()
        {
            if (selectedOdemeID == -1)
            {
                MessageBox.Show("Silmek için bir ödeme seçin!");
                return;
            }

            var result = MessageBox.Show("Bu ödemeyi silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Odeme WHERE odeme_id=@odeme_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@odeme_id", selectedOdemeID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Ödeme silindi!");
                ClearForm();
                LoadOdemeler();
            }
        }
        #endregion

        #region Event Handlers
        private void dgvOdemeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOdemeler.Rows[e.RowIndex];
                selectedOdemeID = Convert.ToInt32(row.Cells["odeme_id"].Value);
                txtOdemeResId.Text = row.Cells["rezervasyon_id"].Value.ToString();
                txtOdemeMusteri.Text = row.Cells["MusteriAdSoyad"].Value.ToString();
                txtOdemeTutar.Text = row.Cells["tutar"].Value.ToString();
                cmbOdemeYontemi.SelectedItem = row.Cells["odeme_tipi"].Value.ToString();
                dtpOdemeTarihi.Value = Convert.ToDateTime(row.Cells["odeme_tarihi"].Value);
            }
        }

        private void BtnodeEkle_Click(object sender, EventArgs e) => AddOdeme();
        private void BtnodeGuncelle_Click(object sender, EventArgs e) => UpdateOdeme();
        private void BtnodeSil_Click(object sender, EventArgs e) => DeleteOdeme();
        #endregion
    }
}