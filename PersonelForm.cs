using Personel.Service;
using proje_odev.Service; 
using System;
using System.Collections;
using System.Windows.Forms;

using Bolum = Personel.Domain.Departman;
using Calisan = Personel.Domain.Personel;

namespace proje_odev
{
    public partial class PersonelForm : Form
    {
       
        PersonelService personelService = new PersonelService();
        DepartmanService departmanService = new DepartmanService();

        public PersonelForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            DepartmanlariYukle();
            RolleriYukle();
            PersonelleriListele();
        }

      
        private void DepartmanlariYukle()
        {
            var departmanListesi = departmanService.departmanlarGetir();
            cmbDepartman.DataSource = departmanListesi;

            
            cmbDepartman.DisplayMember = "Adi";

            
            cmbDepartman.ValueMember = "DepartmanId";

            cmbDepartman.SelectedIndex = -1; 
        }

        private void RolleriYukle()
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Yönetici");
            cmbRol.Items.Add("İnsan Kaynakları");
            cmbRol.Items.Add("Personel");
            cmbRol.SelectedIndex = -1;
        }

      
        private void PersonelleriListele()
        {
            personelListBox.Items.Clear(); 
            var gelenListe = personelService.personelleriListele();

            if (gelenListe != null)
            {
                foreach (var item in gelenListe)
                {
                    Calisan p = (Calisan)item;
                   
                    personelListBox.Items.Add(p);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (cmbDepartman.SelectedIndex == -1 || cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Departman ve Rol seçiniz!");
                return;
            }

            try
            {
                Calisan yeniP = new Calisan();
                yeniP.Ad = txtAd.Text;
                yeniP.Soyad = txtSoyad.Text;
                yeniP.Eposta = txtEposta.Text;
                yeniP.Sifre = "1234"; 
                yeniP.Rol = cmbRol.Text;

                int maas = 0;
                int.TryParse(txtMaas.Text, out maas);
                yeniP.Maas = maas;

                if (cmbDepartman.SelectedValue != null)
                {
                    yeniP.Did = Convert.ToInt32(cmbDepartman.SelectedValue);
                }

               
                personelService.personelKaydet(yeniP);

                MessageBox.Show("Personel başarıyla kaydedildi.");

               
                PersonelleriListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        
        private void btnSil_Click(object sender, EventArgs e)
        {
          
            if (personelListBox.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek personeli seçin!");
                return;
            }

            Calisan secilenPersonel = (Calisan)personelListBox.SelectedItem;

            DialogResult cevap = MessageBox.Show(secilenPersonel.Ad + " silinecek. Emin misin?", "Silme Onayı", MessageBoxButtons.YesNo);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                   
                    personelService.sil(secilenPersonel.Id);

                    MessageBox.Show("Silindi!");
                    PersonelleriListele(); 
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silinirken hata oldu: " + ex.Message);
                }
            }
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtMaas.Clear();
            txtEposta.Clear();
            cmbDepartman.SelectedIndex = -1;
            cmbRol.SelectedIndex = -1;
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
           
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
        }
    }
}