using ProyectoIntegrador.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProyectoIntegrador.Negocio;
using Proyecto_Integrador_API.Models;

namespace Proyecto_Integrador_API.Controllers
{
    public class UsuarioController : ApiController
    {
        UsuarioNegocios negocios = new UsuarioNegocios();

        [HttpGet]
        public LoginResponse Login(string id, string pass, string tipoUsuario)
        {
            var response = new LoginResponse();
            response.UsuarioPermitido=negocios.Login(id, pass,tipoUsuario);
            response.UsuarioPerfil = tipoUsuario;
            response.UsuarioNombre = id;

            return response;
        }

        //CRUDS DE USUARIO JUGADOR
        //REGISTRO
        [HttpPost]
        public string RegistroUsuarioJugador(UsuarioJugador usu_jug)
        {
            string mensaje = "";
            mensaje = negocios.registroUsuarioJugador(usu_jug);
            return mensaje;
       }

        //LISTADO
        [HttpGet]
        public List<UsuarioJugador> ListarUsuariosJugadores()
        {
            var lista = negocios.ListarUsuariosJugadores();
            return lista;
        }
        //RETORNE POR ID
        [HttpGet]
        public UsuarioJugador GetUsuarioJugadorById(string id)
        {
            var lista = negocios.ListarUsuariosJugadores();
            UsuarioJugador usuariojugador = lista.FirstOrDefault(x => x.ID_USUARIO_JUG.Equals(id));
            return usuariojugador;
        }

        //ACTUALIZAR
       [HttpPost]
        public string ActualizarUsuariosJugadores(UsuarioJugador usu_jug)
       {
            string mensaje = "";
            mensaje = negocios.actualizarUsuariosJugadores(usu_jug);
            return mensaje;
        }

        //ELIMINAR
        [HttpPost]
        public string EliminarUsuariosJugadores(UsuarioJugador usu_jug)
        {
            string mensaje = "";
            mensaje = negocios.eliminarUsuariosJugadores(usu_jug.ID_USUARIO_JUG);
            return mensaje;
        }



        //CRUDS DEL USUARIO REGULADOR
        //REGISTRO
        [HttpPost]
        public string RegistroUsuarioRegulador(UsuarioRegulador usu_reg)
        {
            string mensaje = "";
            mensaje = negocios.registroUsuarioRegulador(usu_reg);
            return mensaje;
        }

        //LISTADO
        [HttpGet]
        public List<UsuarioRegulador> ListarUsuariosReguladores()
        {
            var lista = negocios.ListarUsuariosReguladores();
            return lista;
        }
        //RETORNE POR ID
        [HttpGet]
        public UsuarioRegulador GetUsuarioReguladorById(int id)
        {
            var lista = negocios.ListarUsuariosReguladores();
            UsuarioRegulador usuarioregulador = lista.FirstOrDefault(x => x.COD_REG == id);
            return usuarioregulador;
        }

        //ACTUALIZAR
        [HttpPost]
        public string ActualizarUsuariosReguladores(UsuarioRegulador usu_reg)
        {
            string mensaje = "";
            mensaje = negocios.actualizarUsuariosReguladores(usu_reg);
            return mensaje;
        }

        //ELIMINAR
        [HttpPost]
        public string EliminarUsuariosReguladores(UsuarioRegulador usu_reg)
        {
            string mensaje = "";
            mensaje = negocios.eliminarUsuariosReguladores(usu_reg.COD_REG);
            return mensaje;
        }


        //CRUDS DEL USUARIO TIENDA
        //REGISTRO
        [HttpPost]
        public string RegistroUsuarioTienda(UsuarioTienda usu_tienda)
        {
            string mensaje = "";
            mensaje = negocios.registroUsuarioTienda(usu_tienda);
            return mensaje;
        }

        //LISTADO
        [HttpGet]
        public List<UsuarioTienda> ListarUsuariosTienda()
        {
            var lista = negocios.ListarUsuariosTienda();
            return lista;
        }
        //RETORNE POR ID
        [HttpGet]
        public UsuarioTienda GetUsuarioTiendaById(string id)
        {
            var lista = negocios.ListarUsuariosTienda();
            UsuarioTienda usuariotienda = lista.FirstOrDefault(x => x.ID_USU_TIENDA.Equals(id));
            return usuariotienda;
        }

        //ACTUALIZAR
        [HttpPost]
        public string ActualizarUsuariosTienda(UsuarioTienda usu_tienda)
        {
            string mensaje = "";
            mensaje = negocios.actualizarUsuariosTienda(usu_tienda);
            return mensaje;
        }

        //ELIMINAR
        [HttpPost]
        public string EliminarUsuariosTienda(UsuarioTienda usu_tienda)
        {
            string mensaje = "";
            mensaje = negocios.eliminarUsuariosTienda(usu_tienda.ID_USU_TIENDA);
            return mensaje;
        }


        //COMBOBOXES
        //CIUDAD
        [HttpGet]
        public List<Ciudad> ListarCiudad()
        {
            var lista = negocios.ListarCiudades();
            return lista;
        }

        //CATEGORIA
        [HttpGet]
        public List<Categoria> ListarCategoria()
        {
            var lista = negocios.ListarCategorias();
            return lista;
        }

        //NIVEL
        [HttpGet]
        public List<Nivel> ListarNivel()
        {
            var lista = negocios.ListarNiveles();
            return lista;
        }

        //TIPO DE USUARIO
        [HttpGet]
        public List<TipoUsuario> ListarTipoUsuario()
        {
            var lista = negocios.ListarTiposUsuarios();
            return lista;
        }
    }
}
