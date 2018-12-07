using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Modelos
{
    public class EventoDesaprobado
    {
        public int COD_EVEN { get; set; }
        public string NOMBRE_EVEN { get; set; }
        public string DESC_EVEN { get; set; }
        public string FECH_INC_EVEN { get; set; }
        public string FECH_FIN_EVEN { get; set; }
        public string DIRECCION { get; set; }
        public int COD_MONTO { get; set; }
        public string DES_MONTO { get; set; }
        public string OBSERVACION { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(NOMBRE_EVEN))
                throw new Exception("El nombre del evento desaprobado es necesario");
            else if (string.IsNullOrEmpty(DESC_EVEN))
                throw new Exception("La descripcion del evento desaprobado es necesario");
            else if (string.IsNullOrEmpty(FECH_INC_EVEN))
                throw new Exception("La fecha de inicio del evento desaprobado es necesaria");
            else if (string.IsNullOrEmpty(FECH_FIN_EVEN))
                throw new Exception("La fecha de fin del evento desaprobado es necesaria");
            else if (string.IsNullOrEmpty(DIRECCION))
                throw new Exception("La direccion del evento desaprobado es necesaria");
            else if (string.IsNullOrEmpty(OBSERVACION))
                throw new Exception("La observacion del evento desaprobado es necesaria");
        }
    }
}
