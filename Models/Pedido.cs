using System;
using System.Collections.Generic;

namespace primera_pagina_web.Models;

public partial class Pedido
{
    public int Id { get; set; }

    public string DireccionEnvio { get; set; } = null!;

    public int IdComprador { get; set; }

    public int IdVendedor { get; set; }

    public ulong Estatus { get; set; }

    public int IdProductosEnviar { get; set; }

    public int Cantidad { get; set; }

    public int Total { get; set; }

    public virtual Cliente IdCompradorNavigation { get; set; } = null!;

    public virtual Vendedor IdVendedorNavigation { get; set; } = null!;
}
