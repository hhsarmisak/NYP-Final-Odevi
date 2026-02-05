# NYP-Final-Odevi
Nesne Yönelimli Programlama Final Ödevim. İnsan Kaynakları konulu projem. 1324300433 Hüseyin Hamza Sarmısak
İnsan Kaynakları Projem
Bu proje, bir işletmedeki personellerin takibini, izin yönetimini ve performans analizlerini gerçekleştirmek amacıyla geliştirilmiş bir Windows Forms (WinForms) otomasyonudur. Katmanlı Mimari (N-Tier Architecture) prensiplerine sadık kalınarak, C# programlama dili ve MySQL veritabanı kullanılarak tasarlanmıştır.
🚀 Proje Hakkında
Bu proje, Nesne Yönelimli Programlama dersi kapsamında dönem ödevi olarak geliştirilmiştir. Projenin temel amacı; kurumsal kaynak planlamasının bir parçası olan İnsan Kaynakları uygulamasının temel fonksiyonlarını simüle etmektir.

Proje şunları sağlar:

Personel verilerinin yönetimi.

İzin taleplerinin oluşturulması ve kalan izin haklarının otomatik hesaplanması.

Departman, Maaş ve Performans bazlı detaylı raporlamalar.

Verilerin ilişkisel veritabanı (Relational Database) üzerinde tutulması.

🛠️ Kullanılan Teknolojiler ve Mimari
Proje geliştirilirken aşağıdaki teknolojiler ve yapılar kullanılmıştır:

Dil: C# (.NET Framework)

Veritabanı: MySQL

IDE: Visual Studio 2022

Veri Erişim Yöntemi: ADO.NET / MySQL Connector

Mimari: Katmanlı Mimari (Layered Architecture)

Proje Mimarisi
Kodun okunabilirliğini ve sürdürülebilirliğini artırmak için proje katmanlara ayrılmıştır:

Personel.Domain (Varlık Katmanı): Veritabanı tablolarına karşılık gelen nesneler (Personel, Izin, vb.) burada tanımlanmıştır.

Personel.DAL (Veri Erişim Katmanı): Veritabanı ile doğrudan iletişim kuran, SQL sorgularının (INSERT, SELECT, JOIN) bulunduğu katmandır (DAO sınıfları).

Personel.Service (İş Katmanı): Formlar ile Veri Erişim katmanı arasındaki köprüdür. İş mantığı (Business Logic) burada yürütülür.

UI (Kullanıcı Arayüzü): Kullanıcının etkileşime girdiği Windows Form ekranları (LeaveForm, ReportForm vb.).

✨ Özellikler
1. İzin Yönetimi (Leave Management)
Personeller için izin başlangıç tarihi, gün sayısı ve neden belirtilerek izin kaydı oluşturulabilir.

Sistem, personelin toplam yıllık izin hakkından kullanılan günleri otomatik olarak düşer.

LeaveForm ekranında geçmiş izinler listelenir.

2. Gelişmiş Raporlama (Reporting)
SQL sorguları kullanılarak veriler anlamlı hale getirilmiştir (Örn: ID yerine İsim-Soyad gösterimi).

İzin Hakkı Raporu: Personelin yıllık izni, kullandığı izin ve kalan izin hakkı matematiksel olarak hesaplanıp gösterilir.

Performans Raporu: Personellerin performans puanlarına göre sıralandığı liste.

Departman ve Maaş Raporları: Departman dağılımı ve maaş sıralamaları.

3. Kullanıcı Dostu Arayüz
DataGridView nesneleri özelleştirilerek okunaklı, renkli ve modern bir tablo yapısı oluşturulmuştur (Zebra deseni, dinamik sütun genişliği).
<img width="744" height="492" alt="image" src="https://github.com/user-attachments/assets/1b607562-8d9d-4506-adbc-f59b8e720b45" />
Giril Ekranı
<img width="857" height="596" alt="image" src="https://github.com/user-attachments/assets/789ed4eb-139a-436a-9997-7a1ec43e9745" />
Ana Menü Ekranı
<img width="835" height="573" alt="image" src="https://github.com/user-attachments/assets/241abadd-1ee0-4389-993e-271b6dd8adf3" />
Rapor Ekranı

👤 Geliştirici
Adı Soyadı: Hüseyin Hamza Sarmısak

Okul / Bölüm: Bursa Uludağ Üniversitesi / Yönetim Bilişim Sistemleri

Öğrenci No: 132430043

Youtube Tanıtım Videosu: https://www.youtube.com/watch?v=jABidfuIw00

Teşekkürler

