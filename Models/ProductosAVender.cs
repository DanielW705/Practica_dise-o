using System;
using System.Collections.Generic;

namespace primera_pagina_web.Models;

public partial class ProductosAVender
{
    public int Id { get; set; }

    public int IdVentas { get; set; }

    public int IdProducto { get; set; }

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
