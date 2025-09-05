# PROJECT_CAREERCIN
## JUDUL APLIKASI YANG SAYA BUAT YAITU "CareerCin"
CareerCin adalah sistem informasi pencarian kerja yang menggunakan 3 role dan menyediakan fitur: </h2>
- User (Pencari Kerja)
  Registrasi, login, dan pengelolaan profil (foto, CV, data diri).
  Mencari lowongan pekerjaan berdasarkan kategori, kata kunci, atau perusahaan.
  Melamar pekerjaan secara online dengan upload CV.
  Menyimpan lowongan favorit.
  Melihat riwayat lamaran.
- Perusahaan
  Registrasi dan login perusahaan.
  Membuat, mengedit, dan menghapus lowongan pekerjaan.
  Melihat pelamar untuk lowongan yang diposting.
  Menyimpan lamaran kandidat (shortlist).
- Admin
  Mengelola data pengguna, perusahaan, kategori pekerjaan, dan lowongan.
## Teknologi yang Digunakan</h2>
- Frontend: Razor View Engine, HTML5, CSS3, Bootstrap 5, Font Awesome.
- Backend: ASP.NET Core MVC (.NET 6/7).
- Database: MySQL-SqlYog.
- ORM: Entity Framework Core.
- Fitur Tambahan:
Upload file (CV) dengan validasi format.
SweetAlert untuk konfirmasi aksi.
OTP untuk verifikasi akun.
## Cara Menjalankan Project
1. Clone Repository
2. Setup Database
   Buat database di MySQL dengan nama career_db.
   Import file career_db.sql (jika tersedia di folder database).
   Atur koneksi database di appsettings.json:
3. Install Dependencies
   Pastikan .NET SDK sudah terpasang. Jalankan:

## Struktur Project
CareerCin/
│
├── Controllers/      # Controller untuk user, perusahaan, admin
├── Models/           # Model dan DTO
├── Views/            # Razor Views (UI)
├── wwwroot/          # Static files (CSS, JS, Images)
├── appsettings.json  # Konfigurasi aplikasi
└── Program.cs        # Entry point aplikasi

## Cara Menggunakan
1. Jalankan aplikasi.
2. Pertama yang harus di jalankan yaitu admin untuk usernamenya = "admin" dan passwordnya = "admin123", kenapa admin duluan yg dijalankan? karena di admin kita harus add kategori, nah kategori ini digunakan nanti di perusahaan saat add lowongan. admin juga bisa delete atau edit kategori. admin juga berperan untuk mengelola atau memanajemen akun perusahaan dan pelamar, juga bisa mengelola lowongan yang dibuat oleh perusahaan (jadi jika lowongan tersebut tidak sesuai dengan SOP maka admin bisa memblokirnya).
3. kedua yaitu perusahaan, pertama kamu harus registrasi dulu, terus login, dan nanti akan masuk ke dashboard perusahaan, nah perusahaan ini bisa membuat lowongan, lengkap dengan crudnya. juga perusahaan bisa mengelola pelamar (diterima atau ditolak lamarannya), dan bisa edit profile jugaa.
4.- Registrasi, Login, dan Pengelolaan Profil : Pengguna dapat membuat akun baru melalui proses registrasi yang sederhana, kemudian login untuk mengakses fitur-fitur utama. Setelah berhasil masuk, pengguna dapat mengelola profil mereka dengan mudah, termasuk:
- Mengunggah foto profil : Mengisi data diri seperti nama, email, nomor telepon, dan informasi pendidikan. Mengunggah dokumen CV agar perusahaan dapat melihat kualifikasi mereka. Pencarian Lowongan Pekerjaan
- Pengguna dapat mencari lowongan pekerjaan berdasarkan: Kategori pekerjaan (misalnya: IT, Keuangan, Desain). Kata kunci spesifik sesuai posisi yang diinginkan.Nama perusahaan untuk melamar di perusahaan tertentu.
- Melamar Pekerjaan Secara Online : Dengan hanya beberapa klik, pengguna dapat melamar pekerjaan secara langsung melalui platform ini. Sistem menyediakan opsi untuk mengunggah CV pada setiap lamaran, memastikan perusahaan mendapatkan informasi terbaru mengenai kandidat.
- Menyimpan Lowongan Favorit(saved jobs) : CareerCin memungkinkan pengguna untuk menyimpan lowongan yang menarik ke dalam daftar favorit, sehingga mereka dapat mengaksesnya kembali kapan saja tanpa harus mencarinya ulang.
- Melihat Riwayat Lamaran (history application) : Pengguna dapat memantau status lamaran yang telah dikirim melalui fitur riwayat lamaran. Dengan demikian, mereka bisa mengetahui apakah lamaran masih dalam proses, diterima, atau ditolak.
- Notification : fungsinya untuk memberi tahu user kalo ada lowongan yang sesuai dengan posisi yang dia simpan di profile dia
