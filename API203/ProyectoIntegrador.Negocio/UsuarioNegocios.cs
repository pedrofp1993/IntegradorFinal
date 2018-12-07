using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.Modelos;
using ProyectoIntegrador.Datos;

namespace ProyectoIntegrador.Negocio
{
    public class UsuarioNegocios
    {
        UsuarioDatos usuarioDatos = new UsuarioDatos();
        UsuarioTiendaDatos usuarioTiendaDatos = new UsuarioTiendaDatos();
        UsuarioJugadorDatos usuarioJugadorDatos = new UsuarioJugadorDatos();
        UsuarioReguladorDatos usuarioReguladorDatos = new UsuarioReguladorDatos();

        //LOGIN
        public bool Login(string ID_USUARIO_JUG, string CONTRASEÑA,string tipoPerfil)
        {
            if (tipoPerfil.Equals("TIENDA"))
                return usuarioTiendaDatos.Login(ID_USUARIO_JUG, CONTRASEÑA);
            /*return usuarioTiendaDatos.Login(ID_USUARIO_JUG, CONTRASEÑA);*/
            else if (tipoPerfil.Equals("JUGADOR"))
                return usuarioJugadorDatos.Login(ID_USUARIO_JUG, CONTRASEÑA);
            else if (tipoPerfil.Equals("REGULADOR"))
                return usuarioReguladorDatos.Login(ID_USUARIO_JUG, CONTRASEÑA);
            else
                return false;
        }

        //CRUDS DE USUARIO JUGADOR
        //REGISTRO
        public string registroUsuarioJugador(UsuarioJugador usu_jug)
        {
            string mensaje = "";
            try
            {
                //La validacion de los campos
                usu_jug.Validar();
                usuarioDatos.RegistroUsuarioJugador(usu_jug);
                mensaje = "Usuario Jugador Registrado Correctamente";
            }
            catch (Exception ex)
            {
                mensaje = "No llego a registrar el usuario jugador : " + ex.Message;
            }
            return mensaje;
        }

        //ACTUALIZAR
        public string actualizarUsuariosJugadores(UsuarioJugador usu_jug)
        {
            string mensaje = "";
            try
            {
                if (usu_jug.ID_USUARIO_JUG.Equals(""))
                {
                    mensaje = "El codigo del usuario Jugador no es valido";
                }
                //CODIGO DEL USUARIO JUGADOR VALIDO
                else
                {
                    //listar los usuarios jugadores y filtrar el codigo del usuario jugador
                    var existeUsuarioJugador = usuarioDatos.ListarUsuariosJugadores().
                        Any(x => x.ID_USUARIO_JUG.Equals(usu_jug.ID_USUARIO_JUG));
                    if (existeUsuarioJugador)
                    {
                        //La validacion de los campos
                        usu_jug.Validar();
                        usuarioDatos.actualizarUsuarioJugador(usu_jug);
                        mensaje = "Usuario Jugador Actualizado Correctamente";
                    }
                    else
                        mensaje = "El Usuario Jugador no existe";
                }

            }
            catch (Exception ex)
            {
                mensaje = "No llego a actualizar el usuario jugador : " + ex.Message;
            }
            return mensaje;
        }

        //LISTADO
        public List<UsuarioJugador> ListarUsuariosJugadores()
        {
            return usuarioDatos.ListarUsuariosJugadores();
        }

        //ELIMINAR
        public string eliminarUsuariosJugadores(string idUsuarioJugador)
        {
            string mensaje = "";

            try
            {
                if (idUsuarioJugador.Equals(""))
                {
                    mensaje = "El codigo del usuario Jugador no es valido";
                }
                //CODIGO DEL USUARIO JUGADOR VALIDO
                else
                {
                    //listar los usuarios jugadores y filtrar el codigo del usuario jugador
                    var existeUsuarioJugador = usuarioDatos.ListarUsuariosJugadores().
                        Any(x => x.ID_USUARIO_JUG.Equals(idUsuarioJugador));
                    if (existeUsuarioJugador)
                    {
                        usuarioDatos.EliminarUsuariosJugadores(idUsuarioJugador);
                        mensaje = "Usuario Jugador Eliminado Correctamente";
                    }
                    else
                        mensaje = "El Usuario Jugador no existe";
                }

            }
            catch (Exception ex)
            {
                mensaje = "No llego a eliminar el usuario jugador : " + ex.Message;
            }
            return mensaje;
        }

        //CRUDS DE USUARIO Regulador
        //REGISTRO
        public string registroUsuarioRegulador(UsuarioRegulador usu_reg)
        {
            string mensaje = "";
            try
            {
                //La validacion de los campos
                usu_reg.Validar();
                usuarioDatos.RegistroUsuarioRegulador(usu_reg);
                mensaje = "Usuario Regulador Registrado Correctamente";
            }
            catch (Exception ex)
            {
                mensaje = "No llego a registrar el usuario regulador : " + ex.Message;
            }
            return mensaje;
        }

