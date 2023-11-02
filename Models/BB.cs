using Microsoft.EntityFrameworkCore;
namespace primera_pagina_web.Models
{
    public class BB : DbContext
    {

        public virtual DbSet<Administrador> administradores { get; set; }

        public BB(DbContextOptions<BB> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Administrador>(
            entity =>
            {
                entity.HasKey(a => a.ID);
                entity.Property(a => a.Usuario).HasColumnName("USUARIO");
                entity.Property(a => a.contrasena).HasColumnName("CONTRASENA");
                entity.Property(a => a.rol).HasColumnName("ROL");
                entity.ToTable("ADMINISTRADOR");
            });
        }
    }
}