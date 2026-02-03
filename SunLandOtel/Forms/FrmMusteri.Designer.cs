namespace SunLandOtel.Forms
{
    partial class FrmMusteri
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
            grpMusteriBilgileri = new GroupBox();
            dtpDogumTarihi = new DateTimePicker();
            label1 = new Label();
            txtTelefon = new TextBox();
            txtSoyad = new TextBox();
            lblDogumTarihi = new Label();
            lblMusteriId = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            txtEmail = new TextBox();
            txtAd = new TextBox();
            lblMusteriEmail = new Label();
            lblMusteriTel = new Label();
            lblMusteriSoyad = new Label();
            lblMusteriAd = new Label();
            dgvMusteriler = new DataGridView();
            txtMusteriId = new TextBox();
            grpMusteriBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // grpMusteriBilgileri
            // 
            grpMusteriBilgileri.BackColor = Color.LightCyan;
            grpMusteriBilgileri.Controls.Add(txtMusteriId);
            grpMusteriBilgileri.Controls.Add(dtpDogumTarihi);
            grpMusteriBilgileri.Controls.Add(label1);
            grpMusteriBilgileri.Controls.Add(txtTelefon);
            grpMusteriBilgileri.Controls.Add(txtSoyad);
            grpMusteriBilgileri.Controls.Add(lblDogumTarihi);
            grpMusteriBilgileri.Controls.Add(lblMusteriId);
            grpMusteriBilgileri.Controls.Add(btnGuncelle);
            grpMusteriBilgileri.Controls.Add(btnSil);
            grpMusteriBilgileri.Controls.Add(btnEkle);
            grpMusteriBilgileri.Controls.Add(txtEmail);
            grpMusteriBilgileri.Controls.Add(txtAd);
            grpMusteriBilgileri.Controls.Add(lblMusteriEmail);
            grpMusteriBilgileri.Controls.Add(lblMusteriTel);
            grpMusteriBilgileri.Controls.Add(lblMusteriSoyad);
            grpMusteriBilgileri.Controls.Add(lblMusteriAd);
            grpMusteriBilgileri.Dock = DockStyle.Left;
            grpMusteriBilgileri.Location = new Point(0, 0);
            grpMusteriBilgileri.Name = "grpMusteriBilgileri";
            grpMusteriBilgileri.Size = new Size(390, 776);
            grpMusteriBilgileri.TabIndex = 0;
            grpMusteriBilgileri.TabStop = false;
            grpMusteriBilgileri.Text = "Müşteri Bilgi";
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(179, 344);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(166, 23);
            dtpDogumTarihi.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 16;
            label1.Text = "Müşteri :";
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = SystemColors.InactiveCaption;
            txtTelefon.Location = new Point(229, 236);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 15;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.InactiveCaption;
            txtSoyad.Location = new Point(229, 182);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 14;
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.AutoSize = true;
            lblDogumTarihi.BackColor = SystemColors.InactiveCaption;
            lblDogumTarihi.Location = new Point(70, 344);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(82, 15);
            lblDogumTarihi.TabIndex = 13;
            lblDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // lblMusteriId
            // 
            lblMusteriId.AutoSize = true;
            lblMusteriId.BackColor = SystemColors.InactiveCaption;
            lblMusteriId.Location = new Point(70, 83);
            lblMusteriId.Name = "lblMusteriId";
            lblMusteriId.Size = new Size(21, 15);
            lblMusteriId.TabIndex = 12;
            lblMusteriId.Text = "ID:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(192, 192, 255);
            btnGuncelle.Location = new Point(149, 401);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(192, 192, 255);
            btnSil.Location = new Point(270, 401);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 10;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(192, 192, 255);
            btnEkle.Location = new Point(30, 401);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.InactiveCaption;
            txtEmail.Location = new Point(229, 290);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.InactiveCaption;
            txtAd.Location = new Point(229, 127);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 5;
            // 
            // lblMusteriEmail
            // 
            lblMusteriEmail.AutoSize = true;
            lblMusteriEmail.BackColor = SystemColors.InactiveCaption;
            lblMusteriEmail.Location = new Point(70, 298);
            lblMusteriEmail.Name = "lblMusteriEmail";
            lblMusteriEmail.Size = new Size(57, 15);
            lblMusteriEmail.TabIndex = 3;
            lblMusteriEmail.Text = "E-POSTA:";
            // 
            // lblMusteriTel
            // 
            lblMusteriTel.AutoSize = true;
            lblMusteriTel.BackColor = SystemColors.InactiveCaption;
            lblMusteriTel.Location = new Point(70, 244);
            lblMusteriTel.Name = "lblMusteriTel";
            lblMusteriTel.Size = new Size(29, 15);
            lblMusteriTel.TabIndex = 2;
            lblMusteriTel.Text = "TEL:";
            // 
            // lblMusteriSoyad
            // 
            lblMusteriSoyad.AutoSize = true;
            lblMusteriSoyad.BackColor = SystemColors.InactiveCaption;
            lblMusteriSoyad.Location = new Point(70, 190);
            lblMusteriSoyad.Name = "lblMusteriSoyad";
            lblMusteriSoyad.Size = new Size(47, 15);
            lblMusteriSoyad.TabIndex = 1;
            lblMusteriSoyad.Text = "SOYAD:";
            // 
            // lblMusteriAd
            // 
            lblMusteriAd.AutoSize = true;
            lblMusteriAd.BackColor = SystemColors.InactiveCaption;
            lblMusteriAd.Location = new Point(70, 135);
            lblMusteriAd.Name = "lblMusteriAd";
            lblMusteriAd.Size = new Size(26, 15);
            lblMusteriAd.TabIndex = 0;
            lblMusteriAd.Text = "AD:";
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Dock = DockStyle.Fill;
            dgvMusteriler.Location = new Point(390, 0);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.Size = new Size(1258, 776);
            dgvMusteriler.TabIndex = 1;
            // 
            // txtMusteriId
            // 
            txtMusteriId.BackColor = SystemColors.InactiveCaption;
            txtMusteriId.Location = new Point(229, 75);
            txtMusteriId.Name = "txtMusteriId";
            txtMusteriId.Size = new Size(100, 23);
            txtMusteriId.TabIndex = 18;
            // 
            // FrmMusteri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1648, 776);
            Controls.Add(dgvMusteriler);
            Controls.Add(grpMusteriBilgileri);
            Name = "FrmMusteri";
            Text = "Form1";
            grpMusteriBilgileri.ResumeLayout(false);
            grpMusteriBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMusteriBilgileri;
        private DataGridView dgvMusteriler;
        private Label lblMusteriAd;
        private Label lblMusteriSoyad;
        private Label lblMusteriEmail;
        private Label lblMusteriTel;
        private Button btnSil;
        private Button btnEkle;
        private TextBox txtEposta;
        private TextBox txtEmail;
        private TextBox txtAd;
        private Button btnGuncelle;
        private TextBox txtTelefon;
        private TextBox txtSoyad;
        private Label lblDogumTarihi;
        private Label lblMusteriId;
        private Label label1;
        private DateTimePicker dtpDogumTarihi;
        private TextBox txtMusteriId;
    }
}