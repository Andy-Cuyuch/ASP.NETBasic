using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExamTecnic.Models;

public partial class DbtecnicoContext : DbContext
{
    public DbtecnicoContext()
    {
    }

    public DbtecnicoContext(DbContextOptions<DbtecnicoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Register> Registers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Register>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PK__Register__3717C9824B6CEF98");

            entity.ToTable("Register");

            entity.Property(e => e.IdUser)
                .ValueGeneratedNever()
                .HasColumnName("idUser");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contraseña");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
