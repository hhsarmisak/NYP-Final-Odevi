using proje_odev.Service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proje_odev
{
    public partial class ReportForm : Form
    {
        ReportService service = new ReportService();

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
        }


        private void btnDeptRapor_Click(object sender, EventArgs e)
        {
            dgvRaporlar.DataSource = service.DepartmanDagilimiGetir();
            TabloyuOku();
        }

        private void btnIzinRapor_Click(object sender, EventArgs e)
        {
            dgvRaporlar.DataSource = service.IzinRaporuGetir();
            TabloyuOku();
        }

        private void btnMaasRapor_Click(object sender, EventArgs e)
        {
            dgvRaporlar.DataSource = service.MaasRaporuGetir();
            TabloyuOku();
        }

        private void btnPerfRapor_Click(object sender, EventArgs e)
        {
            dgvRaporlar.DataSource = service.PerformansRaporuGetir();
            TabloyuOku();
        }

        private void btnKalanIzin_Click(object sender, EventArgs e)
        {
            dgvRaporlar.DataSource = service.IzinDurumuGetir();
            TabloyuOku();
        }

        private void btnIzinHakki_Click(object sender, EventArgs e)
        {
            dgvRaporlar.DataSource = service.IzinDurumuGetir();
            TabloyuOku();
        }

        // --- HATA ÇÖZÜMÜ ---
        // Hata mesajın bu metodu aradığı için ekledik. İçi boş kalabilir.
        private void dgvRaporlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // --- SADE VE OKUNAKLI AYARLAR ---
        private void TabloyuOku()
        {
            if (dgvRaporlar.DataSource == null) return;

            // 1. GENİŞLİK AYARI (Yazılar kesilmesin diye)
            // 'AllCells' sayesinde sütunlar içindeki yazı kadar genişler.
            dgvRaporlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // 2. TEMEL AYARLAR
            dgvRaporlar.RowHeadersVisible = false; // Soldaki gri kutuyu gizle
            dgvRaporlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Satırı tam seç
            dgvRaporlar.ReadOnly = true; // Sadece okunsun
            dgvRaporlar.AllowUserToAddRows = false; // Boş satır olmasın

            // 3. YAZI TİPİ (Net Okunurluk)
            dgvRaporlar.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvRaporlar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Satırları biraz ferahlatalım
            dgvRaporlar.RowTemplate.Height = 30;
        }
    }
}