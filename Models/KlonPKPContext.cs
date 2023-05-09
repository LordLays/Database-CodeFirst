using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace KlonPKP_CodeFirst.Models
{
    public partial class KlonPKPContext : DbContext
    {
        public KlonPKPContext()
        {
        }

        public KlonPKPContext(DbContextOptions<KlonPKPContext> options) : base(options)
        {
        }

        public virtual DbSet<Bilet> Bilety { get; set; }
        public virtual DbSet<Kurs> Kursy { get; set; }
        public virtual DbSet<Pasazer> Pasazerowie { get; set; }
        public virtual DbSet<Pociag> Pociagi { get; set; }
        public virtual DbSet<Przewoznik> Przewoznicy { get; set; }
        public virtual DbSet<Przystanki> Przystanki { get; set; }
        public virtual DbSet<Przystanki_Pociagu> Przystanki_Pociagu { get; set; }
        public virtual DbSet<Status> Statusy { get; set; }
        public virtual DbSet<TypWagonu> TypWagonu { get; set; }
        public virtual DbSet<Wagon> Wagony { get; set; }
        public virtual DbSet<Znizka> Znizki { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(ConfigurationSetup.ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Pasazer>(entity =>
            {
                entity.HasKey(e => e.ID_Pasazera)
                    .HasName("PK__Pasażer__ID_Pasażera");
                entity.Property(e => e.ID_Pasazera)
                    .HasColumnName("ID_Pasażera")
                    .ValueGeneratedNever();
                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
                entity.Property(e => e.Wiek)
                    .IsRequired()
                    .HasColumnType("tinyint");
                entity.Property(e => e.Ulica)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
                entity.Property(e => e.Nr_Domu)
                    .HasColumnName("Nr_Domu")
                    .IsRequired()
                    .HasColumnType("smallint");
                entity.Property(e => e.Nr_Mieszkania)
                    .HasColumnName("Nr_Mieszkania")
                    .HasColumnType("smallint");
                entity.Property(e => e.Kod_Pocztowy)
                    .HasColumnName("Kod_pocztowy")
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);
                entity.Property(e => e.Miasto)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.Kraj)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Znizka>(entity =>
            {
                entity.HasKey(e => e.Nazwa)
                    .HasName("PK__Znizka__Nazwa");
                entity.Property(e => e.Nazwa)
                    .HasMaxLength(40)
                    .IsUnicode(false);
                entity.Property(e => e.Opis)
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.Wartosc)
                    .IsRequired()
                    .HasColumnType("decimal(4,2)");
            });

            modelBuilder.Entity<TypWagonu>(entity =>
            {
                entity.HasKey(e => e.Nazwa)
                    .HasName("PK__TypWagonu__Nazwa");
                entity.Property(e => e.Nazwa)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Cena)
                    .IsRequired()
                    .HasColumnType("decimal(5,2)");
            });

            modelBuilder.Entity<TypWagonu>(entity =>
            {
                entity.HasKey(e => e.Nazwa)
                    .HasName("PK__TypWagonu__Nazwa");
                entity.Property(e => e.Nazwa)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Cena)
                    .IsRequired()
                    .HasColumnType("decimal(5,2)");
            });

            modelBuilder.Entity<Pociag>(entity =>
            {
                entity.HasKey(e => e.Kod_Pociagu)
                    .HasName("PK__Pociag__Kod_Pociagu");
                entity.Property(e => e.Kod_Pociagu)
                    .HasMaxLength(8)
                    .IsUnicode(false);
                entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.Kategoria)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.Przewoznik)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Przystanki>(Entity =>
            {
                Entity.HasKey(e => e.ID_Przystanku)
                    .HasName("PK__Przystanki__ID_Przystanku");
                Entity.Property(e => e.ID_Przystanku).HasColumnName("ID_Przystanku");
                Entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
                Entity.Property(e => e.Peron).IsRequired();
                Entity.Property(e => e.Tor).IsRequired();
                Entity.Property(e => e.Przyjazd).IsRequired();
                Entity.Property(e => e.Odjazd).IsRequired();
            });

            modelBuilder.Entity<Przystanki_Pociagu>(Entity =>
            {

                Entity.HasKey(e => new { e.ID_Przystanku, e.Kod_Pociagu })
                    .HasName("PK_Przystanki_Pociagu");
                Entity.Property(e => e.ID_Przystanku).HasColumnName("ID_Przystanku");
                Entity.Property(e => e.Kod_Pociagu)
                    .HasMaxLength(8)
                    .IsUnicode(false);
                Entity.Property(e => e.Przyjazd).IsRequired();
                Entity.Property(e => e.Odjazd).IsRequired();
            });

            modelBuilder.Entity<Status>(Entity =>
            {
                Entity.HasKey(e => e.ID_Statusu)
                    .HasName("PK__Status__ID_Statusu");
                Entity.Property(e => e.ID_Statusu).HasColumnName("ID_Statusu");
                Entity.Property(e => e.Poprzedni_Przystanek).IsRequired();
                Entity.Property(e => e.Nastepny_Przystanek).IsRequired();
                Entity.Property(e => e.Opóźnienie).IsRequired();
                Entity.Property(e => e.Ukonczony).IsRequired();
            });


            modelBuilder.Entity<Kurs>(Entity =>
                {

                    Entity.HasKey(e => e.ID_Kursu)
                        .HasName("PK__Kurs__ID_Kursu");
                    Entity.Property(e => e.ID_Kursu).HasColumnName("ID_Kursu");
                    Entity.Property(e => e.Pociag)
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false);
                    Entity.Property(e => e.Status).IsRequired();
                    Entity.Property(e => e.Czas_Podrozy).IsRequired();
                    Entity.Property(e => e.Data).IsRequired();
                });


            modelBuilder.Entity<Bilet>(Entity =>
            {
                Entity.HasKey(e => e.Nr_Biletu)
                    .HasName("PK__Bilet__Nr_Biletu");
                Entity.Property(e => e.Nr_Biletu).HasColumnName("Nr_Biletu");
                Entity.Property(e => e.Pasazer).IsRequired();
                Entity.Property(e => e.Kurs).IsRequired();
                Entity.Property(e => e.Data_zakupu).IsRequired();
                Entity.Property(e => e.Data_podrozy).IsRequired();
                Entity.Property(e => e.Czas_podrozy).IsRequired();
                Entity.Property(e => e.Typ_Wagonu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
                Entity.Property(e => e.Wagon).IsRequired();
                Entity.Property(e => e.Miejsce).IsRequired();
                Entity.Property(e => e.Stacja_Poczatkowa).IsRequired();
                Entity.Property(e => e.Stacja_Koncowa).IsRequired();
                Entity.Property(e => e.Sprawdzony).IsRequired();
                Entity.Property(e => e.Znizka)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
                Entity.Property(e => e.Naleznosc).IsRequired();
            });
        }
    }
}
