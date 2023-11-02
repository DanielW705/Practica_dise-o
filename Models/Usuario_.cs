using System.ComponentModel.DataAnnotations;

namespace primera_pagina_web.Models;

public abstract class Usuario_
{
    [Key]
    public int ID { get; set; }
    [Required]
    public string Usuario { get; set; }
    protected string Contrasena;
    [Required]
    public string contrasena
    {
        get
        {
            return "";
        }
        set
        {
            Contrasena = value; ;
        }
    }

    public Usuario_()
    {

    }
    public Usuario_(string _Usuario, string _Contrasena)
    {
        this.Usuario = _Usuario;
        this.Contrasena = _Contrasena;
    }

    bool IsPassword(string pswrd) => this.Contrasena == pswrd;

}