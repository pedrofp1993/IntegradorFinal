using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoIntegrador.Datos
{
    public class UsuarioReguladorDatos : BaseDatos
    {
        public bool Login(string ID_USUARIO_JUG, string CONTRASEÑA)
        {
            //Usuario usu = null;
            try
            {
                conexion.Open();
                string query = "select count(*) as 'match' from TB_USUARIO_REGULADOR " + "" +
                        " where ID_USU_REGUL = @ID_USU and CONTRA_USU_REGUL = @PASS_USU";
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
                Console.WriteLine(e.Message);
                return false;
            }


        }

    }
}