        //ACTUALIZAR
        public string actualizarUsuariosReguladores(UsuarioRegulador usu_reg)
        {
            string mensaje = "";
            try
            {
                if (usu_reg.COD_REG == 0)
                {
                    mensaje = "El codigo del usuario Regulador no es valido";
                }
                //CODIGO DEL USUARIO REGULADOR VALIDO
                else
                {
                    //listar los usuarios reguladores y filtrar el codigo del usuario regulador
                    var existeUsuarioRegulador = usuarioDatos.ListarUsuariosReguladores().
                        Any(x => x.COD_REG == usu_reg.COD_REG);
                    if (existeUsuarioRegulador)
                    {
                        //La validacion de los campos
                        usu_reg.Validar();
                        usuarioDatos.actualizarUsuarioRegulador(usu_reg);
                        mensaje = "Usuario Regulador Actualizado Correctamente";
                    }
                    else
                        mensaje = "El Usuario Regulador no existe";
                }
            }
            catch (Exception ex)
            {
                mensaje = "No llego a actualizar el usuario regulador : " + ex.Message;
            }
            return mensaje;
        }

        //LISTADO
        public List<UsuarioRegulador> ListarUsuariosReguladores()
        {
            return usuarioDatos.ListarUsuariosReguladores();
        }

        //ELIMINAR
        public string eliminarUsuariosReguladores(int idUsuarioRegulador)
        {
            string mensaje = "";
            try
            {
                if (idUsuarioRegulador == 0)
                {
                    mensaje = "El codigo del usuario Regulador no es valido";
                }
                //CODIGO DEL USUARIO REGULADOR VALIDO
                else
                {
                    //listar los usuarios reguladores y filtrar el codigo del usuario regulador
                    var existeUsuarioRegulador = usuarioDatos.ListarUsuariosReguladores().
                        Any(x => x.COD_REG == idUsuarioRegulador);
                    if (existeUsuarioRegulador)
                    {
                        usuarioDatos.EliminarUsuariosReguladores(idUsuarioRegulador);
                        mensaje = "Usuario Regulador Eliminado Correctamente";
                    }
                    else
                        mensaje = "El Usuario Regulador no existe";
                }

            }
            catch (Exception ex)
            {
                mensaje = "No llego a eliminar el usuario regulador : " + ex.Message;
            }
            return mensaje;
            
        }


        //CRUDS DEL USUARIO Tienda
        //REGISTRO
        public string registroUsuarioTienda(UsuarioTienda usu_tienda)
        {
            string mensaje = "";
            try
            {
                //La validacion de los campos
                usu_tienda.Validar();
                usuarioDatos.RegistroUsuarioTienda(usu_tienda);
                mensaje = "Usuario Tienda Registrado Correctamente";
            }
            catch (Exception ex)
            {
                mensaje = "No llego a registrar el usuario tienda : " + ex.Message;
            }
            return mensaje;
        }

        //ACTUALIZAR
        public string actualizarUsuariosTienda(UsuarioTienda usu_tienda)
        {
            string mensaje = "";
            try
            {
                if (usu_tienda.ID_USU_TIENDA.Equals(""))
                {
                    mensaje = "El codigo del usuario Tienda no es valido";
                }
                //CODIGO DEL USUARIO TIENDA VALIDO
                else
                {
                    //listar los usuarios tienda y filtrar el codigo del usuario tienda
                    var existeUsuarioTienda = usuarioDatos.ListarUsuariosTienda().
                        Any(x => x.ID_USU_TIENDA.Equals(usu_tienda.ID_USU_TIENDA));
                    if (existeUsuarioTienda)
                    {
                        //La validacion de los campos
                        usu_tienda.Validar();
                        usuarioDatos.actualizarUsuarioTienda(usu_tienda);
                        mensaje = "Usuario Tienda Actualizado Correctamente";
                    }
                    else
                        mensaje = "El Usuario Tienda no existe";
                }
            }
            catch (Exception ex)
            {
                mensaje = "No llego a actualizar el usuario tienda : " + ex.Message;
            }
            return mensaje;
        }

        //LISTADO
        public List<UsuarioTienda> ListarUsuariosTienda()
        {
            return usuarioDatos.ListarUsuariosTienda();
        }

        //ELIMINAR
        public string eliminarUsuariosTienda(string idUsuarioTienda)
        {
            string mensaje = "";
            try
            {
                if (idUsuarioTienda.Equals(""))
                {
                    mensaje = "El codigo del usuario Tienda no es valido";
                }
                //CODIGO DEL USUARIO TIENDA VALIDO
                else
                {
                    //listar los usuarios tienda y filtrar el codigo del usuario tienda
                    var existeUsuarioTienda = usuarioDatos.ListarUsuariosTienda().
                        Any(x => x.ID_USU_TIENDA.Equals(idUsuarioTienda));
                    if (existeUsuarioTienda)
                    {
                        usuarioDatos.EliminarUsuariosTienda(idUsuarioTienda);
                        mensaje = "Usuario Tienda Eliminado Correctamente";
                    }
                    else
                        mensaje = "El Usuario Tienda no existe";
                }

            }
            catch (Exception ex)
            {
                mensaje = "No llego a eliminar el usuario tienda : " + ex.Message;
            }
            return mensaje;

        }

        //COMBOBOXES
        //CIUDAD
        public List<Ciudad> ListarCiudades()
        {
            return usuarioDatos.Ciudades();
        }

        //CATEGORIA
        public List<Categoria> ListarCategorias()
        {
            return usuarioDatos.Categorias();
        }

        //NIVEL
        public List<Nivel> ListarNiveles()
        {
            return usuarioDatos.Niveles();
        }

        //TIPO DE USUARIO
        public List<TipoUsuario> ListarTiposUsuarios()
        {
            return usuarioDatos.TipoUsuarios();
        }
    }
}
