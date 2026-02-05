namespace proje_odev
{
    partial class LeaveForm
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
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.lstIzinler = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblGun = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblListe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(150, 43);
            this.cmbPersonel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(249, 31);
            this.cmbPersonel.TabIndex = 0;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(150, 101);
            this.dtpBaslangic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(249, 30);
            this.dtpBaslangic.TabIndex = 1;
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(150, 158);
            this.txtGun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(249, 30);
            this.txtGun.TabIndex = 2;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(150, 216);
            this.txtDurum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDurum.Multiline = true;
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(249, 84);
            this.txtDurum.TabIndex = 3;
            // 
            // lstIzinler
            // 
            this.lstIzinler.FormattingEnabled = true;
            this.lstIzinler.ItemHeight = 23;
            this.lstIzinler.Location = new System.Drawing.Point(438, 43);
            this.lstIzinler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstIzinler.Name = "lstIzinler";
            this.lstIzinler.Size = new System.Drawing.Size(499, 372);
            this.lstIzinler.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.YellowGreen;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(150, 331);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(250, 58);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "İZİN KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(25, 47);
            this.lblPersonel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(113, 23);
            this.lblPersonel.TabIndex = 6;
            this.lblPersonel.Text = "Personel Seç:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(25, 108);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(90, 23);
            this.lblTarih.TabIndex = 7;
            this.lblTarih.Text = "Başlangıç:";
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Location = new System.Drawing.Point(25, 162);
            this.lblGun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(97, 23);
            this.lblGun.TabIndex = 8;
            this.lblGun.Text = "Gün Sayısı:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(25, 220);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(72, 23);
            this.lblDurum.TabIndex = 9;
            this.lblDurum.Text = "Nedeni:";
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.Location = new System.Drawing.Point(438, 14);
            this.lblListe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(110, 23);
            this.lblListe.TabIndex = 10;
            this.lblListe.Text = "İzin Geçmişi:";
            // 
            // LeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1000, 647);
            this.Controls.Add(this.lblListe);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblPersonel);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstIzinler);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.txtGun);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.cmbPersonel);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LeaveForm";
            this.Text = "İzin Yönetim Ekranı";
            this.Load += new System.EventHandler(this.LeaveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.ListBox lstIzinler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblGun;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblListe;
    }
}