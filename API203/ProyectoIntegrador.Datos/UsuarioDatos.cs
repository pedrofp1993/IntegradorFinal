using ProyectoIntegrador.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProyectoIntegrador.Datos
{
    public class UsuarioDatos : BaseDatos
    {

        public UsuarioDatos()
        {
            
        }

        //LOGIN
        public bool Login(string ID_USUARIO_JUG, string CONTRASEÑA)
        {
            //Usuario usu = null;
            try
            {
                conexion.Open();
            string query = "select count(*) as 'match' from TB_USUARIO_JUGADOR "+"" +
                    " where ID_USUARIO_JUG = @ID_USU and CONTRASEÑA = @PASS_USU";
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
                    //usu.codigo_usu = int.Parse(lectora["codigo_usu"].ToString());
                    //usu.nombre_usu = lectora["nombre_usu"].ToString();
                    //usu.apellido_usu = lectora["apellido_usu"].ToString();
                    //usu.dni_usu = lectora["dni_usu"].ToString();
                    //usu.correo_usu = lectora["correo_usu"].ToString();
                    //usu.fecha_usu = lectora["fecha_usu"].ToString();
                    //usu.id_usu = lectora["id_usu"].ToString();
                    //usu.password_usu = lectora["password_usu"].ToString();

                }
            }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
            
            
        }

        //CRUDS DE USUARIO JUGADOR
        //REGISTRO
        public void RegistroUsuarioJugador(UsuarioJugador usu_jug)
        {
            conexion.Open();
            string sqlStatement = "USP_REGISTRO_USUARIO_JUGADOR";
            SqlCommand comandos = new SqlCommand(sqlStatement, conexion);
            comandos.CommandType = System.Data.CommandType.StoredProcedure;
            comandos.Parameters.AddWithValue("@NOMBRE_USU_JUGADOR", usu_jug.NOM_JUGADOR);
            comandos.Parameters.AddWithValue("@APELLIDO_USU_JUGADOR", usu_jug.APELLIDO_JUGADOR);
            comandos.Parameters.AddWithValue("@CORREO_USU_JUGADOR", usu_jug.CORREO_ELECTRONICO);
            comandos.Parameters.AddWithValue("@ID_USUARIO_JUGADOR", usu_jug.ID_USUARIO_JUG);
            comandos.Parameters.AddWithValue("@CONTRASEÑA_USU_JUGADOR", usu_jug.CONTRASEÑA);
            comandos.Parameters.AddWithValue("@DIRECCION", usu_jug.DIRECCION);
            comandos.Parameters.AddWithValue("@CIUDAD", usu_jug.COD_CIUDAD);
            comandos.Parameters.AddWithValue("@DNI", usu_jug.DNI);
            comandos.Parameters.AddWithValue("@FECHA_NACI_USU_JUGADOR", usu_jug.FECHA_NACIMIENTO);
            comandos.ExecuteNonQuery();
            conexion.Close();
        }

        //ACTUALIZAR
        public void actualizarUsuarioJugador(UsuarioJugador usu_jug)
        {
            conexion.Open();
            string sqlStatement = "USP_ACTUALIZAR_USUARIO_JUGADOR";
            SqlCommand comandos = new SqlCommand(sqlStatement, conexion);
            comandos.CommandType = System.Data.CommandType.StoredProcedure;
            comandos.Parameters.AddWithValue("@ID_USU_JUG", usu_jug.ID_USUARIO_JUG);
            comandos.Parameters.AddWithValue("@CORREO_USU_JUG", usu_jug.CORREO_ELECTRONICO);
            comandos.Parameters.AddWithValue("@DIRECCION", usu_jug.DIRECCION);
            comandos.Parameters.AddWithValue("@CIUDAD", usu_jug.COD_CIUDAD);
            comandos.ExecuteNonQuery();
            conexion.Close();
        }

        //LISTAR
        public List<UsuarioJugador> ListarUsuariosJugadores()
        {
            List<UsuarioJugador> usuariosjugadores = null;
            string listita = "USP_LISTAR_USUARIO_JUGADOR";
            SqlCommand comando = new SqlCommand(listita, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                usuariosjugadores = new List<UsuarioJugador>();
                while (reader.Read())
                {
                    UsuarioJugador usuariojugador = new UsuarioJugador();
                    usuariojugador.NOM_JUGADOR = reader["NOM_JUGADOR"].ToString();
                    usuariojugador.APELLIDO_JUGADOR = reader["APELLIDO_JUGADOR"].ToString();
                    usuariojugador.CORREO_ELECTRONICO = reader["CORREO_ELECTRONICO"].ToString();
                    usuariojugador.ID_USUARIO_JUG = reader["ID_USUARIO_JUG"].ToString();
                    usuariojugador.CONTRASEÑA = reader["CONTRASEÑA"].ToString();
                    usuariojugador.DIRECCION = reader["DIRECCION"].ToString();
                    usuariojugador.COD_CIUDAD = int.Parse(reader["COD_CIUDAD"].ToString());
                    usuariojugador.NOMBRE = reader["NOMBRE"].ToString();
                    usuariojugador.DNI = reader["DNI"].ToString();
                    usuariojugador.FECHA_NACIMIENTO = reader["FECHA_NACIMIENTO"].ToString();
                    usuariosjugadores.Add(usuariojugador);
                }
            }
            conexion.Close();
            return usuariosjugadores;
        }

        //ELIMINAR
        public void EliminarUsuariosJugadores(string idUsuarioJugador)
        {
            conexion.Open();
            string sqlStatement = "USP_ELIMINAR_USUARIO_JUGADOR";
            SqlCommand comandos = new SqlCommand(sqlStatement, conexion);
            comandos.CommandType = System.Data.CommandType.StoredProcedure;
            comandos.Parameters.AddWithValue("@ID_USUARIO_JUG", idUsuarioJugador);
            comandos.ExecuteNonQuery();
            conexion.Close();
        }


        //CRUDS DE USUARIO REGULADOR
        //REGISTRO
        public void RegistroUsuarioRegulador(UsuarioRegulador usu_reg)
        {
            conexion.Open();
            string sqlStatement = "USP_REGISTRO_USUARIO_REGULADOR";
            SqlCommand comandos = new SqlCommand(sqlStatement, conexion);
            comandos.CommandType = System.Data.CommandType.StoredProcedure;
            comandos.Parameters.AddWithValue("@NOMBRE_USU_REG", usu_reg.NOM_REG);
            comandos.Parameters.AddWithValue("@APELLIDOS_USU_REG", usu_reg.APE_REG);
            comandos.Parameters.AddWithValue("@CORREO_REG", usu_reg.COD_REG);
            comandos.Parameters.AddWithValue("@CATEGORIA_REG", usu_reg.COD_CATEGORIA);
            comandos.Parameters.AddWithValue("@NIVEL_REG", usu_reg.COD_NIVEL);
            comandos.Parameters.AddWithValue("@COD_ID_REG", usu_reg.COD_ID);
            comandos.Parameters.AddWithValue("@ID_USU_REGUL", usu_reg.ID_USU_REGUL);
            comandos.Parameters.AddWithValue("@CONTRA_USU_REGUL", usu_reg.CONTRA_USU_REGUL);
            comandos.ExecuteNonQuery();
            conexion.Close();
        }

        //ACTUALIZAR
        public void actualizarUsuarioRegulador(UsuarioRegulador usu_reg)
        {
            conexion.Open();
            string sqlStatement = "USP_ACTUALIZAR_USUARIO_REGULADOR";
            SqlCommand comandos = new SqlCommand(sqlStatement, conexion);
            comandos.CommandType = System.Data.CommandType.StoredProcedure;
            comandos.Parameters.AddWithValue("@COD_USU_REG", usu_reg.COD_REG);
            comandos.Parameters.AddWithValue("@CATEGORIA", usu_reg.COD_CATEGORIA);
            comandos.Parameters.AddWithValue("@NIVEL", usu_reg.COD_NIVEL);
            comandos.ExecuteNonQuery();
            conexion.Close();
        }

        //LISTAR
        public List<UsuarioRegulador> ListarUsuariosReguladores()
        {
            List<UsuarioRegulador> usuariosreguladores = null;
            string listita = "USP_LISTAR_USUARIO_REGULADOR";
            SqlCommand comando = new SqlCommand(listita, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                usuariosreguladores = new List<UsuarioRegulador>();
                while (reader.Read())
                {
                    UsuarioRegulador usuarioregulador = new UsuarioRegulador();
                    usuarioregulador.COD_REG = int.Parse(reader["COD_REG"].ToString());
                    usuarioregulador.NOM_REG = reader["NOM_REG"].ToString();
                    usuarioregulador.APE_REG = reader["APE_REG"].ToString();
                    usuarioregulador.CORREO = reader["CORREO"].ToString();
                    usuarioregulador.COD_CATEGORIA = int.Parse(reader["CATEGORIA"].ToString());
                    usuarioregulador.NOMBRE_CATEGORIA = reader["NOMBRE_CATEGORIA"].ToString();
                    usuarioregulador.COD_NIVEL = int.Parse(reader["NIVEL"].ToString());
                    usuarioregulador.NOMBRE_NIVEL = reader["NOMBRE_NIVEL"].ToString();
                    usuarioregulador.COD_ID = reader["COD_ID"].ToString();
                    usuariosreguladores.Add(usuarioregulador);
                }
            }
            conexion.Close();
            return usuariosreguladores;
        }

        //ELIMINAR
        public void EliminarUsuariosReguladores(int idUsuarioRegulador)
        {
            conexion.Open();
            string sqlStatement = "USP_ELIMINAR_USUARIO_REGULADOR";
            SqlCommand comandos = new SqlCommand(sqlStatement, conexion);
            comandos.CommandType = System.Data.CommandType.StoredProcedure;
            comandos.Parameters.AddWithValue("@COD_USU_REG", idUsuarioRegulador);
            comandos.ExecuteNonQuery();
            conexion.Close();
        }


        //CRUDS DEL USUARIO TIENDA
        //REGISTRO
        public void RegistroUsuarioTienda(UsuarioTienda usu_tienda)
        {
            conexion.Open();
            string sqlStatement = "USP_REGISTRO_USUARIO_TIENDA";
            SqlCommand comandos = new SqlCommand(sqlStatement, conexion);
            comandos.CommandType = System.Data.CommandType.StoredProcedure;
            comandos.Parameters.AddWithValue("@ID_USU_TIENDA", usu_tienda.ID_USU_TIENDA);
            comandos.Parameters.AddWithValue("@RAZON_SOCIAL", usu_tienda.RAZON_SOCIAL);
            comandos.Parameters.AddWithValue("@REPRESENTANTE", usu_tienda.REP_LEGAL);
            comandos.Parameters.AddWithValue("@CORREO_ELECTRONICO", usu_tienda.CORREO_UST);
            comandos.Parameters.AddWithValue("@DIRECCION", usu_tienda.DIRECCION);
            comandos.Parameters.AddWithValue("@TELEFONO", usu_tienda.TELEFONO);
            comandos.Parameters.AddWithValue("@FECHA_CONSTI", usu_tienda.FECHA_CONSTITU);
            comandos.Parameters.AddWithValue("@RUC", usu_tienda.RUC);
            comandos.Parameters.AddWithValue("@CONTRASEÑA_TIENDA", usu_tienda.CONTRA_USU_TIENDA);
            comandos.ExecuteNonQuery();
            conexion.Close();
        }

        //ACTUALIZAR
        public void actualizarUsuarioTienda(UsuarioTienda usu_tienda)
        {
            conexion.Open();
            string sqlStatement = "USP_ACTUALIZAR_USUARIO_TIENDA";
            SqlCommand comandos = new SqlCommand(sqlStatement, conexion);
            comandos.CommandType = System.Data.CommandType.StoredProcedure;
            comandos.Parameters.AddWithValue("@ID_USU_TIENDA", usu_tienda.ID_USU_TIENDA);
            comandos.Parameters.AddWithValue("@REPRESENTANTE", usu_tienda.REP_LEGAL);
            comandos.Parameters.AddWithValue("@CORREO_ELECTRONICO", usu_tienda.CORREO_UST);
            comandos.Parameters.AddWithValue("@DIRECCION", usu_tienda.DIRECCION);
            comandos.Parameters.AddWithValue("@TELEFONO", usu_tienda.TELEFONO);
            comandos.ExecuteNonQuery();
            conexion.Close();
        }

        //LISTAR
        public List<UsuarioTienda> ListarUsuariosTienda()
        {
            List<UsuarioTienda> usuariostienda = null;
            string listita = "USP_LISTAR_USUARIO_TIENDA";
            SqlCommand comando = new SqlCommand(listita, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                usuariostienda = new List<UsuarioTienda>();
                while (reader.Read())
                {
                    UsuarioTienda usuariotienda = new UsuarioTienda();
                    usuariotienda.ID_USU_TIENDA = reader["ID_USU_TIENDA"].ToString();
                    usuariotienda.RAZON_SOCIAL = reader["RAZON_SOCIAL"].ToString();
                    usuariotienda.REP_LEGAL = reader["REP_LEGAL"].ToString();
                    usuariotienda.CORREO_UST = reader["CORREO_UST"].ToString();
                    usuariotienda.DIRECCION = reader["DIRECCION"].ToString();
                    usuariotienda.TELEFONO = reader["TELEFONO"].ToString();
                    usuariotienda.FECHA_CONSTITU = reader["FECHA_CONSTITU"].ToString();
                    usuariotienda.RUC = reader["RUC"].ToString();
                    usuariotienda.CONTRA_USU_TIENDA = reader["CONTRA_USU_TIENDA"].ToString();
                    usuariostienda.Add(usuariotienda);
                }
            }
            conexion.Close();
            return usuariostienda;
        }

        //ELIMINAR
        public void EliminarUsuariosTienda(string idUsuarioTienda)
        {
            conexion.Open();
            string sqlStatement = "USP_ELIMINAR_USUARIO_TIENDA";
            SqlCommand comandos = new SqlCommand(sqlStatement, conexion);
            comandos.CommandType = System.Data.CommandType.StoredProcedure;
            comandos.Parameters.AddWithValue("@ID_USU_TIENDA", idUsuarioTienda);
            comandos.ExecuteNonQuery();
            conexion.Close();
        }


        //COMBOBOXES
        //CIUDAD
        public List<Ciudad> Ciudades()
        {
            List<Ciudad> ciudad = null;
            string listita = "USP_LISTAR_CIUDAD";
            SqlCommand comando = new SqlCommand(listita, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                ciudad = new List<Ciudad>();
                while (reader.Read())
                {
                    Ciudad ciudades = new Ciudad();
                    ciudades.COD_CIUDAD = int.Parse(reader["COD_CIUDAD"].ToString());
                    ciudades.NOMBRE = reader["NOMBRE"].ToString();
                    ciudad.Add(ciudades);
                }
            }
            conexion.Close();
            return ciudad;
        }

        //CATEGEORIA
        public List<Categoria> Categorias()
        {
            List<Categoria> categoria = null;
            string listita = "USP_LISTAR_CATEGORIA";
            SqlCommand comando = new SqlCommand(listita, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                categoria = new List<Categoria>();
                while (reader.Read())
                {
                    Categoria categorias = new Categoria();
                    categorias.COD_CATEGORIA = int.Parse(reader["COD_CATEGORIA"].ToString());
                    categorias.NOMBRE_CATEGORIA = reader["NOMBRE_CATEGORIA"].ToString();
                    categoria.Add(categorias);
                }
            }
            conexion.Close();
            return categoria;
        }

        //NIVEL
        public List<Nivel> Niveles()
        {
            List<Nivel> nivel = null;
            string listita = "USP_LISTAR_NIVEL";
            SqlCommand comando = new SqlCommand(listita, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                nivel = new List<Nivel>();
                while (reader.Read())
                {
                    Nivel niveles = new Nivel();
                    niveles.COD_NIVEL = int.Parse(reader["COD_NIVEL"].ToString());
                    niveles.NOMBRE_NIVEL = reader["NOMBRE_NIVEL"].ToString();
                    nivel.Add(niveles);
                }
            }
            conexion.Close();
            return nivel;
        }

        //TIPO DE USUARIO
        public List<TipoUsuario> TipoUsuarios()
        {
            List<TipoUsuario> tipousuarios = null;
            string listita = "USP_LISTAR_TIPOUSUARIO";
            SqlCommand comando = new SqlCommand(listita, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                tipousuarios = new List<TipoUsuario>();
                while (reader.Read())
                {
                    TipoUsuario tipejo = new TipoUsuario();
                    tipejo.COD_TUSU = int.Parse(reader["COD_TUSU"].ToString());
                    tipejo.ID_USU = reader["ID_USU"].ToString();
                    tipousuarios.Add(tipejo);
                }
            }
            conexion.Close();
            return tipousuarios;
        }

    }
}
