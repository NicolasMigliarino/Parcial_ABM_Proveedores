using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parcial_ABM_Proveedores.Models;

public partial class ProveedoresContext : DbContext
{
    public ProveedoresContext()
    {
    }

    public ProveedoresContext(DbContextOptions<ProveedoresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    if (optionsBuilder.IsConfigured) { 
    }
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        //        => optionsBuilder.UseSqlServer("server=ITL4612\\SQLEXPRESS;database=Proveedores;integrated security=true;TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proveedo__3214EC075D98E8B3");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Ciudad).HasMaxLength(50);
            entity.Property(e => e.CodigoPostal).HasMaxLength(10);
            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Pais).HasMaxLength(50);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
