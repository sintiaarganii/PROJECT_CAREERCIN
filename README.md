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
- Backend: ASP.NET Core MVC (.NET 8).
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
## Cara Menggunakan
1. Jalankan aplikasi.
2. Jalankan sebagai Admin
   Username: admin
   Password: admin123
Mengapa admin dijalankan terlebih dahulu?
Karena admin memiliki peran penting dalam mempersiapkan data awal untuk sistem, khususnya kategori lowongan pekerjaan yang nantinya akan digunakan oleh perusahaan saat membuat lowongan.
Fitur-fitur yang dapat dilakukan Admin:
* Manajemen Kategori:
- Tambah kategori (contoh: IT, Keuangan, Marketing).
- Edit kategori (ubah nama kategori jika diperlukan).
- Hapus kategori (jika kategori tidak relevan lagi).
* Manajemen Akun:
- Lihat semua akun perusahaan dan pelamar.
- Nonaktifkan atau blokir akun yang melanggar kebijakan.
- Mengaktifkan kembali akun yang diblokir.
* Manajemen Lowongan:
- Lihat semua lowongan pekerjaan yang dibuat perusahaan.
- Validasi lowongan: jika tidak sesuai SOP, admin dapat memblokir lowongan tersebut.
- Hapus lowongan yang tidak pantas atau melanggar aturan.
* Tujuan:
Sebelum perusahaan menambahkan lowongan, kategori pekerjaan harus tersedia agar perusahaan dapat memilih kategori yang sesuai.
3. Jalankan sebagai Perusahaan
* Langkah-langkah yang harus dilakukan perusahaan:
  1. Registrasi akun perusahaan
  - Mengisi data perusahaan (nama perusahaan, email, alamat, dll).
  - Setelah registrasi, perusahaan bisa login ke sistem.
  - Login ke dashboard perusahaan
  - Masukkan username dan password yang sudah didaftarkan.
  2. Fitur di Dashboard Perusahaan:
  * Manajemen Lowongan (CRUD):
  - Tambah lowongan (dengan memilih kategori yang sudah dibuat oleh admin).
  - Edit lowongan (ubah detail lowongan jika ada perubahan).
  - Hapus lowongan (jika lowongan sudah tidak berlaku).
  - Lihat daftar semua lowongan yang dibuat.
  * Manajemen Pelamar:
  - Lihat semua pelamar yang melamar ke lowongan perusahaan.
  - Aksi terhadap pelamar:
    1. Terima lamaran.
    2. Tolak lamaran.
  - Lihat status lamaran (diterima atau ditolak).
  * Manajemen Profil Perusahaan:
  - Update informasi profil (nama, alamat, deskripsi perusahaan, logo).
  - Ubah password.
4. Yang Ketiga Ada User atau Pelamar
    1. Registrasi, Login, dan Pengelolaan Profil : Pengguna dapat membuat akun baru melalui proses registrasi yang sederhana, kemudian login untuk mengakses fitur-fitur utama. Setelah berhasil masuk, pengguna dapat mengelola profil mereka dengan mudah, termasuk:
    2. Mengunggah foto profil : Mengisi data diri seperti nama, email, nomor telepon, dan informasi pendidikan. Mengunggah dokumen CV agar perusahaan dapat melihat kualifikasi mereka. juga ada fitur logout di dalamnya.
    3. Pencarian Lowongan Pekerjaan : Pengguna dapat mencari lowongan pekerjaan berdasarkan: Kategori pekerjaan (misalnya: IT, Keuangan, Desain). Kata kunci spesifik sesuai posisi yang diinginkan.Nama perusahaan untuk melamar di perusahaan tertentu.
    4. Melamar Pekerjaan Secara Online : Dengan hanya beberapa klik, pengguna dapat melamar pekerjaan secara langsung melalui platform ini. Sistem menyediakan opsi untuk mengunggah CV pada setiap lamaran, memastikan perusahaan mendapatkan informasi terbaru mengenai kandidat.
    5. Menyimpan Lowongan Favorit(saved jobs) : CareerCin memungkinkan pengguna untuk menyimpan lowongan yang menarik ke dalam daftar favorit, sehingga mereka dapat mengaksesnya kembali kapan saja tanpa harus mencarinya ulang.
   6. Melihat Riwayat Lamaran (history application) : Pengguna dapat memantau status lamaran yang telah dikirim melalui fitur riwayat lamaran. Dengan demikian, mereka bisa mengetahui apakah lamaran masih dalam proses, diterima, atau ditolak.
  7. Notification : fungsinya untuk memberi tahu user kalo ada lowongan yang sesuai dengan posisi yang dia simpan di profile dia
