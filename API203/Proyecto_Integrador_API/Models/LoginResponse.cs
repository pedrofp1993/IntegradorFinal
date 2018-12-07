using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Integrador_API.Models
{
    public class LoginResponse
    {
        public bool UsuarioPermitido { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioPerfil{ get; set; }
    }
}