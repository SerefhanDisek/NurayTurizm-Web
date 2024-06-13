using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DataAccess.Models;

namespace DataAccess
{
    public class TurContext : IdentityDbContext<ApplicationUser>
    {
        public TurContext(DbContextOptions<TurContext> options) : base(options) { }

        public DbSet<Tur> Turlar { get; set; }
        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Ulke> Ulkeler { get; set; }
        public DbSet<Lokasyon> Lokasyonlar { get; set; }
        public DbSet<GeziProgramı> GeziProgramlari { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<TurKategori> TurKategorileri { get; set; }
        public DbSet<TurAltKategori> TurAltKategorileri { get; set; }
        public DbSet<TuraKayit> TuraKayitlar { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<Tahsilat> Tahsilatlar { get; set; }
        public DbSet<TahsilatTuru> TahsilatTurleri { get; set; }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Identity tablolarını oluşturmak için

            modelBuilder.Entity<Adres>()
                .HasOne(a => a.Tur)
                .WithMany(t => t.Adresler)
                .HasForeignKey(a => a.TurID);

            modelBuilder.Entity<Lokasyon>()
                .HasOne(l => l.BulunduguUlke)
                .WithMany(u => u.Lokasyonlar)
                .HasForeignKey(l => l.BulunduguUlkeID);

            modelBuilder.Entity<GeziProgramı>()
                .HasOne(g => g.Tur)
                .WithMany(t => t.GeziProgramları)
                .HasForeignKey(g => g.TurID);

            modelBuilder.Entity<TuraKayit>()
                .HasOne(k => k.Tur)
                .WithMany(t => t.TuraKayitlar)
                .HasForeignKey(k => k.TurID);

            modelBuilder.Entity<Fatura>()
                .HasOne(f => f.Tahsilat)
                .WithMany(t => t.Faturalar)
                .HasForeignKey(f => f.TahsilatID);

            modelBuilder.Entity<Tahsilat>()
                .HasOne(t => t.TahsilatTuru)
                .WithMany(tt => tt.Tahsilatlar)
                .HasForeignKey(t => t.TahsilatTuruID);

            modelBuilder.Entity<Rezervasyon>()
                .HasOne(r => r.Tur)
                .WithMany(t => t.Rezervasyonlar)
                .HasForeignKey(r => r.TurID);

            modelBuilder.Entity<Rezervasyon>()
                .HasOne(r => r.User)
                .WithMany(u => u.Rezervasyonlar)
                .HasForeignKey(r => r.UserID);

            modelBuilder.Entity<Yorum>()
                .HasOne(y => y.Tur)
                .WithMany(t => t.Yorumlar)
                .HasForeignKey(y => y.TurID);

            modelBuilder.Entity<Yorum>()
                .HasOne(y => y.User)
                .WithMany(u => u.Yorumlar)
                .HasForeignKey(y => y.UserID);
        }
    }
}

