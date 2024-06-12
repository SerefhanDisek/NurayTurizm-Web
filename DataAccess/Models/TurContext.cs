using Microsoft.EntityFrameworkCore;
using DataAccess.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DataAccess
{
    public class TurContext : DbContext
    {
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-N1QFE9C\\SQLEXPRESS;Database=TurContext;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // İlişkileri tanımlama
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

            // Diğer ilişkileri benzer şekilde tanımlayın...
        }
    }
}

