namespace proje_odev
{
    partial class DepartmentForm
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

        
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.depListBox = new System.Windows.Forms.ListBox();
            this.txtDepAd = new System.Windows.Forms.TextBox();
            this.txtKat = new System.Windows.Forms.TextBox();
            this.txtIletisim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "İletişim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bulunduğu Kat";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.YellowGreen;
            this.btnKaydet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKaydet.Location = new System.Drawing.Point(258, 291);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 60);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSil.Location = new System.Drawing.Point(386, 291);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(99, 60);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // depListBox
            // 
            this.depListBox.FormattingEnabled = true;
            this.depListBox.ItemHeight = 23;
            this.depListBox.Location = new System.Drawing.Point(540, 49);
            this.depListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.depListBox.Name = "depListBox";
            this.depListBox.Size = new System.Drawing.Size(209, 211);
            this.depListBox.TabIndex = 5;
            this.depListBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentForm_Load);
            // 
            // txtDepAd
            // 
            this.txtDepAd.Location = new System.Drawing.Point(331, 95);
            this.txtDepAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepAd.Name = "txtDepAd";
            this.txtDepAd.Size = new System.Drawing.Size(124, 30);
            this.txtDepAd.TabIndex = 6;
            // 
            // txtKat
            // 
            this.txtKat.Location = new System.Drawing.Point(331, 207);
            this.txtKat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(124, 30);
            this.txtKat.TabIndex = 7;
            // 
            // txtIletisim
            // 
            this.txtIletisim.Location = new System.Drawing.Point(331, 150);
            this.txtIletisim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIletisim.Name = "txtIletisim";
            this.txtIletisim.Size = new System.Drawing.Size(124, 30);
            this.txtIletisim.TabIndex = 8;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1000, 647);
            this.Controls.Add(this.txtIletisim);
            this.Controls.Add(this.txtKat);
            this.Controls.Add(this.txtDepAd);
            this.Controls.Add(this.depListBox);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentForm";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox depListBox;
        private System.Windows.Forms.TextBox txtDepAd;
        private System.Windows.Forms.TextBox txtKat;
        private System.Windows.Forms.TextBox txtIletisim;
    }
}