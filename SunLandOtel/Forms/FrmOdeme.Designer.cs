namespace SunLandOtel.Forms
{
    partial class FrmOdeme
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
            grpOdemeBilgi = new GroupBox();
            dtpOdemeTarihi = new DateTimePicker();
            cmbOdemeYontemi = new ComboBox();
            lblOdemeTarihi = new Label();
            txtOdemeTutar = new TextBox();
            txtOdemeResId = new TextBox();
            txtOdemeMusteri = new TextBox();
            lblOdemeYontemi = new Label();
            lblOdemeTutar = new Label();
            lblOdemeMusteri = new Label();
            lblOdemeResId = new Label();
            dgvOdemeler = new DataGridView();
            btnodeGuncelle = new Button();
            btnodeSil = new Button();
            btnodeEkle = new Button();
            grpOdemeBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOdemeler).BeginInit();
            SuspendLayout();
            // 
            // grpOdemeBilgi
            // 
            grpOdemeBilgi.BackColor = Color.LightCyan;
            grpOdemeBilgi.Controls.Add(btnodeGuncelle);
            grpOdemeBilgi.Controls.Add(btnodeSil);
            grpOdemeBilgi.Controls.Add(btnodeEkle);
            grpOdemeBilgi.Controls.Add(dtpOdemeTarihi);
            grpOdemeBilgi.Controls.Add(cmbOdemeYontemi);
            grpOdemeBilgi.Controls.Add(lblOdemeTarihi);
            grpOdemeBilgi.Controls.Add(txtOdemeTutar);
            grpOdemeBilgi.Controls.Add(txtOdemeResId);
            grpOdemeBilgi.Controls.Add(txtOdemeMusteri);
            grpOdemeBilgi.Controls.Add(lblOdemeYontemi);
            grpOdemeBilgi.Controls.Add(lblOdemeTutar);
            grpOdemeBilgi.Controls.Add(lblOdemeMusteri);
            grpOdemeBilgi.Controls.Add(lblOdemeResId);
            grpOdemeBilgi.Dock = DockStyle.Left;
            grpOdemeBilgi.Location = new Point(0, 0);
            grpOdemeBilgi.Name = "grpOdemeBilgi";
            grpOdemeBilgi.Size = new Size(365, 782);
            grpOdemeBilgi.TabIndex = 0;
            grpOdemeBilgi.TabStop = false;
            grpOdemeBilgi.Text = "Ödeme İşlemleri";
            // 
            // dtpOdemeTarihi
            // 
            dtpOdemeTarihi.Location = new Point(159, 367);
            dtpOdemeTarihi.Name = "dtpOdemeTarihi";
            dtpOdemeTarihi.Size = new Size(200, 23);
            dtpOdemeTarihi.TabIndex = 37;
            // 
            // cmbOdemeYontemi
            // 
            cmbOdemeYontemi.FormattingEnabled = true;
            cmbOdemeYontemi.Location = new Point(192, 298);
            cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            cmbOdemeYontemi.Size = new Size(121, 23);
            cmbOdemeYontemi.TabIndex = 36;
            // 
            // lblOdemeTarihi
            // 
            lblOdemeTarihi.AutoSize = true;
            lblOdemeTarihi.BackColor = SystemColors.InactiveCaption;
            lblOdemeTarihi.Location = new Point(27, 367);
            lblOdemeTarihi.Name = "lblOdemeTarihi";
            lblOdemeTarihi.Size = new Size(81, 15);
            lblOdemeTarihi.TabIndex = 34;
            lblOdemeTarihi.Text = "Ödeme Tarihi:";
            // 
            // txtOdemeTutar
            // 
            txtOdemeTutar.BackColor = SystemColors.InactiveCaption;
            txtOdemeTutar.Location = new Point(192, 234);
            txtOdemeTutar.Name = "txtOdemeTutar";
            txtOdemeTutar.Size = new Size(100, 23);
            txtOdemeTutar.TabIndex = 32;
            // 
            // txtOdemeResId
            // 
            txtOdemeResId.BackColor = SystemColors.InactiveCaption;
            txtOdemeResId.Location = new Point(192, 98);
            txtOdemeResId.Name = "txtOdemeResId";
            txtOdemeResId.Size = new Size(100, 23);
            txtOdemeResId.TabIndex = 31;
            // 
            // txtOdemeMusteri
            // 
            txtOdemeMusteri.BackColor = SystemColors.InactiveCaption;
            txtOdemeMusteri.Location = new Point(192, 161);
            txtOdemeMusteri.Name = "txtOdemeMusteri";
            txtOdemeMusteri.Size = new Size(100, 23);
            txtOdemeMusteri.TabIndex = 30;
            // 
            // lblOdemeYontemi
            // 
            lblOdemeYontemi.AutoSize = true;
            lblOdemeYontemi.BackColor = SystemColors.InactiveCaption;
            lblOdemeYontemi.Location = new Point(32, 306);
            lblOdemeYontemi.Name = "lblOdemeYontemi";
            lblOdemeYontemi.Size = new Size(96, 15);
            lblOdemeYontemi.TabIndex = 29;
            lblOdemeYontemi.Text = "Ödeme Yöntemi:";
            // 
            // lblOdemeTutar
            // 
            lblOdemeTutar.AutoSize = true;
            lblOdemeTutar.BackColor = SystemColors.InactiveCaption;
            lblOdemeTutar.Location = new Point(27, 234);
            lblOdemeTutar.Name = "lblOdemeTutar";
            lblOdemeTutar.Size = new Size(94, 15);
            lblOdemeTutar.TabIndex = 28;
            lblOdemeTutar.Text = "Ödenecek Tutar:";
            // 
            // lblOdemeMusteri
            // 
            lblOdemeMusteri.AutoSize = true;
            lblOdemeMusteri.BackColor = SystemColors.InactiveCaption;
            lblOdemeMusteri.Location = new Point(25, 161);
            lblOdemeMusteri.Name = "lblOdemeMusteri";
            lblOdemeMusteri.Size = new Size(103, 15);
            lblOdemeMusteri.TabIndex = 27;
            lblOdemeMusteri.Text = "Müşteri Ad Soyad:";
            // 
            // lblOdemeResId
            // 
            lblOdemeResId.AutoSize = true;
            lblOdemeResId.BackColor = SystemColors.InactiveCaption;
            lblOdemeResId.Location = new Point(25, 106);
            lblOdemeResId.Name = "lblOdemeResId";
            lblOdemeResId.Size = new Size(89, 15);
            lblOdemeResId.TabIndex = 26;
            lblOdemeResId.Text = "Rezervasyon ID:";
            // 
            // dgvOdemeler
            // 
            dgvOdemeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOdemeler.Dock = DockStyle.Fill;
            dgvOdemeler.Location = new Point(365, 0);
            dgvOdemeler.Name = "dgvOdemeler";
            dgvOdemeler.Size = new Size(1280, 782);
            dgvOdemeler.TabIndex = 1;
            // 
            // btnodeGuncelle
            // 
            btnodeGuncelle.BackColor = Color.FromArgb(192, 192, 255);
            btnodeGuncelle.Location = new Point(140, 443);
            btnodeGuncelle.Name = "btnodeGuncelle";
            btnodeGuncelle.Size = new Size(75, 23);
            btnodeGuncelle.TabIndex = 40;
            btnodeGuncelle.Text = "GÜNCELLE";
            btnodeGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnodeSil
            // 
            btnodeSil.BackColor = Color.FromArgb(192, 192, 255);
            btnodeSil.Location = new Point(262, 443);
            btnodeSil.Name = "btnodeSil";
            btnodeSil.Size = new Size(75, 23);
            btnodeSil.TabIndex = 39;
            btnodeSil.Text = "SİL";
            btnodeSil.UseVisualStyleBackColor = false;
            // 
            // btnodeEkle
            // 
            btnodeEkle.BackColor = Color.FromArgb(192, 192, 255);
            btnodeEkle.Location = new Point(27, 443);
            btnodeEkle.Name = "btnodeEkle";
            btnodeEkle.Size = new Size(75, 23);
            btnodeEkle.TabIndex = 38;
            btnodeEkle.Text = "EKLE";
            btnodeEkle.UseVisualStyleBackColor = false;
            // 
            // FrmOdeme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1645, 782);
            Controls.Add(dgvOdemeler);
            Controls.Add(grpOdemeBilgi);
            Name = "FrmOdeme";
            Text = "Form1";
            grpOdemeBilgi.ResumeLayout(false);
            grpOdemeBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOdemeler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOdemeBilgi;
        private DataGridView dgvOdemeler;
        private Label lblOdemeTarihi;
        private TextBox txtOdemeTutar;
        private TextBox txtOdemeResId;
        private TextBox txtOdemeMusteri;
        private Label lblOdemeYontemi;
        private Label lblOdemeTutar;
        private Label lblOdemeMusteri;
        private Label lblOdemeResId;
        private DateTimePicker dtpOdemeTarihi;
        private ComboBox cmbOdemeYontemi;
        private Button btnodeGuncelle;
        private Button btnodeSil;
        private Button btnodeEkle;
    }
}