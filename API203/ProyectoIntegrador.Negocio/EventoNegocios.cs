﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.Datos;
using ProyectoIntegrador.Modelos;

namespace ProyectoIntegrador.Negocio
{
    public class EventoNegocios
    {
        EventoDatos datasos = new EventoDatos();

        //CRUDS DE EVENTOS
        //REGISTRO
        public string registroEventos(Evento evento)
        {
            string mensaje = "";
            try
            {
                //La validacion de los campos
                evento.Validar();
                datasos.RegistroEvento(evento);
                mensaje = "Evento Registrado Correctamente";
            }
            catch (Exception ex)
            {
                mensaje = "No llego a registrar el evento : " + ex.Message;
            }
            return mensaje;
        }

        //ACTUALIZAR
        public string actualizarEventos(Evento evento)
        {
            string mensaje = "";
            try
            {
                if (evento.COD_EVEN == 0)
                {
                    mensaje = "El codigo del evento no es valido";
                }
                //CODIGO DEL EVENTO VALIDO
                else
                {
                    //listar los eventos y filtrar el codigo del evento
                    var existeEvento = datasos.ListarEventos().
                        Any(x => x.COD_EVEN == evento.COD_EVEN);
                    if (existeEvento)
                    {
                        //La validacion de los campos
                        evento.Validar();
                        datasos.ActualizarEvento(evento);
                        mensaje = "Evento Actualizado Correctamente";
                    }
                    else
                        mensaje = "El Evento no existe";
                }

            }
            catch (Exception ex)
            {
                mensaje = "No llego a actualizar el evento : " + ex.Message;
            }
            return mensaje;
        }

        //LISTADO
        public List<ListaEventos> ListarEventos()
        {
            return datasos.ListarEventos();
        }

        public List<ObtenerEvento> ListarEventosInformacion()
        {
            return datasos.ListarEventosInfo();
        }

        //ELIMINAR
        public string eliminarEventos(int idEvento)
        {
            string mensaje = "";

            try
            {
                if (idEvento == 0)
                {
                    mensaje = "El codigo del evento no es valido";
                }
                //CODIGO DEL EVENTO VALIDO
                else
                {
                    //listar los eventos y filtrar el codigo del evento
                    var existeEvento = datasos.ListarEventos().
                        Any(x => x.COD_EVEN == idEvento);
                    if (existeEvento)
                    {
                        datasos.EliminarEventos(idEvento);
                        mensaje = "Evento Eliminado Correctamente";
                    }
                    else
                        mensaje = "El Evento no existe";
                }

            }
            catch (Exception ex)
            {
                mensaje = "No llego a eliminar el evento : " + ex.Message;
            }
            return mensaje;
        }

        //COMBOBOXES
        //ESTADO DEL EVENTO
        public List<EstadoEvento> ListarEstados()
        {
            return datasos.EstadoEventos();
        }

        //MOTIVACION DEL EVENTO
        public List<Motivacion> ListarMotivacion()
        {
            return datasos.MotivoEventos();
        }

        //LISTAR EVENTOS POR APROBAR
        public List<ListarEventoPorAprobar> ListarEventosPorAprobar()
        {
            return datasos.ListarEventosAprobar();
        }

        //APROBAR EVENTOS
        public List<EventoAprobado> ListarEventosAprobados()
        {
            return datasos.ListarEventosAprobados();
        }
        public List<EventoAprobado> Listarunidadquefaltarobar(int cod)
        {
            return datasos.Listarunidadquefaltarobar(cod);
        }
        public string EventosAprobados(EventoAprobado evento)
        {
            string mensaje = "";
            try
            {
                if (evento.COD_EVEN == 0)
                {
                    mensaje = "El codigo del evento no es valido";
                }
                //CODIGO DEL EVENTO VALIDO
                else
                {
                    //listar los eventos aprobados y filtrar el codigo del evento
                    var existeEvento = datasos.ListarEventosAprobados().
                        Any(x => x.COD_EVEN == evento.COD_EVEN);
                    if (existeEvento)
                    {
                        //La validacion de los campos
                        evento.Validar();
                        datasos.AprobarEvento(evento);
                        mensaje = "Evento Aprobado Correctamente";
                    }
                    else
                        mensaje = "El Evento Aprobado no existe";
                }

            }
            catch (Exception ex)
            {
                mensaje = "No llego a Aprobar el evento : " + ex.Message;
            }
            return mensaje;
        }

        //DESAPROBAR EVENTOS
        public List<EventoDesaprobado> ListarEventosDesaprobados()
        {
            return datasos.ListarEventosDesaprobadados();
        }

        public string EventosDesaprobados(EventoDesaprobado eventomalisiomo)
        {
            string mensaje = "";
            try
            {
                if (eventomalisiomo.COD_EVEN == 0)
                {
                    mensaje = "El codigo del evento no es valido";
                }
                //CODIGO DEL EVENTO VALIDO
                else
                {
                    //listar los eventos desaprobados y filtrar el codigo del evento
                    var existeEvento = datasos.ListarEventosDesaprobadados().
                        Any(x => x.COD_EVEN == eventomalisiomo.COD_EVEN);
                    if (existeEvento)
                    {
                        //La validacion de los campos
                        eventomalisiomo.Validar();
                        datasos.DesaprobarEvento(eventomalisiomo);
                        mensaje = "Evento Desaprobado Correctamente";
                    }
                    else
                        mensaje = "El Evento Desaprobado no existe";
                }

            }
            catch (Exception ex)
            {
                mensaje = "No llego a actualizar el evento : " + ex.Message;
            }
            return mensaje;
        }
    }
}
