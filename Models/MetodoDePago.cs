using System;
using System.Collections.Generic;

namespace primera_pagina_web.Models;

public partial class MetodoDePago
{
    public int Id { get; set; }

    public ulong Tipo { get; set; }

    public long NoTarjeta { get; set; }

    public string Banco { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
