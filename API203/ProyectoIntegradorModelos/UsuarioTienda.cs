using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Modelos
{
    public class UsuarioTienda
    {
        
        public string RAZON_SOCIAL { get; set; }
        public string REP_LEGAL { get; set; }
        public string CORREO_UST { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string FECHA_CONSTITU { get; set; }
        public string RUC { get; set; }
        public string ID_USU_TIENDA { get; set; }
        public string CONTRA_USU_TIENDA { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(RAZON_SOCIAL))
                throw new Exception("La razon social del Usuario Tienda es necesario");
            else if (string.IsNullOrEmpty(REP_LEGAL))
                throw new Exception("El representante legal del Usuario Tienda es necesario");
            else if (string.IsNullOrEmpty(CORREO_UST))
                throw new Exception("El correo del Usuario Tienda es necesario");
            else if (string.IsNullOrEmpty(DIRECCION))
                throw new Exception("La direccion del Usuario Tienda es necesario");
            else if (string.IsNullOrEmpty(TELEFONO))
                throw new Exception("El telefono del Usuario Tienda es necesaria");
            else if (string.IsNullOrEmpty(DIRECCION))
                throw new Exception("La direccion del Usuario Tienda es necesaria");
            else if (string.IsNullOrEmpty(FECHA_CONSTITU))
                throw new Exception("La Fecha de constitucion del Usuario Tienda es necesaria");
            else if (string.IsNullOrEmpty(RUC))
                throw new Exception("El ruc del Usuario Tienda es necesario");
            else if (string.IsNullOrEmpty(ID_USU_TIENDA))
                throw new Exception("El usuario del Usuario Tienda es necesario");
            else if (string.IsNullOrEmpty(CONTRA_USU_TIENDA))
                throw new Exception("La contraseña del Usuario Tienda es necesario");
            else if (RUC.Length != 8)
                throw new Exception("El RUC del usuario Tienda no debe tener mas de 8 numeros");
        }
    }
}
