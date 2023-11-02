using System;
using System.Collections.Generic;

namespace primera_pagina_web.Models;

public partial class Producto
{
    public int Id { get; set; }

    public int IdVendedor { get; set; }

    public string Nombre { get; set; } = null!;

    public int Precio { get; set; }

    public string Caracteristicas { get; set; } = null!;

    public long Serie { get; set; }

    public string Modelo { get; set; } = null!;

    public virtual ICollection<ProductosAEnviar> ProductosAEnviars { get; set; } = new List<ProductosAEnviar>();

    public virtual ICollection<ProductosAVender> ProductosAVenders { get; set; } = new List<ProductosAVender>();
}
