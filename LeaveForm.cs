using Personel.Domain;
using Personel.Service;
using System;
using System.Collections;
using System.Windows.Forms;

namespace proje_odev
{
    public partial class LeaveForm : Form
    {
        // Çakışma olmaması için özel isimli servisler
        IzinService _ozelIzinServisi = new IzinService();
        PersonelService _ozelPersonelServisi = new PersonelService();

        public LeaveForm()
        {
            InitializeComponent();
        }

        // Form Yüklenirken
        private void LeaveForm_Load(object sender, EventArgs e)
        {
            ListeleriDoldur();
        }

        private void ListeleriDoldur()
        {
            // Temizlik
            cmbPersonel.Items.Clear();
            lstIzinler.Items.Clear();

            // Personelleri Getir
            ArrayList personeller = _ozelPersonelServisi.personelleriListele();
            foreach (Personel.Domain.Personel p in personeller)
            {
                cmbPersonel.Items.Add(p);
            }

            // İzinleri Getir
            ArrayList izinler = _ozelIzinServisi.izinleriListele();
            foreach (Izin iz in izinler)
            {
                lstIzinler.Items.Add(iz);
            }
        }

        // Kaydet Butonu
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedItem == null)
            {
                MessageBox.Show("Lütfen önce bir personel seçiniz.");
                return;
            }

            try
            {
                Personel.Domain.Personel secilen = (Personel.Domain.Personel)cmbPersonel.SelectedItem;
                string baslangic = dtpBaslangic.Value.ToString("dd MMMM yyyy");

                int gunSayisi = Convert.ToInt32(txtGun.Text);
                string durum = txtDurum.Text;

                _ozelIzinServisi.izinKaydet(secilen.Id, baslangic, gunSayisi, durum);

                MessageBox.Show("İzin başarıyla kaydedildi!");

                ListeleriDoldur();
                txtGun.Clear();
                txtDurum.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen gün sayısı kutusuna sadece rakam giriniz!");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu: " + hata.Message);
            }
        }
    }
}