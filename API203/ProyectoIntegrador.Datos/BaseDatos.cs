using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Datos
{
    public class BaseDatos
    {


        public string CadenaConexion = "server=.;database=BD_PROYECTO_ACTUALIZADA3;Integrated Security=true";
        public SqlConnection conexion;

        public BaseDatos()
        {
            conexion = new SqlConnection(CadenaConexion);
        }
    }
}
