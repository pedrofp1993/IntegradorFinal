using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Modelos
{
    public class EventoAprobado
    {
        public int COD_EVEN { get; set; }
        public string NOMBRE_EVEN { get; set; }
        public string DIRECCION { get; set; }
        public string FECH_INC_EVEN { get; set; }
        public string FECH_FIN_EVEN { get; set; }
        public string DESC_EVEN { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(NOMBRE_EVEN))
                throw new Exception("El nombre del evento es necesario");
            else if (string.IsNullOrEmpty(DESC_EVEN))
                throw new Exception("La descripcion del evento es necesario");
            else if (string.IsNullOrEmpty(FECH_INC_EVEN))
                throw new Exception("La fecha de inicio del evento es necesaria");
            else if (string.IsNullOrEmpty(FECH_FIN_EVEN))
                throw new Exception("La fecha de fin del evento es necesaria");
            else if (string.IsNullOrEmpty(DIRECCION))
                throw new Exception("La direccion del evento es necesaria");
        }
    }

}
