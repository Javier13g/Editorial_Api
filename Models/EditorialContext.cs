using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Editorial_Api.Models
{
    public partial class EditorialContext : DbContext
    {
        public EditorialContext()
        {
        }

        public EditorialContext(DbContextOptions<EditorialContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Editorial> Editorials { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Editorial>(entity =>
            {
                entity.HasKey(e => e.CodEditorial)
                    .HasName("PK__Editoria__0EE10EE182228EBB");

                entity.ToTable("Editorial");

                entity.Property(e => e.CodEditorial).HasColumnName("Cod_Editorial");

                entity.Property(e => e.LatitudUbicacion)
                    .HasColumnType("decimal(8, 6)")
                    .HasColumnName("Latitud_Ubicacion");

                entity.Property(e => e.LongitudUbicacion)
                    .HasColumnType("decimal(9, 6)")
                    .HasColumnName("Longitud_Ubicacion");

                entity.Property(e => e.NombreEditorial)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Editorial");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
