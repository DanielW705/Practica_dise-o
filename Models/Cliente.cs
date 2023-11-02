using System;
using System.Collections.Generic;

namespace primera_pagina_web.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Usuario { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int? IdCompras { get; set; }

    public int? IdMetodoDePago { get; set; }

    public virtual Compra? IdComprasNavigation { get; set; }

    public virtual MetodoDePago? IdMetodoDePagoNavigation { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
