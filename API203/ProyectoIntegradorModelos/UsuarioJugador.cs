using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Modelos
{
    public class UsuarioJugador
    {
        public string ID_USUARIO_JUG { get; set; }
        public string NOM_JUGADOR { get; set; }
        public string APELLIDO_JUGADOR { get; set; }
        public string CORREO_ELECTRONICO { get; set; }
        public string CONTRASEÑA { get; set; }
        public string DIRECCION { get; set; }
        public int COD_CIUDAD { get; set; }
        public string NOMBRE { get; set; }
        public string DNI { get; set; }
        public string FECHA_NACIMIENTO { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(NOM_JUGADOR))
             throw new Exception("El nombre del Usuario Jugador es necesario");
            else if (string.IsNullOrEmpty(APELLIDO_JUGADOR))
                throw new Exception("El apellido del Usuario Jugador es necesario");
            else if (string.IsNullOrEmpty(CORREO_ELECTRONICO))
                throw new Exception("El correo del Usuario Jugador es necesario");
            else if (string.IsNullOrEmpty(ID_USUARIO_JUG))
                throw new Exception("El usuario del Usuario Jugador es necesario");
            else if (string.IsNullOrEmpty(CONTRASEÑA))
                throw new Exception("La contraseña del Usuario Jugador es necesaria");
            else if (string.IsNullOrEmpty(DIRECCION))
                throw new Exception("La direccion del Usuario Jugador es necesaria");
            else if (string.IsNullOrEmpty(NOMBRE))
                throw new Exception("La ciudad del Usuario Jugador es necesaria");
            else if (string.IsNullOrEmpty(DNI))
                throw new Exception("El dni del Usuario Jugador es necesario");
            else if (string.IsNullOrEmpty(FECHA_NACIMIENTO))
                throw new Exception("La fecha de nacimiento del Usuario Jugador es necesario");
            else if (DNI.Length != 8)
                throw new Exception("El DNI del usuario Jugador no debe tener mas de 8 numeros");
        }
    }
}
