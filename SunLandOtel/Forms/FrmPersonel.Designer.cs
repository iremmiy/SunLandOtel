namespace SunLandOtel.Forms
{
    partial class FrmPersonel
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
            grpPersonel = new GroupBox();
            txtPersId = new TextBox();
            lblPersid = new Label();
            txtPersTelefon = new TextBox();
            lblPersTel = new Label();
            prsad = new Label();
            btnPersGuncelle = new Button();
            btnPersSil = new Button();
            btnPersEkle = new Button();
            txtPersMaas = new TextBox();
            txtPersGorev = new TextBox();
            txtPersAd = new TextBox();
            txtPersSoyad = new TextBox();
            lblPersMaas = new Label();
            lblPersGorev = new Label();
            lblPersSoyad = new Label();
            lblPersAd = new Label();
            dgvPersonel = new DataGridView();
            grpPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
            SuspendLayout();
            // 
            // grpPersonel
            // 
            grpPersonel.BackColor = Color.LightCyan;
            grpPersonel.Controls.Add(txtPersId);
            grpPersonel.Controls.Add(lblPersid);
            grpPersonel.Controls.Add(txtPersTelefon);
            grpPersonel.Controls.Add(lblPersTel);
            grpPersonel.Controls.Add(prsad);
            grpPersonel.Controls.Add(btnPersGuncelle);
            grpPersonel.Controls.Add(btnPersSil);
            grpPersonel.Controls.Add(btnPersEkle);
            grpPersonel.Controls.Add(txtPersMaas);
            grpPersonel.Controls.Add(txtPersGorev);
            grpPersonel.Controls.Add(txtPersAd);
            grpPersonel.Controls.Add(txtPersSoyad);
            grpPersonel.Controls.Add(lblPersMaas);
            grpPersonel.Controls.Add(lblPersGorev);
            grpPersonel.Controls.Add(lblPersSoyad);
            grpPersonel.Controls.Add(lblPersAd);
            grpPersonel.Dock = DockStyle.Left;
            grpPersonel.Location = new Point(0, 0);
            grpPersonel.Name = "grpPersonel";
            grpPersonel.Size = new Size(344, 802);
            grpPersonel.TabIndex = 0;
            grpPersonel.TabStop = false;
            grpPersonel.Text = "Personel İşlemleri";
            grpPersonel.Enter += grpPersonel_Enter;
            // 
            // txtPersId
            // 
            txtPersId.BackColor = SystemColors.InactiveCaption;
            txtPersId.Location = new Point(216, 95);
            txtPersId.Name = "txtPersId";
            txtPersId.Size = new Size(100, 23);
            txtPersId.TabIndex = 27;
            // 
            // lblPersid
            // 
            lblPersid.AutoSize = true;
            lblPersid.BackColor = SystemColors.InactiveCaption;
            lblPersid.Location = new Point(63, 103);
            lblPersid.Name = "lblPersid";
            lblPersid.Size = new Size(21, 15);
            lblPersid.TabIndex = 26;
            lblPersid.Text = "iD:";
            // 
            // txtPersTelefon
            // 
            txtPersTelefon.BackColor = SystemColors.InactiveCaption;
            txtPersTelefon.Location = new Point(216, 372);
            txtPersTelefon.Name = "txtPersTelefon";
            txtPersTelefon.Size = new Size(100, 23);
            txtPersTelefon.TabIndex = 25;
            // 
            // lblPersTel
            // 
            lblPersTel.AutoSize = true;
            lblPersTel.BackColor = SystemColors.InactiveCaption;
            lblPersTel.Location = new Point(57, 380);
            lblPersTel.Name = "lblPersTel";
            lblPersTel.Size = new Size(49, 15);
            lblPersTel.TabIndex = 24;
            lblPersTel.Text = "Telefon:";
            // 
            // prsad
            // 
            prsad.AutoSize = true;
            prsad.Location = new Point(17, 50);
            prsad.Name = "prsad";
            prsad.Size = new Size(55, 15);
            prsad.TabIndex = 23;
            prsad.Text = "Personel:";
            // 
            // btnPersGuncelle
            // 
            btnPersGuncelle.BackColor = Color.FromArgb(192, 192, 255);
            btnPersGuncelle.Location = new Point(120, 423);
            btnPersGuncelle.Name = "btnPersGuncelle";
            btnPersGuncelle.Size = new Size(75, 23);
            btnPersGuncelle.TabIndex = 22;
            btnPersGuncelle.Text = "GÜNCELLE";
            btnPersGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnPersSil
            // 
            btnPersSil.BackColor = Color.FromArgb(192, 192, 255);
            btnPersSil.Location = new Point(241, 423);
            btnPersSil.Name = "btnPersSil";
            btnPersSil.Size = new Size(75, 23);
            btnPersSil.TabIndex = 21;
            btnPersSil.Text = "SİL";
            btnPersSil.UseVisualStyleBackColor = false;
            // 
            // btnPersEkle
            // 
            btnPersEkle.BackColor = Color.FromArgb(192, 192, 255);
            btnPersEkle.Location = new Point(6, 423);
            btnPersEkle.Name = "btnPersEkle";
            btnPersEkle.Size = new Size(75, 23);
            btnPersEkle.TabIndex = 20;
            btnPersEkle.Text = "EKLE";
            btnPersEkle.UseVisualStyleBackColor = false;
            // 
            // txtPersMaas
            // 
            txtPersMaas.BackColor = SystemColors.InactiveCaption;
            txtPersMaas.Location = new Point(216, 330);
            txtPersMaas.Name = "txtPersMaas";
            txtPersMaas.Size = new Size(100, 23);
            txtPersMaas.TabIndex = 19;
            // 
            // txtPersGorev
            // 
            txtPersGorev.BackColor = SystemColors.InactiveCaption;
            txtPersGorev.Location = new Point(216, 279);
            txtPersGorev.Name = "txtPersGorev";
            txtPersGorev.Size = new Size(100, 23);
            txtPersGorev.TabIndex = 18;
            // 
            // txtPersAd
            // 
            txtPersAd.BackColor = SystemColors.InactiveCaption;
            txtPersAd.Location = new Point(216, 149);
            txtPersAd.Name = "txtPersAd";
            txtPersAd.Size = new Size(100, 23);
            txtPersAd.TabIndex = 17;
            // 
            // txtPersSoyad
            // 
            txtPersSoyad.BackColor = SystemColors.InactiveCaption;
            txtPersSoyad.Location = new Point(216, 213);
            txtPersSoyad.Name = "txtPersSoyad";
            txtPersSoyad.Size = new Size(100, 23);
            txtPersSoyad.TabIndex = 16;
            // 
            // lblPersMaas
            // 
            lblPersMaas.AutoSize = true;
            lblPersMaas.BackColor = SystemColors.InactiveCaption;
            lblPersMaas.Location = new Point(57, 333);
            lblPersMaas.Name = "lblPersMaas";
            lblPersMaas.Size = new Size(43, 15);
            lblPersMaas.TabIndex = 15;
            lblPersMaas.Text = "MAAŞ:";
            // 
            // lblPersGorev
            // 
            lblPersGorev.AutoSize = true;
            lblPersGorev.BackColor = SystemColors.InactiveCaption;
            lblPersGorev.Location = new Point(63, 287);
            lblPersGorev.Name = "lblPersGorev";
            lblPersGorev.Size = new Size(47, 15);
            lblPersGorev.TabIndex = 14;
            lblPersGorev.Text = "GÖREV:";
            // 
            // lblPersSoyad
            // 
            lblPersSoyad.AutoSize = true;
            lblPersSoyad.BackColor = SystemColors.InactiveCaption;
            lblPersSoyad.Location = new Point(63, 213);
            lblPersSoyad.Name = "lblPersSoyad";
            lblPersSoyad.Size = new Size(47, 15);
            lblPersSoyad.TabIndex = 13;
            lblPersSoyad.Text = "SOYAD:";
            // 
            // lblPersAd
            // 
            lblPersAd.AutoSize = true;
            lblPersAd.BackColor = SystemColors.InactiveCaption;
            lblPersAd.Location = new Point(63, 157);
            lblPersAd.Name = "lblPersAd";
            lblPersAd.Size = new Size(26, 15);
            lblPersAd.TabIndex = 12;
            lblPersAd.Text = "AD:";
            // 
            // dgvPersonel
            // 
            dgvPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonel.Dock = DockStyle.Fill;
            dgvPersonel.Location = new Point(344, 0);
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.Size = new Size(1293, 802);
            dgvPersonel.TabIndex = 1;
            // 
            // FrmPersonel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1637, 802);
            Controls.Add(dgvPersonel);
            Controls.Add(grpPersonel);
            Name = "FrmPersonel";
            Text = "Form1";
            grpPersonel.ResumeLayout(false);
            grpPersonel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPersonel;
        private Button btnPersGuncelle;
        private Button btnPersSil;
        private Button btnPersEkle;
        private TextBox txtPersMaas;
        private TextBox txtPersGorev;
        private TextBox txtPersAd;
        private TextBox txtPersSoyad;
        private Label lblPersMaas;
        private Label lblPersGorev;
        private Label lblPersSoyad;
        private Label lblPersAd;
        private Label prsad;
        private Label lblPersTel;
        private TextBox txtPersTelefon;
        private TextBox txtPersId;
        private Label lblPersid;
        private DataGridView dgvPersonel;
    }
}