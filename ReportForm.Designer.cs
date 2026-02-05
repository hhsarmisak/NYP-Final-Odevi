namespace proje_odev
{
    partial class ReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeptRapor = new System.Windows.Forms.Button();
            this.btnIzinRapor = new System.Windows.Forms.Button();
            this.btnMaasRapor = new System.Windows.Forms.Button();
            this.btnPerfRapor = new System.Windows.Forms.Button();
            this.btnKalanIzin = new System.Windows.Forms.Button();
            this.dgvRaporlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeptRapor
            // 
            this.btnDeptRapor.BackColor = System.Drawing.Color.BlueViolet;
            this.btnDeptRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeptRapor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeptRapor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeptRapor.Location = new System.Drawing.Point(100, 93);
            this.btnDeptRapor.Name = "btnDeptRapor";
            this.btnDeptRapor.Size = new System.Drawing.Size(298, 75);
            this.btnDeptRapor.TabIndex = 0;
            this.btnDeptRapor.Text = "Departman Dağılımı";
            this.btnDeptRapor.UseVisualStyleBackColor = false;
            this.btnDeptRapor.Click += new System.EventHandler(this.btnDeptRapor_Click);
            // 
            // btnIzinRapor
            // 
            this.btnIzinRapor.BackColor = System.Drawing.Color.BlueViolet;
            this.btnIzinRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzinRapor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinRapor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIzinRapor.Location = new System.Drawing.Point(100, 253);
            this.btnIzinRapor.Name = "btnIzinRapor";
            this.btnIzinRapor.Size = new System.Drawing.Size(298, 75);
            this.btnIzinRapor.TabIndex = 1;
            this.btnIzinRapor.Text = "İzin Raporu";
            this.btnIzinRapor.UseVisualStyleBackColor = false;
            this.btnIzinRapor.Click += new System.EventHandler(this.btnIzinRapor_Click);
            // 
            // btnMaasRapor
            // 
            this.btnMaasRapor.BackColor = System.Drawing.Color.BlueViolet;
            this.btnMaasRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaasRapor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaasRapor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMaasRapor.Location = new System.Drawing.Point(100, 174);
            this.btnMaasRapor.Name = "btnMaasRapor";
            this.btnMaasRapor.Size = new System.Drawing.Size(298, 74);
            this.btnMaasRapor.TabIndex = 2;
            this.btnMaasRapor.Text = "Maaş Durumu";
            this.btnMaasRapor.UseVisualStyleBackColor = false;
            this.btnMaasRapor.Click += new System.EventHandler(this.btnMaasRapor_Click);
            // 
            // btnPerfRapor
            // 
            this.btnPerfRapor.BackColor = System.Drawing.Color.BlueViolet;
            this.btnPerfRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfRapor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPerfRapor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPerfRapor.Location = new System.Drawing.Point(100, 408);
            this.btnPerfRapor.Name = "btnPerfRapor";
            this.btnPerfRapor.Size = new System.Drawing.Size(298, 74);
            this.btnPerfRapor.TabIndex = 3;
            this.btnPerfRapor.Text = "Performans";
            this.btnPerfRapor.UseVisualStyleBackColor = false;
            this.btnPerfRapor.Click += new System.EventHandler(this.btnPerfRapor_Click);
            // 
            // btnKalanIzin
            // 
            this.btnKalanIzin.BackColor = System.Drawing.Color.BlueViolet;
            this.btnKalanIzin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKalanIzin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKalanIzin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKalanIzin.Location = new System.Drawing.Point(100, 334);
            this.btnKalanIzin.Name = "btnKalanIzin";
            this.btnKalanIzin.Size = new System.Drawing.Size(298, 68);
            this.btnKalanIzin.TabIndex = 4;
            this.btnKalanIzin.Text = "İzin Hakkı";
            this.btnKalanIzin.UseVisualStyleBackColor = false;
            this.btnKalanIzin.Click += new System.EventHandler(this.btnKalanIzin_Click);
            
            this.dgvRaporlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRaporlar.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRaporlar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRaporlar.EnableHeadersVisualStyles = false;
            this.dgvRaporlar.Location = new System.Drawing.Point(449, 87);
            this.dgvRaporlar.Name = "dgvRaporlar";
            this.dgvRaporlar.RowHeadersWidth = 51;
            this.dgvRaporlar.RowTemplate.Height = 30;
            this.dgvRaporlar.Size = new System.Drawing.Size(378, 379);
            this.dgvRaporlar.TabIndex = 5;
            this.dgvRaporlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRaporlar_CellContentClick);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(899, 553);
            this.Controls.Add(this.dgvRaporlar);
            this.Controls.Add(this.btnDeptRapor);
            this.Controls.Add(this.btnIzinRapor);
            this.Controls.Add(this.btnMaasRapor);
            this.Controls.Add(this.btnPerfRapor);
            this.Controls.Add(this.btnKalanIzin);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeptRapor;
        private System.Windows.Forms.Button btnIzinRapor;
        private System.Windows.Forms.Button btnMaasRapor;
        private System.Windows.Forms.Button btnPerfRapor;
        private System.Windows.Forms.Button btnKalanIzin;
        private System.Windows.Forms.DataGridView dgvRaporlar;
    }
}