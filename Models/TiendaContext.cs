using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace primera_pagina_web.Models;

public partial class TiendaContext : DbContext
{
    public TiendaContext(DbContextOptions<TiendaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrador> Administradors { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<MetodoDePago> MetodoDePagos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductosAEnviar> ProductosAEnviars { get; set; }

    public virtual DbSet<ProductosAVender> ProductosAVenders { get; set; }

    public virtual DbSet<Vendedor> Vendedors { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrador>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ADMINISTRADOR");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(8)
                .HasColumnName("CONTRASENA");
            entity.Property(e => e.Rol)
                .HasColumnType("bit(3)")
                .HasColumnName("ROL");
            entity.Property(e => e.Usuario)
                .HasMaxLength(30)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("CLIENTE");

            entity.HasIndex(e => e.IdCompras, "FK_COMPRAS");

            entity.HasIndex(e => e.IdMetodoDePago, "FK_METODO_PAGO");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(8)
                .HasColumnName("CONTRASENA");
            entity.Property(e => e.Correo)
                .HasMaxLength(30)
                .HasColumnName("CORREO");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.IdCompras).HasColumnName("ID_COMPRAS");
            entity.Property(e => e.IdMetodoDePago).HasColumnName("ID_METODO_DE_PAGO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(15)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Usuario)
                .HasMaxLength(30)
                .HasColumnName("USUARIO");

            entity.HasOne(d => d.IdComprasNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdCompras)
                .HasConstraintName("FK_COMPRAS");

            entity.HasOne(d => d.IdMetodoDePagoNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdMetodoDePago)
                .HasConstraintName("FK_METODO_PAGO");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("COMPRAS");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");
            entity.Property(e => e.IdVendedor).HasColumnName("ID_VENDEDOR");
        });

        modelBuilder.Entity<MetodoDePago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("METODO_DE_PAGO");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Banco)
                .HasMaxLength(30)
                .HasColumnName("BANCO");
            entity.Property(e => e.NoTarjeta).HasColumnName("NO_TARJETA");
            entity.Property(e => e.Tipo)
                .HasColumnType("bit(3)")
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("PEDIDO");

            entity.HasIndex(e => e.IdComprador, "FK_COMPRADOR");

            entity.HasIndex(e => e.IdProductosEnviar, "FK_PRODUCTO_A_ENVIAR");

            entity.HasIndex(e => e.IdVendedor, "FK_VENDEDOR");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.DireccionEnvio).HasColumnName("DIRECCION_ENVIO");
            entity.Property(e => e.Estatus)
                .HasColumnType("bit(3)")
                .HasColumnName("ESTATUS");
            entity.Property(e => e.IdComprador).HasColumnName("ID_COMPRADOR");
            entity.Property(e => e.IdProductosEnviar).HasColumnName("ID_PRODUCTOS_ENVIAR");
            entity.Property(e => e.IdVendedor).HasColumnName("ID_VENDEDOR");
            entity.Property(e => e.Total).HasColumnName("TOTAL");

            entity.HasOne(d => d.IdCompradorNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdComprador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMPRADOR");

            entity.HasOne(d => d.IdVendedorNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdVendedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENDEDOR");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("PRODUCTOS");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Caracteristicas).HasColumnName("CARACTERISTICAS");
            entity.Property(e => e.IdVendedor).HasColumnName("ID_VENDEDOR");
            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .HasColumnName("MODELO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Picture)
                .HasColumnType("blob")
                .HasColumnName("PICTURE");
            entity.Property(e => e.Precio).HasColumnName("PRECIO");
            entity.Property(e => e.Serie).HasColumnName("SERIE");
        });

        modelBuilder.Entity<ProductosAEnviar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("PRODUCTOS_A_ENVIAR");

            entity.HasIndex(e => e.IdProducto, "FK_PRODUCTO_ENVIAR");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.HasIndex(e => e.IdProductoAEnviar, "PRODUCTO_ENVIAR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");
            entity.Property(e => e.IdProductoAEnviar).HasColumnName("ID_PRODUCTO_A_ENVIAR");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ProductosAEnviars)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCTO_ENVIAR");
        });

        modelBuilder.Entity<ProductosAVender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("PRODUCTOS_A_VENDER");

            entity.HasIndex(e => e.IdProducto, "FK_PRODUCTO_VENDER");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.HasIndex(e => e.IdVentas, "VENTAS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdProducto).HasColumnName("ID_PRODUCTO");
            entity.Property(e => e.IdVentas).HasColumnName("ID_VENTAS");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ProductosAVenders)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCTO_VENDER");
        });

        modelBuilder.Entity<Vendedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("VENDEDOR");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(8)
                .HasColumnName("CONTRASENA");
            entity.Property(e => e.Correo)
                .HasMaxLength(30)
                .HasColumnName("CORREO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Usuario)
                .HasMaxLength(30)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("VENTA");

            entity.HasIndex(e => e.IdVendedor, "FK_VENDEDOR_PRODUCTO");

            entity.HasIndex(e => e.IdComprador, "FK_VENTAS");

            entity.HasIndex(e => e.IdProductos, "FK_VENTA_PRODUCTO");

            entity.HasIndex(e => e.Id, "ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdComprador).HasColumnName("ID_COMPRADOR");
            entity.Property(e => e.IdProductos).HasColumnName("ID_PRODUCTOS");
            entity.Property(e => e.IdVendedor).HasColumnName("ID_VENDEDOR");
            entity.Property(e => e.Total).HasColumnName("TOTAL");

            entity.HasOne(d => d.IdCompradorNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdComprador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENTAS");

            entity.HasOne(d => d.IdVendedorNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdVendedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENDEDOR_PRODUCTO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
