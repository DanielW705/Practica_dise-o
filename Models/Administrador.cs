using System;
using System.Collections.Generic;

namespace primera_pagina_web.Models;

public partial class Administrador : Usuario
{
    public int Id { get; set; }

    public ulong? Rol { get; set; }
}
