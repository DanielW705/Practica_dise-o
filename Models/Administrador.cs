using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static primera_pagina_web.Enums.Enums;
namespace primera_pagina_web.Models;

[Table("ADMINISTRADOR")]
public class Administrador : Usuario_
{

    public ROL rol { get; set; }


    public Administrador() : base()
    {

    }
    public Administrador(string _usuario, string _contrasena, ROL _rol = ROL.read) : base(_usuario, _contrasena)
    {
        this.rol = _rol;
    }
}