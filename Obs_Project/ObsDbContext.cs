using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Obs_Project
{
    internal class ObsDbContext:DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<OgrenciDers> OgrenciDers { get; set; }
        public DbSet<Dersler> Ders { get; set; }
        public DbSet<Siniflar> Siniflar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.\MS2024;Initial Catalog=OBS_Project_Table;Integrated Security = true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>()
                .HasOne(o => o.Siniflar)
                .WithMany(s => s.Ogrenciler)
                .HasForeignKey(o => o.SinifID);

            modelBuilder.Entity<OgrenciDers>()
               .HasKey(od => new { od.OgrenciID, od.DersID });

            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ogrenciler)
                .WithMany(o => o.OgrenciDers)
                .HasForeignKey(od => od.OgrenciID);

            modelBuilder.Entity<OgrenciDers>()
               .HasOne(od => od.Dersler)
               .WithMany(d => d.OgrenciDers)
               .HasForeignKey(od => od.DersID);
        }
    }
}
