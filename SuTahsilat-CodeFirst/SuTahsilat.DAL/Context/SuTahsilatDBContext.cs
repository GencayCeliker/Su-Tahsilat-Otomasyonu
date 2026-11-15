using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SuTahsilat.DAL.Entity;

namespace SuTahsilat.DAL.Context
{
    public class SuTahsilatDBContext: DbContext
    {
      public SuTahsilatDBContext(DbContextOptions <SuTahsilatDBContext> options):base(options)
      {
        
      }
      public DbSet<Abone> Aboneler =>Set<Abone>();//Aboneler tablosu oluşturulacak
      public DbSet<Sayac> Sayaclar => Set<Sayac>();
      public DbSet<Tuketim> Tuketimler => Set<Tuketim>();
      public DbSet<Tarife> Tarifeler => Set<Tarife>();
      public DbSet<Ucret> Ucretler => Set<Ucret>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)//MODEL OLUŞTURULMA ESNASINDA NASIL DAVRANACAK
        {
           //Abone Tablosu
           modelBuilder.Entity<Abone>(e =>
           {
             e.ToTable("ABONE");//Tablo adı
             e.HasKey(x=>x.AboneID);//Primary key
               //                 Varchar()         NOT NULL      NVARCHAR 
             e.Property(x=>x.Ad).HasMaxLength(200).IsRequired().IsUnicode();//Ad alanı 200 karakterden uzun olamaz ve boş geçilemez
             e.Property(x=>x.Soyad).HasMaxLength(200).IsRequired().IsUnicode();
             e.Property(x=>x.TCKimlikNo).HasMaxLength(11).IsRequired();
             e.HasIndex(x => x.TCKimlikNo).IsUnique();
             e.Property(x=>x.Adres).HasMaxLength(500).IsRequired().IsUnicode();
             e.Property(x=>x.Telefon).HasMaxLength(15).IsRequired();
           });
            /**********************************************/
            //Sayac Tablosu
            modelBuilder.Entity<Sayac>(e =>
            {
                e.ToTable("SAYAC");//Tablo adı
                e.HasKey(x => x.SayacID );//Primary key
           //                            Varchar()         NOT NULL      NVARCHAR 
                e.Property(x => x.Marka).HasMaxLength(50).IsRequired().IsUnicode();//Ad alanı 200 karakterden uzun olamaz ve boş geçilemez
                e.Property(x => x.SeriNo).HasMaxLength(50).IsRequired();
                e.HasIndex(x => x.SeriNo).IsUnique();
                e.HasOne(x=> x.Abone).WithMany(x => x.Sayaclar)
                                    .HasForeignKey(x => x.AboneID)
                                    .OnDelete(DeleteBehavior.Restrict);//Abone tablosuyla ilişki kurduk, bir abonenin birden fazla sayacı olabilir, sayac tablosunda aboneid foreign key olarak tanımlanacak, silme işlemi yapıldığında ilişkili sayaclardaki bilgi kalıcak
                e.HasOne(x => x.Tarife).WithMany(x => x.Sayaclar)
                                       .HasForeignKey(x => x.TarifeID)
                                       .OnDelete(DeleteBehavior.Restrict); //WithMany =1 e çok ilişki
            });
            /**********************************************/
            //Tuketim Tablosu
            modelBuilder.Entity<Tuketim>(e =>
            {
                e.ToTable("TUKETIM");//Tablo adı
                e.HasKey(x => x.TuketimID);//Primary key
              //                                 NOT NULL     
                e.Property(x => x.TuketimTarihi).IsRequired();//Ad alanı 200 karakterden uzun olamaz ve boş geçilemez
                e.HasIndex(x => x.TuketimTarihi).IsUnique();
                e.Property(x => x.Endeks).IsRequired();
                e.Property(x => x.Tutar).HasColumnType("decimal(20,2)").IsRequired();
                e.HasOne(x => x.Sayac).WithMany(x => x.Tüketimler)
                                      .HasForeignKey(x => x.SayacID)
                                      .OnDelete(DeleteBehavior.Restrict);
            });
            /**********************************************/
            //Tarife Tablosu
            modelBuilder.Entity<Tarife>(e =>
            {
                e.ToTable("TARIFE");//Tablo adı
                e.HasKey(x => x.TarifeID);//Primary key
                e.Property(x => x.TarifeAdi).HasMaxLength(200).IsRequired().IsUnicode();
            });
            /**********************************************/
            //Ucret Tablosu
            modelBuilder.Entity<Ucret>(e =>
            {
                e.ToTable("UCRET");//Tablo adı
                e.HasKey(x => x.UcretID);//Primary key      
                e.Property(x => x.GecerliTarih).IsRequired();
                e.Property(x => x.BirimFiyat).HasColumnType("decimal(20,2)").IsRequired();
                e.Property(x => x.CTVOrani).HasColumnType("decimal(3,2)").IsRequired();
                e.Property(x => x.ABOrani).HasColumnType("decimal(3,2)").IsRequired();
                e.Property(x => x.KDVOrani).HasColumnType("decimal(3,2)").IsRequired();
                e.HasOne(x => x.Tarife).WithMany(x => x.Ucretler)
                                      .HasForeignKey(x => x.TarifeID)
                                      .OnDelete(DeleteBehavior.Restrict);
            });
            /**********************************************/
            base.OnModelCreating(modelBuilder);//Base sınıfın OnModelCreating metodunu çağırarak, EF Core'un varsayılan davranışlarını da uygulamış oluyoruz.
        }


    }
}
