using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Modelos
{
    public class UsuarioRegulador
    {
        public int COD_REG { get; set; }
        public string NOM_REG { get; set; }
        public string APE_REG { get; set; }
        public string CORREO { get; set; }
        public int COD_CATEGORIA { get; set; }
        public string NOMBRE_CATEGORIA { get; set; }
        public int COD_NIVEL { get; set; }
        public string NOMBRE_NIVEL { get; set; }
        public string COD_ID { get; set; }
        public string ID_USU_REGUL { get; set; }
        public string CONTRA_USU_REGUL { get; set; }
        public void Validar()
        {
            if (string.IsNullOrEmpty(NOM_REG))
                throw new Exception("El nombre del Usuario Regulador es necesario");
            else if (string.IsNullOrEmpty(APE_REG))
                throw new Exception("El apellido del Usuario Regulador es necesario");
            else if (string.IsNullOrEmpty(CORREO))
                throw new Exception("El correo del Usuario Regulador es necesario");
           /* else if (int.TryParse(string.IsNullOrEmpty(CATEGORIA)))
                throw new Exception("La categoria del Usuario Regulador es necesaria");
            else if (string.IsNullOrEmpty(NIVEL))
                throw new Exception("El nivel del Usuario Regulador es necesario");*/
            else if (string.IsNullOrEmpty(COD_ID))
                throw new Exception("El codigo de verificacion del Usuario Regulador es necesario");
        }
    }
}
