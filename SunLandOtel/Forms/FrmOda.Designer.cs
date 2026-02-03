namespace SunLandOtel.Forms
{
    partial class FrmOda
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
            grpOdaBilgi = new GroupBox();
            dgvOdalar = new DataGridView();
            lblOdaNo = new Label();
            lblOdaKat = new Label();
            lblOdaTipi = new Label();
            lblOdaFiyat = new Label();
            label5 = new Label();
            lblOdaDurum = new Label();
            txtOdaNo = new TextBox();
            txtFiyat = new TextBox();
            txtOdaTipi = new TextBox();
            txtKat = new TextBox();
            txtDurum = new TextBox();
            btnOdaEkle = new Button();
            btnOdaSil = new Button();
            btnOdaGuncelle = new Button();
            grpOdaBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOdalar).BeginInit();
            SuspendLayout();
            // 
            // grpOdaBilgi
            // 
            grpOdaBilgi.Controls.Add(btnOdaGuncelle);
            grpOdaBilgi.Controls.Add(btnOdaSil);
            grpOdaBilgi.Controls.Add(btnOdaEkle);
            grpOdaBilgi.Controls.Add(txtDurum);
            grpOdaBilgi.Controls.Add(txtKat);
            grpOdaBilgi.Controls.Add(txtOdaTipi);
            grpOdaBilgi.Controls.Add(txtFiyat);
            grpOdaBilgi.Controls.Add(txtOdaNo);
            grpOdaBilgi.Controls.Add(lblOdaDurum);
            grpOdaBilgi.Controls.Add(label5);
            grpOdaBilgi.Controls.Add(lblOdaFiyat);
            grpOdaBilgi.Controls.Add(lblOdaTipi);
            grpOdaBilgi.Controls.Add(lblOdaKat);
            grpOdaBilgi.Controls.Add(lblOdaNo);
            grpOdaBilgi.Dock = DockStyle.Left;
            grpOdaBilgi.Location = new Point(0, 0);
            grpOdaBilgi.Name = "grpOdaBilgi";
            grpOdaBilgi.Size = new Size(291, 788);
            grpOdaBilgi.TabIndex = 0;
            grpOdaBilgi.TabStop = false;
            grpOdaBilgi.Text = "Oda İşlemleri";
            // 
            // dgvOdalar
            // 
            dgvOdalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOdalar.Dock = DockStyle.Fill;
            dgvOdalar.Location = new Point(291, 0);
            dgvOdalar.Name = "dgvOdalar";
            dgvOdalar.Size = new Size(1418, 788);
            dgvOdalar.TabIndex = 1;
            // 
            // lblOdaNo
            // 
            lblOdaNo.AutoSize = true;
            lblOdaNo.BackColor = SystemColors.InactiveCaption;
            lblOdaNo.Location = new Point(61, 44);
            lblOdaNo.Name = "lblOdaNo";
            lblOdaNo.Size = new Size(51, 15);
            lblOdaNo.TabIndex = 0;
            lblOdaNo.Text = "Oda No:";
            // 
            // lblOdaKat
            // 
            lblOdaKat.AutoSize = true;
            lblOdaKat.BackColor = SystemColors.InactiveCaption;
            lblOdaKat.Location = new Point(61, 84);
            lblOdaKat.Name = "lblOdaKat";
            lblOdaKat.Size = new Size(27, 15);
            lblOdaKat.TabIndex = 1;
            lblOdaKat.Text = "Kat:";
            // 
            // lblOdaTipi
            // 
            lblOdaTipi.AutoSize = true;
            lblOdaTipi.BackColor = SystemColors.InactiveCaption;
            lblOdaTipi.Location = new Point(61, 123);
            lblOdaTipi.Name = "lblOdaTipi";
            lblOdaTipi.Size = new Size(27, 15);
            lblOdaTipi.TabIndex = 2;
            lblOdaTipi.Text = "Tip:";
            // 
            // lblOdaFiyat
            // 
            lblOdaFiyat.AutoSize = true;
            lblOdaFiyat.BackColor = SystemColors.InactiveCaption;
            lblOdaFiyat.Location = new Point(61, 166);
            lblOdaFiyat.Name = "lblOdaFiyat";
            lblOdaFiyat.Size = new Size(35, 15);
            lblOdaFiyat.TabIndex = 3;
            lblOdaFiyat.Text = "Fiyat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 242);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // lblOdaDurum
            // 
            lblOdaDurum.AutoSize = true;
            lblOdaDurum.BackColor = SystemColors.InactiveCaption;
            lblOdaDurum.Location = new Point(61, 206);
            lblOdaDurum.Name = "lblOdaDurum";
            lblOdaDurum.Size = new Size(47, 15);
            lblOdaDurum.TabIndex = 5;
            lblOdaDurum.Text = "Durum:";
            // 
            // txtOdaNo
            // 
            txtOdaNo.BackColor = SystemColors.InactiveCaption;
            txtOdaNo.Location = new Point(153, 41);
            txtOdaNo.Name = "txtOdaNo";
            txtOdaNo.Size = new Size(100, 23);
            txtOdaNo.TabIndex = 6;
            // 
            // txtFiyat
            // 
            txtFiyat.BackColor = SystemColors.InactiveCaption;
            txtFiyat.Location = new Point(153, 158);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(100, 23);
            txtFiyat.TabIndex = 7;
            // 
            // txtOdaTipi
            // 
            txtOdaTipi.BackColor = SystemColors.InactiveCaption;
            txtOdaTipi.Location = new Point(153, 120);
            txtOdaTipi.Name = "txtOdaTipi";
            txtOdaTipi.Size = new Size(100, 23);
            txtOdaTipi.TabIndex = 8;
            // 
            // txtKat
            // 
            txtKat.BackColor = SystemColors.InactiveCaption;
            txtKat.Location = new Point(153, 81);
            txtKat.Name = "txtKat";
            txtKat.Size = new Size(100, 23);
            txtKat.TabIndex = 9;
            // 
            // txtDurum
            // 
            txtDurum.BackColor = SystemColors.InactiveCaption;
            txtDurum.Location = new Point(153, 198);
            txtDurum.Name = "txtDurum";
            txtDurum.Size = new Size(100, 23);
            txtDurum.TabIndex = 10;
            // 
            // btnOdaEkle
            // 
            btnOdaEkle.BackColor = Color.FromArgb(192, 192, 255);
            btnOdaEkle.Location = new Point(13, 260);
            btnOdaEkle.Name = "btnOdaEkle";
            btnOdaEkle.Size = new Size(75, 23);
            btnOdaEkle.TabIndex = 15;
            btnOdaEkle.Text = "EKLE";
            btnOdaEkle.UseVisualStyleBackColor = false;
            // 
            // btnOdaSil
            // 
            btnOdaSil.BackColor = Color.FromArgb(192, 192, 255);
            btnOdaSil.Location = new Point(104, 260);
            btnOdaSil.Name = "btnOdaSil";
            btnOdaSil.Size = new Size(75, 23);
            btnOdaSil.TabIndex = 16;
            btnOdaSil.Text = "SİL";
            btnOdaSil.UseVisualStyleBackColor = false;
            // 
            // btnOdaGuncelle
            // 
            btnOdaGuncelle.BackColor = Color.FromArgb(192, 192, 255);
            btnOdaGuncelle.Location = new Point(195, 260);
            btnOdaGuncelle.Name = "btnOdaGuncelle";
            btnOdaGuncelle.Size = new Size(75, 23);
            btnOdaGuncelle.TabIndex = 17;
            btnOdaGuncelle.Text = "GÜNCELLE";
            btnOdaGuncelle.UseVisualStyleBackColor = false;
            // 
            // FrmOda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1709, 788);
            Controls.Add(dgvOdalar);
            Controls.Add(grpOdaBilgi);
            Name = "FrmOda";
            Text = "Form1";
            grpOdaBilgi.ResumeLayout(false);
            grpOdaBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOdalar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOdaBilgi;
        private DataGridView dgvOdalar;
        private TextBox txtOdaNo;
        private Label lblOdaDurum;
        private Label label5;
        private Label lblOdaFiyat;
        private Label lblOdaTipi;
        private Label lblOdaKat;
        private Label lblOdaNo;
        private TextBox txtDurum;
        private TextBox txtKat;
        private TextBox txtOdaTipi;
        private TextBox txtFiyat;
        private Button btnOdaGuncelle;
        private Button btnOdaSil;
        private Button btnOdaEkle;
    }
}