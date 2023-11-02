using System;
using System.Collections.Generic;

namespace primera_pagina_web.Models;

public partial class Vendedor
{
    public int Id { get; set; }

    public string Usuario { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
