using System;
using System.Collections.Generic;

namespace primera_pagina_web.Models;

public partial class Administrador
{
    public int Id { get; set; }

    public string Usuario { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public ulong? Rol { get; set; }
}
