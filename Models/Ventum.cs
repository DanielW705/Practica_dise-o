using System;
using System.Collections.Generic;

namespace primera_pagina_web.Models;

public partial class Ventum
{
    public int Id { get; set; }

    public int IdVendedor { get; set; }

    public int IdComprador { get; set; }

    public int IdProductos { get; set; }

    public long Total { get; set; }

    public virtual Compra IdCompradorNavigation { get; set; } = null!;

    public virtual Vendedor IdVendedorNavigation { get; set; } = null!;
}
