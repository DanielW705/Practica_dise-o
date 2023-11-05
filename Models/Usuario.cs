using System.ComponentModel.DataAnnotations;

namespace primera_pagina_web.Models;

public class Usuario
{
    [Required]
    public string _Usuario { get; set; }

    private string _Contrasena { get; set; }

    [Required]
    public string contrasena
    {

        set
        {
            _Contrasena = value;
        }
        get
        {
            return _Contrasena;
        }
    }
}