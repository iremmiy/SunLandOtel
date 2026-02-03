using SunLandOtel.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SunLandOtel.Forms
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();

            // Buton eventlerini burada bağlayabiliriz
            btnPersEkle.Click += btnPersEkle_Click;
            btnPersGuncelle.Click += btnPersGuncelle_Click;
            btnPersSil.Click += btnPersSil_Click;

            this.Load += FrmPersonel_Load;
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Listele();
        }

        // Personel Listeleme
        private void Listele()
        {
            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personel", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // DataGridView adı dgvPersonel olmalı
                    dgvPersonel.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }

        // Personel Ekleme
        private void btnPersEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    string sql = "INSERT INTO Personel (personel_id, ad, soyad, gorev, maas, telefon) " +
                                 "VALUES (@id, @ad, @soyad, @gorev, @maas, @telefon)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(txtPersId.Text));
                        cmd.Parameters.AddWithValue("@ad", txtPersAd.Text);
                        cmd.Parameters.AddWithValue("@soyad", txtPersSoyad.Text);
                        cmd.Parameters.AddWithValue("@gorev", txtPersGorev.Text);
                        cmd.Parameters.AddWithValue("@maas", int.Parse(txtPersMaas.Text));
                        cmd.Parameters.AddWithValue("@telefon", txtPersTelefon.Text);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Personel başarıyla eklendi.");
                        Listele();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message);
            }
        }

        // Personel Güncelleme
        private void btnPersGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    string sql = @"UPDATE Personel 
                                   SET ad=@ad, soyad=@soyad, gorev=@gorev, maas=@maas, telefon=@telefon
                                   WHERE personel_id=@id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(txtPersId.Text));
                        cmd.Parameters.AddWithValue("@ad", txtPersAd.Text);
                        cmd.Parameters.AddWithValue("@soyad", txtPersSoyad.Text);
                        cmd.Parameters.AddWithValue("@gorev", txtPersGorev.Text);
                        cmd.Parameters.AddWithValue("@maas", int.Parse(txtPersMaas.Text));
                        cmd.Parameters.AddWithValue("@telefon", txtPersTelefon.Text);

                        conn.Open();
                        int etkilenen = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (etkilenen > 0)
                            MessageBox.Show("Personel güncellendi.");
                        else
                            MessageBox.Show("Bu ID ile personel bulunamadı.");

                        Listele();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }

        // Personel Silme
        private void btnPersSil_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    string sql = "DELETE FROM Personel WHERE personel_id=@id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(txtPersId.Text));

                        conn.Open();
                        int etkilenen = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (etkilenen > 0)
                            MessageBox.Show("Personel silindi.");
                        else
                            MessageBox.Show("Bu ID ile personel bulunamadı.");

                        Listele();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
            }
        }

        private void grpPersonel_Enter(object sender, EventArgs e)
        {

        }
    }
}