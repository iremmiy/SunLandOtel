namespace SunLandOtel.Forms
{
    partial class FrmAnaMenu
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
            label1 = new Label();
            btnMusteriMenu = new Button();
            btnOdaMenu = new Button();
            lblOdemeMenu = new Button();
            btnRezervasyonMenu = new Button();
            btnCikis = new Button();
            btnPersonelMenu = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(66, 40);
            label1.Name = "label1";
            label1.Size = new Size(448, 40);
            label1.TabIndex = 0;
            label1.Text = "SUNLAND OTEL OTOMASYONU";
            // 
            // btnMusteriMenu
            // 
            btnMusteriMenu.Location = new Point(91, 183);
            btnMusteriMenu.Name = "btnMusteriMenu";
            btnMusteriMenu.Size = new Size(166, 69);
            btnMusteriMenu.TabIndex = 1;
            btnMusteriMenu.Text = "MÜŞTERİ İŞLEMLERİ";
            btnMusteriMenu.UseVisualStyleBackColor = true;
            btnMusteriMenu.Click += btnMusteriMenu_Click;
            // 
            // btnOdaMenu
            // 
            btnOdaMenu.Location = new Point(310, 183);
            btnOdaMenu.Name = "btnOdaMenu";
            btnOdaMenu.Size = new Size(166, 69);
            btnOdaMenu.TabIndex = 2;
            btnOdaMenu.Text = "ODA YÖNETİMİ";
            btnOdaMenu.UseVisualStyleBackColor = true;
            btnOdaMenu.Click += btnOdaMenu_Click;
            // 
            // lblOdemeMenu
            // 
            lblOdemeMenu.Location = new Point(91, 429);
            lblOdemeMenu.Name = "lblOdemeMenu";
            lblOdemeMenu.Size = new Size(166, 69);
            lblOdemeMenu.TabIndex = 3;
            lblOdemeMenu.Text = "ÖDEMELER";
            lblOdemeMenu.UseVisualStyleBackColor = true;
            lblOdemeMenu.Click += btnOdemeMenu_Click;
            // 
            // btnRezervasyonMenu
            // 
            btnRezervasyonMenu.Location = new Point(310, 304);
            btnRezervasyonMenu.Name = "btnRezervasyonMenu";
            btnRezervasyonMenu.Size = new Size(166, 69);
            btnRezervasyonMenu.TabIndex = 4;
            btnRezervasyonMenu.Text = "REZERVASYON YAP";
            btnRezervasyonMenu.UseVisualStyleBackColor = true;
            btnRezervasyonMenu.Click += btnRezervasyonMenu_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Brown;
            btnCikis.Location = new Point(310, 429);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(166, 69);
            btnCikis.TabIndex = 5;
            btnCikis.Text = "ÇIKIŞ";
            btnCikis.UseVisualStyleBackColor = false;
            // 
            // btnPersonelMenu
            // 
            btnPersonelMenu.Location = new Point(91, 304);
            btnPersonelMenu.Name = "btnPersonelMenu";
            btnPersonelMenu.Size = new Size(166, 69);
            btnPersonelMenu.TabIndex = 6;
            btnPersonelMenu.Text = "PERSONEL YÖNETİMİ";
            btnPersonelMenu.UseVisualStyleBackColor = true;
            btnPersonelMenu.Click += btnPersonelMenu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 553);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 7;
            label2.Text = "İNŞALLAH 100 VERİRSİNİZ!";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 111);
            label3.Name = "label3";
            label3.Size = new Size(342, 15);
            label3.TabIndex = 8;
            label3.Text = "KUŞLAR NOLUR BENİ DE ALIN DEDİĞİNİZDE GELECEĞİNİZ YER...";
            // 
            // FrmAnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1568, 750);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnPersonelMenu);
            Controls.Add(btnCikis);
            Controls.Add(btnRezervasyonMenu);
            Controls.Add(lblOdemeMenu);
            Controls.Add(btnOdaMenu);
            Controls.Add(btnMusteriMenu);
            Controls.Add(label1);
            ForeColor = Color.RosyBrown;
            Name = "FrmAnaMenu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMusteriMenu;
        private Button btnOdaMenu;
        private Button lblOdemeMenu;
        private Button btnRezervasyonMenu;
        private Button btnCikis;
        private Button btnPersonelMenu;
        private Label label2;
        private Label label3;
    }
}