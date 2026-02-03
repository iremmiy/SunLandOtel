using System;
using System.Windows.Forms;

namespace SunLandOtel.Forms
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        // Müşteri İşlemleri Butonu
        private void btnMusteriMenu_Click(object sender, EventArgs e)
        {
            FrmMusteri frm = new FrmMusteri();
            frm.Show();
        }

        // Oda Yönetimi Butonu
        private void btnOdaMenu_Click(object sender, EventArgs e)
        {
            FrmOda frm = new FrmOda();
            frm.Show();
        }

        // Personel Yönetimi Butonu
        private void btnPersonelMenu_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.Show();
        }

        // Rezervasyon Yap Butonu
        private void btnRezervasyonMenu_Click(object sender, EventArgs e)
        {
            FrmRezervasyon frm = new FrmRezervasyon();
            frm.Show();
        }

        // Ödemeler Butonu
        private void btnOdemeMenu_Click(object sender, EventArgs e)
        {
            FrmOdeme frm = new FrmOdeme();
            frm.Show();
        }

        // Çıkış Butonu
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Programı tamamen kapatır
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}