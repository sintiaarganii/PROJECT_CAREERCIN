using Microsoft.EntityFrameworkCore;
using PROJECT_CAREERCIN.Interfaces;
using PROJECT_CAREERCIN.Models.DB;

namespace PROJECT_CAREERCIN.Models
{
    public class ApplicationContext : DbContext
    {
        public readonly IEnkripsiPassword _enkripsiPassword;
        public ApplicationContext(DbContextOptions<ApplicationContext> options, IEnkripsiPassword enkripsiPassword) : base(options)
        {
            _enkripsiPassword = enkripsiPassword;
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<KategoriPekerjaan> KategoriPekerjaans { get; set; }
        public virtual DbSet<LowonganPekerjaan> LowonganPekerjaans { get; set; }
        public virtual DbSet<Lamaran> Lamarans { get; set; }
        public virtual DbSet<LamaranTersimpan> LamaranTersimpans { get; set; }
        public virtual DbSet<LowonganTersimpan> LowonganTersimpans { get; set; }
        public virtual DbSet<Perusahaan> Perusahaans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tambahkan admin default
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Email = "admin@example.com",
                    PasswordHash = _enkripsiPassword.HashPassword("admin123"), // Buat method HashPassword
                    CoverImage = "",
                    ProfileImage = "",
                    Role = "Admin",
                    Posisi = "Administrator",
                    CreatedAt = DateTime.Now,
                    Status = GeneralStatus.GeneralStatusData.Active
                }
            );

            // Relasi User dengan Lamaran (One-to-Many)
            modelBuilder.Entity<User>()
                .HasMany(u => u.Lamarans)
                .WithOne(l => l.user)
                .HasForeignKey(l => l.UserId);

            // Relasi User dengan LowonganTersimpan (One-to-Many)
            modelBuilder.Entity<User>()
                .HasMany(u => u.lowonganTersimpans)
                .WithOne(lt => lt.User)
                .HasForeignKey(lt => lt.PenggunaId);

            // Relasi User dengan LamaranTersimpan (One-to-Many)
            modelBuilder.Entity<User>()
                .HasMany(u => u.RiwayatLamaran)
                .WithOne(lt => lt.User)
                .HasForeignKey(lt => lt.PenggunaId);

            // Relasi KategoriPekerjaan dengan LowonganPekerjaan (One-to-Many)
            modelBuilder.Entity<KategoriPekerjaan>()
                .HasMany(k => k.Lowongans)
                .WithOne(l => l.Kategori)
                .HasForeignKey(l => l.KategoriId);

            // Relasi Perusahaan dengan LowonganPekerjaan (One-to-Many)
            modelBuilder.Entity<Perusahaan>()
                .HasMany(p => p.Lowongans)
                .WithOne(l => l.Perusahaan)
                .HasForeignKey(l => l.PerusahaanId);

            // Relasi LowonganPekerjaan dengan Lamaran (One-to-Many)
            modelBuilder.Entity<LowonganPekerjaan>()
                .HasMany(l => l.Lamarans)
                .WithOne(la => la.Lowongan)
                .HasForeignKey(la => la.LowonganId);

            // Relasi LowonganPekerjaan dengan LowonganTersimpan (One-to-Many)
            modelBuilder.Entity<LowonganPekerjaan>()
                .HasMany(l => l.LowonganTersimpans)
                .WithOne(lt => lt.Lowongan)
                .HasForeignKey(lt => lt.LowonganId);

            // Relasi Lamaran dengan LamaranTersimpan (One-to-One)
            modelBuilder.Entity<Lamaran>()
                .HasOne(l => l.LamaranTersimpan)
                .WithOne(lt => lt.Lamaran)
                .HasForeignKey<LamaranTersimpan>(lt => lt.LamaranId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
