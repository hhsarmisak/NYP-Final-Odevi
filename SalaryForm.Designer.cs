namespace proje_odev
{
    partial class SalaryForm
    {
        
        private System.ComponentModel.IContainer components = null;

        
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.txtTemel = new System.Windows.Forms.TextBox();
            this.txtPrim = new System.Windows.Forms.TextBox();
            this.txtKesinti = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temel Maaş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kesinti";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(435, 154);
            this.cmbPersonel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(150, 31);
            this.cmbPersonel.TabIndex = 4;
            this.cmbPersonel.SelectedIndexChanged += new System.EventHandler(this.cmbPersonelMaas_SelectedIndexChanged);
            // 
            // txtTemel
            // 
            this.txtTemel.Location = new System.Drawing.Point(435, 193);
            this.txtTemel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTemel.Name = "txtTemel";
            this.txtTemel.Size = new System.Drawing.Size(150, 30);
            this.txtTemel.TabIndex = 5;
            // 
            // txtPrim
            // 
            this.txtPrim.Location = new System.Drawing.Point(435, 231);
            this.txtPrim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrim.Name = "txtPrim";
            this.txtPrim.Size = new System.Drawing.Size(150, 30);
            this.txtPrim.TabIndex = 6;
            // 
            // txtKesinti
            // 
            this.txtKesinti.Location = new System.Drawing.Point(435, 269);
            this.txtKesinti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKesinti.Name = "txtKesinti";
            this.txtKesinti.Size = new System.Drawing.Size(150, 30);
            this.txtKesinti.TabIndex = 7;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.YellowGreen;
            this.btnHesapla.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHesapla.Location = new System.Drawing.Point(377, 340);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(171, 116);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Maaş Hesapla ve Kaydet";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1000, 647);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtKesinti);
            this.Controls.Add(this.txtPrim);
            this.Controls.Add(this.txtTemel);
            this.Controls.Add(this.cmbPersonel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SalaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalaryForm";
            this.Load += new System.EventHandler(this.SalaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.TextBox txtTemel;
        private System.Windows.Forms.TextBox txtPrim;
        private System.Windows.Forms.TextBox txtKesinti;
        private System.Windows.Forms.Button btnHesapla;
    }
}