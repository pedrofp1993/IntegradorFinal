using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProyectoIntegrador.Negocio;
using ProyectoIntegrador.Modelos;

namespace Proyecto_Integrador_API.Controllers
{
    public class EventoController : ApiController
    {
        EventoNegocios negocios = new EventoNegocios();
        //CRUDS DE EVENTOS
        //REGISTRO
        [HttpPost]
        public string RegistroEvento(Evento evento)
        {
            string mensaje = "";
            mensaje = negocios.registroEventos(evento);
            return mensaje;
        }

        //LISTADO
        [HttpGet]
        public List<ListaEventos> ListarEventos()
        {
            var lista = negocios.ListarEventos();
            return lista;
        }
        //RETORNE POR ID
        [HttpGet]
        public ObtenerEvento GetEventoById(int id)
        {
            var lista = negocios.ListarEventosInformacion();
            ObtenerEvento eventos = lista.FirstOrDefault(x => x.COD_EVEN == id);
            return eventos;
        }

        //ACTUALIZAR
        [HttpPost]
        public string ActualizarEvento(Evento evento)
        {
            string mensaje = "";
            mensaje = negocios.actualizarEventos(evento);
            return mensaje;
        }

        //ELIMINAR
        [HttpPost]
        public string EliminarEvento(Evento evento)
        {
            string mensaje = "";
            mensaje = negocios.eliminarEventos(evento.COD_EVEN);
            return mensaje;
        }


        //LISTAR EVENTOS POR APROBAR
        [HttpGet]
        public List<ListarEventoPorAprobar> ListarEventosPorAprobar()
        {
            var lista = negocios.ListarEventosPorAprobar();
            return lista;
        }

        //APROBAR EVENTOS
        [HttpGet]
        public List<EventoAprobado> ListarEventosAprobados(int id)
        {
            var lista = negocios.ListarEventosAprobados();
            EventoAprobado eventos = lista.FirstOrDefault(x => x.COD_EVEN == id);
            return lista;
        }

        [HttpPost]
        public string EventoAprobado(EventoAprobado evento)
        {
            string mensaje = "";
            mensaje = negocios.EventosAprobados(evento);
            return mensaje;
        }

        //DESAPROBAR EVENTOS
        [HttpGet]
        public List<EventoDesaprobado> ListarEventosDesaprobados(int id)
        {
            var lista = negocios.ListarEventosDesaprobados();
            EventoDesaprobado eventofeo = lista.FirstOrDefault(x => x.COD_EVEN == id);
            return lista;
        }

        [HttpPost]
        public string ActualizarDesaprobado(EventoDesaprobado eventomalo)
        {
            string mensaje = "";
            mensaje = negocios.EventosDesaprobados(eventomalo);
            return mensaje;
        }

        //COMBOBOXES
        //ESTADO DEL EVENTO
        [HttpGet]
        public List<EstadoEvento> ListarEstadosEventos()
        {
            var lista = negocios.ListarEstados();
            return lista;
        }

        //MOTIVACION DEL EVENTO
        [HttpGet]
        public List<Motivacion> ListarMotivosEvento()
        {
            var lista = negocios.ListarMotivacion();
            return lista;
        }

        [HttpGet]
        public List<EventoAprobado> ListarEventosquefaltarobar(int cod)
        {
            var lista = negocios.Listarunidadquefaltarobar(cod);
            return lista;
        }
    }
}
