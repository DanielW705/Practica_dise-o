using System;
using System.Collections.Generic;

namespace primera_pagina_web.Models;

public partial class Compra
{
    public int Id { get; set; }

    public int? IdProducto { get; set; }

    public int? IdVendedor { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
