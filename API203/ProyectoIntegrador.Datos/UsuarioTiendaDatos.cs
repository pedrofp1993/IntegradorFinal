using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Datos
{
    public class UsuarioTiendaDatos : BaseDatos
    {

        
        public bool Login(string ID_USUARIO_JUG, string CONTRASEÑA)
        {
            //Usuario usu = null;
            try
            {
                conexion.Open();
                string query = "select count(*) as 'match' from TB_USUARIO_TIENDA " + "" +
                        " where id_usu_tienda = @ID_USU and contra_usu_tienda = @PASS_USU";
                SqlCommand comandos = new SqlCommand(query, conexion);
                comandos.Parameters.AddWithValue("@ID_USU", ID_USUARIO_JUG);
                comandos.Parameters.AddWithValue("@PASS_USU", CONTRASEÑA);
                SqlDataReader lectora = comandos.ExecuteReader();
                if (lectora.HasRows)
                {
                    //    usu = new Usuario();
                    while (lectora.Read())
                    {
                        string match = lectora["match"].ToString();
                        if (match.Equals("1"))
                        {
                            return true;
                        }

                    }
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }


        }

    }
}
