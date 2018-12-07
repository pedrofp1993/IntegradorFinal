using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Modelos
{
    public class Evento
    {
        public int COD_EVEN { get; set; }
        public string NOMBRE_EVEN { get; set; }
        public string DESCRIPCION { get; set; }
        public string INFO { get; set; }
        public string FECHA_INIC { get; set; }
        public string FEHA_FIN { get; set; }
        public string CIUDAD { get; set; }
        public string DIRECCION { get; set; }
        public string REFRENCIA { get; set; }
        public int CANTIDAD { get; set; }
        public double PRECIO { get; set; }
        public string ID_USU_TIENDA { get; set; }
        public void Validar()
        {
            if (string.IsNullOrEmpty(NOMBRE_EVEN))
                throw new Exception("El nombre del evento es necesario");
            else if (string.IsNullOrEmpty(DESCRIPCION))
                throw new Exception("La descripcion del evento es necesario");
            else if (string.IsNullOrEmpty(INFO))
                throw new Exception("La informacion del evento es necesario");
            else if (string.IsNullOrEmpty(FECHA_INIC))
                throw new Exception("La fecha de inicio del evento es necesaria");
            else if (string.IsNullOrEmpty(FEHA_FIN))
                throw new Exception("La fecha de fin del evento es necesaria");
            else if (string.IsNullOrEmpty(CIUDAD))
                throw new Exception("La ciudad del evento es necesaria");
            else if (string.IsNullOrEmpty(DIRECCION))
                throw new Exception("La direccion del evento es necesaria");
            else if (string.IsNullOrEmpty(REFRENCIA))
                throw new Exception("La referencia del evento es necesaria");
        }
    }
}
