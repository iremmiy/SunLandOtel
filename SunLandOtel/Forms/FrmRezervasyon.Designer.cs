namespace SunLandOtel.Forms
{
    partial class FrmRezervasyon
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
            grpRezervasyon = new GroupBox();
            btnResGuncelle = new Button();
            btnResSil = new Button();
            btnResEkle = new Button();
            txtToplamUcret = new TextBox();
            lblToplamUcret = new Label();
            dtpCikisTarihi = new DateTimePicker();
            dtpGirisTarihi = new DateTimePicker();
            lblCikisTarihi = new Label();
            txtResPersonelId = new TextBox();
            txtResMusteriId = new TextBox();
            txtResOdaId = new TextBox();
            lblGirisTarihi = new Label();
            lblResPersonelId = new Label();
            lblResOdaId = new Label();
            lblResMusteriId = new Label();
            dataGridView1 = new DataGridView();
            lblrezid = new Label();
            txtresrezid = new TextBox();
            grpRezervasyon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grpRezervasyon
            // 
            grpRezervasyon.BackColor = Color.LightCyan;
            grpRezervasyon.Controls.Add(txtresrezid);
            grpRezervasyon.Controls.Add(lblrezid);
            grpRezervasyon.Controls.Add(btnResGuncelle);
            grpRezervasyon.Controls.Add(btnResSil);
            grpRezervasyon.Controls.Add(btnResEkle);
            grpRezervasyon.Controls.Add(txtToplamUcret);
            grpRezervasyon.Controls.Add(lblToplamUcret);
            grpRezervasyon.Controls.Add(dtpCikisTarihi);
            grpRezervasyon.Controls.Add(dtpGirisTarihi);
            grpRezervasyon.Controls.Add(lblCikisTarihi);
            grpRezervasyon.Controls.Add(txtResPersonelId);
            grpRezervasyon.Controls.Add(txtResMusteriId);
            grpRezervasyon.Controls.Add(txtResOdaId);
            grpRezervasyon.Controls.Add(lblGirisTarihi);
            grpRezervasyon.Controls.Add(lblResPersonelId);
            grpRezervasyon.Controls.Add(lblResOdaId);
            grpRezervasyon.Controls.Add(lblResMusteriId);
            grpRezervasyon.Dock = DockStyle.Left;
            grpRezervasyon.Location = new Point(0, 0);
            grpRezervasyon.Name = "grpRezervasyon";
            grpRezervasyon.Size = new Size(360, 796);
            grpRezervasyon.TabIndex = 0;
            grpRezervasyon.TabStop = false;
            grpRezervasyon.Text = "Rezervasyon İşlemleri";
          //  grpRezervasyon.Enter += grpRezervasyon_Enter;
            // 
            // btnResGuncelle
            // 
            btnResGuncelle.BackColor = Color.FromArgb(192, 192, 255);
            btnResGuncelle.Location = new Point(19, 448);
            btnResGuncelle.Name = "btnResGuncelle";
            btnResGuncelle.Size = new Size(165, 23);
            btnResGuncelle.TabIndex = 42;
            btnResGuncelle.Text = "GÜNCELLE";
            btnResGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnResSil
            // 
            btnResSil.BackColor = Color.FromArgb(192, 192, 255);
            btnResSil.Location = new Point(19, 477);
            btnResSil.Name = "btnResSil";
            btnResSil.Size = new Size(165, 23);
            btnResSil.TabIndex = 41;
            btnResSil.Text = "İPTAL ET / SİL";
            btnResSil.UseVisualStyleBackColor = false;
            // 
            // btnResEkle
            // 
            btnResEkle.BackColor = Color.FromArgb(192, 192, 255);
            btnResEkle.Location = new Point(19, 419);
            btnResEkle.Name = "btnResEkle";
            btnResEkle.Size = new Size(165, 23);
            btnResEkle.TabIndex = 40;
            btnResEkle.Text = "REZERVASYON YAP";
            btnResEkle.UseVisualStyleBackColor = false;
            // 
            // txtToplamUcret
            // 
            txtToplamUcret.BackColor = SystemColors.InactiveCaption;
            txtToplamUcret.Location = new Point(207, 369);
            txtToplamUcret.Name = "txtToplamUcret";
            txtToplamUcret.Size = new Size(100, 23);
            txtToplamUcret.TabIndex = 39;
            // 
            // lblToplamUcret
            // 
            lblToplamUcret.AutoSize = true;
            lblToplamUcret.BackColor = SystemColors.InactiveCaption;
            lblToplamUcret.Location = new Point(19, 377);
            lblToplamUcret.Name = "lblToplamUcret";
            lblToplamUcret.Size = new Size(81, 15);
            lblToplamUcret.TabIndex = 38;
            lblToplamUcret.Text = "Toplam Ücret:";
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(154, 254);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(200, 23);
            dtpCikisTarihi.TabIndex = 37;
            // 
            // dtpGirisTarihi
            // 
            dtpGirisTarihi.Location = new Point(154, 201);
            dtpGirisTarihi.Name = "dtpGirisTarihi";
            dtpGirisTarihi.Size = new Size(200, 23);
            dtpGirisTarihi.TabIndex = 36;
            // 
            // lblCikisTarihi
            // 
            lblCikisTarihi.AutoSize = true;
            lblCikisTarihi.BackColor = SystemColors.InactiveCaption;
            lblCikisTarihi.Location = new Point(19, 262);
            lblCikisTarihi.Name = "lblCikisTarihi";
            lblCikisTarihi.Size = new Size(67, 15);
            lblCikisTarihi.TabIndex = 34;
            lblCikisTarihi.Text = "Çıkış Tarihi:";
            // 
            // txtResPersonelId
            // 
            txtResPersonelId.BackColor = SystemColors.InactiveCaption;
            txtResPersonelId.Location = new Point(207, 145);
            txtResPersonelId.Name = "txtResPersonelId";
            txtResPersonelId.Size = new Size(100, 23);
            txtResPersonelId.TabIndex = 32;
            // 
            // txtResMusteriId
            // 
            txtResMusteriId.BackColor = SystemColors.InactiveCaption;
            txtResMusteriId.Location = new Point(207, 51);
            txtResMusteriId.Name = "txtResMusteriId";
            txtResMusteriId.Size = new Size(100, 23);
            txtResMusteriId.TabIndex = 31;
            // 
            // txtResOdaId
            // 
            txtResOdaId.BackColor = SystemColors.InactiveCaption;
            txtResOdaId.Location = new Point(207, 94);
            txtResOdaId.Name = "txtResOdaId";
            txtResOdaId.Size = new Size(100, 23);
            txtResOdaId.TabIndex = 30;
            // 
            // lblGirisTarihi
            // 
            lblGirisTarihi.AutoSize = true;
            lblGirisTarihi.BackColor = SystemColors.InactiveCaption;
            lblGirisTarihi.Location = new Point(19, 207);
            lblGirisTarihi.Name = "lblGirisTarihi";
            lblGirisTarihi.Size = new Size(65, 15);
            lblGirisTarihi.TabIndex = 29;
            lblGirisTarihi.Text = "Giriş Tarihi:";
            // 
            // lblResPersonelId
            // 
            lblResPersonelId.AutoSize = true;
            lblResPersonelId.BackColor = SystemColors.InactiveCaption;
            lblResPersonelId.Location = new Point(17, 153);
            lblResPersonelId.Name = "lblResPersonelId";
            lblResPersonelId.Size = new Size(69, 15);
            lblResPersonelId.TabIndex = 28;
            lblResPersonelId.Text = "Personel ID:";
            // 
            // lblResOdaId
            // 
            lblResOdaId.AutoSize = true;
            lblResOdaId.BackColor = SystemColors.InactiveCaption;
            lblResOdaId.Location = new Point(19, 102);
            lblResOdaId.Name = "lblResOdaId";
            lblResOdaId.Size = new Size(46, 15);
            lblResOdaId.TabIndex = 27;
            lblResOdaId.Text = "Oda ID:";
            // 
            // lblResMusteriId
            // 
            lblResMusteriId.AutoSize = true;
            lblResMusteriId.BackColor = SystemColors.InactiveCaption;
            lblResMusteriId.Location = new Point(19, 54);
            lblResMusteriId.Name = "lblResMusteriId";
            lblResMusteriId.Size = new Size(64, 15);
            lblResMusteriId.TabIndex = 26;
            lblResMusteriId.Text = "Müşteri ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(360, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1301, 796);
            dataGridView1.TabIndex = 1;
            // 
            // lblrezid
            // 
            lblrezid.AutoSize = true;
            lblrezid.BackColor = SystemColors.InactiveCaption;
            lblrezid.Location = new Point(19, 322);
            lblrezid.Name = "lblrezid";
            lblrezid.Size = new Size(89, 15);
            lblrezid.TabIndex = 43;
            lblrezid.Text = "Rezervasyon İD:";
            // 
            // txtresrezid
            // 
            txtresrezid.BackColor = SystemColors.InactiveCaption;
            txtresrezid.Location = new Point(207, 314);
            txtresrezid.Name = "txtresrezid";
            txtresrezid.Size = new Size(100, 23);
            txtresrezid.TabIndex = 44;
            // 
            // FrmRezervasyon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1661, 796);
            Controls.Add(dataGridView1);
            Controls.Add(grpRezervasyon);
            Name = "FrmRezervasyon";
            Text = "Form1";
            grpRezervasyon.ResumeLayout(false);
            grpRezervasyon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpRezervasyon;
        private DataGridView dataGridView1;
        private TextBox txttel;
        private Label lblCikisTarihi;
        private TextBox txtmaas;
        private TextBox txtResPersonelId;
        private TextBox txtResMusteriId;
        private TextBox txtResOdaId;
        private Label lblGirisTarihi;
        private Label lblResPersonelId;
        private Label lblResOdaId;
        private Label lblResMusteriId;
        private TextBox txtToplamUcret;
        private Label lblToplamUcret;
        private DateTimePicker dtpCikisTarihi;
        private DateTimePicker dtpGirisTarihi;
        private Button btnresGuncelle;
        private Button btnresSil;
        private Button btnResEkle;
        private Button btnResGuncelle;
        private Button btnResSil;
        private TextBox txtresrezid;
        private Label lblrezid;
    }
}