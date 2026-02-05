# Proje Tanıtım Videosu
https://youtu.be/f0PplKrWPwM
# 📚 Kütüphane Otomasyon Sistemi
## 👩‍💻 Proje Sahibi

Esra Yücetağ
Yönetim Bilişim Sistemleri – 2. Sınıf

## 📌 Proje Hakkında

Bu proje, kütüphanelerde kitap, üye ve ödünç alma işlemlerinin dijital ortamda yönetilmesini sağlayan masaüstü bir otomasyon sistemidir. Sistem, yöneticilerin kütüphane operasyonlarını kolaylaştırmasını ve üyelerin kendi kitap durumlarını görüntüleyebilmesini amaçlamaktadır.

Proje, Nesne Yönelimli Programlama prensiplerine uygun olarak N-Katmanlı Mimari (UI – BLL – DAL – Database) kullanılarak geliştirilmiştir.

## 🧱 Kullanılan Teknolojiler

💻 C# (Windows Forms)

🗄 MySQL Veritabanı

🧩 N-Katmanlı Mimari

📊 DataGridView & Chart Kontrolleri

🔗 MySql.Data Kütüphanesi

## 🏗 Mimari Yapı

Proje aşağıdaki katmanlardan oluşmaktadır:

### 🎨 UI (User Interface)

Kullanıcı arayüzü işlemlerini yönetir.
Form ekranları bu katmanda yer alır.

### 🧠 BLL (Business Logic Layer)

İş kuralları burada uygulanır.
Örnek:

Maksimum ödünç kitap limiti

Gecikme kontrolü

Kara liste kontrolü

### 💾 DAL (Data Access Layer)

Veritabanı ile iletişim kurar.

### 🗃 Database

MySQL 

## 🙋 Üye Paneli

Üyeler kendi bilgilerini görüntüleyebilir:

✔ Üzerindeki kitaplar
✔ Geciken kitap sayısı
✔ Okuduğu toplam kitap sayısı
✔ Kara liste durumu
✔ Tüm işlem geçmişi

## 📊 İstatistik Modülü

Sistem aşağıdaki analizleri sunmaktadır:

En çok kitap okuyan üyeler

En çok okunan kitaplar

Gecikme oranı grafiği

Son 6 aylık ödünç alma grafiği

Toplam kitap ve üye sayısı

⚙ Sistem Özellikleri
## 📚 Kitap Yönetimi

Aynı kitap tekrar eklenirse stok artırılır

Çoklu kitap silme desteklenir

Stok sıfırlanınca kayıt kaldırılır

## 🔄 Ödünç İşlemleri

Üye başına maksimum 3 kitap sınırı

14 gün teslim süresi

Gecikme kontrolü

Çoklu teslim alma desteği

## 🚫 Kara Liste Sistemi

Çok gecikme yapan üyeler kara listeye alınabilir

Kara listedeki üyeler ödünç alamaz

## 🔐 Giriş Sistemi

TC + Şifre ile giriş

Yönetici ve üye panelleri ayrıdır
