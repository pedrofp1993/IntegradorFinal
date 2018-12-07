using System;
using System.Collections.Generic;
using ProyectoIntegrador.Modelos;
using System.Data.SqlClient;

namespace ProyectoIntegrador.Datos
{
    public class EventoDatos
    {
        string CadenaConexion = "server=.;database=BD_PROYECTO_ACTUALIZADA3;Integrated Security=true";
        SqlConnection conexion;

        public EventoDatos()
        {
            conexion = new SqlConnection(CadenaConexion);
        }

        //CRUDS DE LOS EVENTOS
        //REGISTRO
        public void RegistroEvento(Evento eventos)
        {
                   conexion.Open();
                   string sqlStatement = "USP_REGISTRAR_EVENTO";
                   SqlCommand comandos = new SqlCommand(sqlStatement, conexion);
                   comandos.CommandType = System.Data.CommandType.StoredProcedure;
                   comandos.Parameters.AddWithValue("@NOMBRE_EVEN", eventos.NOMBRE_EVEN);
                   comandos.Parameters.AddWithValue("@DESCRIPCION", eventos.DESCRIPCION);
                   comandos.Parameters.AddWithValue("@INFO", eventos.INFO);
                   comandos.Parameters.AddWithValue("@FECHA_INIC", eventos.FECHA_INIC);
                   comandos.Parameters.AddWithValue("@FEHA_FIN", eventos.FEHA_FIN);
                   comandos.Parameters.AddWithValue("@CIUDAD", eventos.CIUDAD);
                   comandos.Parameters.AddWithValue("@DIRECCION", eventos.DIRECCION);
                   comandos.Parameters.AddWithValue("@REFRENCIA", eventos.REFRENCIA);
                   comandos.Parameters.AddWithValue("@CANTIDAD", eventos.CANTIDAD);
                   comandos.Parameters.AddWithValue("@PRECIO", eventos.PRECIO);
                   comandos.Parameters.AddWithValue("@ID_USU_TIENDA", eventos.ID_USU_TIENDA);
                   comandos.ExecuteNonQuery();
                   conexion.Close();
               }

        //ACTUALIZAR
        public void ActualizarEvento(Evento evento)
            {
                conexion.Open();
                string sqlStatement = "USP_ACTUALIZACION_EVENTO";
                SqlCommand comandos = new SqlCommand(sqlStatement, conexion);
                comandos.CommandType = System.Data.CommandType.StoredProcedure;
                comandos.Parameters.AddWithValue("@NOMBRE_EVEN", evento.NOMBRE_EVEN);
                comandos.Parameters.AddWithValue("@DESCRIPCION", evento.DESCRIPCION);
                comandos.Parameters.AddWithValue("@DIRECCION", evento.DIRECCION);
                comandos.Parameters.AddWithValue("@INFO", evento.INFO);
                comandos.Parameters.AddWithValue("@FECHA_INIC", evento.FECHA_INIC);
                comandos.Parameters.AddWithValue("@FECHA_FIN", evento.FEHA_FIN);
                comandos.Parameters.AddWithValue("@CIUDAD", evento.CIUDAD);
                comandos.Parameters.AddWithValue("@DIRECCION", evento.DIRECCION);
                comandos.Parameters.AddWithValue("@REFRENCIA", evento.REFRENCIA);
                comandos.Parameters.AddWithValue("@CANTIDAD", evento.CANTIDAD);
                comandos.Parameters.AddWithValue("@PRECIO", evento.PRECIO);
                comandos.ExecuteNonQuery();
                conexion.Close();
            }

        //LISTAR
        public List<ListaEventos> ListarEventos()
            {
                List<ListaEventos> eventos = null;
                string listita = "USP_LISTAR_EVENTO";
                SqlCommand comando = new SqlCommand(listita, conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                conexion.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    eventos = new List<ListaEventos>();
                    while (reader.Read())
                    {
                    ListaEventos eventitos = new ListaEventos();
                        eventitos.COD_EVEN = int.Parse(reader["COD_EVEN"].ToString());
                        eventitos.NOM_EVEN = reader["NOMBRE_EVEN"].ToString();
                        eventitos.FECH_IN = reader["FECH_INC_EVEN"].ToString();
                        eventos.Add(eventitos);
                    }
                }
                conexion.Close();
                return eventos;
            }

        public List<ObtenerEvento> ListarEventosInfo()
        {
            List<ObtenerEvento> eventos = null;
            string listita = "USP_OBTENER_EVENTO";
            SqlCommand comando = new SqlCommand(listita, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                eventos = new List<ObtenerEvento>();
                while (reader.Read())
                {
                    ObtenerEvento eventitos = new ObtenerEvento();
                    eventitos.COD_EVEN = int.Parse(reader["COD_EVEN"].ToString());
                    eventitos.NOM_EVEN = reader["NOMBRE_EVEN"].ToString();
                    eventitos.DESC_EVEN = reader["DESC_EVEN"].ToString();
                    eventos.Add(eventitos);
                }
            }
            conexion.Close();
            return eventos;
        }

        //ELIMINAR
        public void EliminarEventos(int idEvento)
            {
                conexion.Open();
                string sqlStatement = "USP_ELIMINAR_EVENTOS";
                SqlCommand comandos = new SqlCommand(sqlStatement, conexion);
                comandos.CommandType = System.Data.CommandType.StoredProcedure;
                comandos.Parameters.AddWithValue("@COD_EVEN", idEvento);
                comandos.ExecuteNonQuery();
                conexion.Close();
            }


        //COMBOBOXES
        //ESTADO DE LOS EVENTOS
        public List<EstadoEvento> EstadoEventos()
        {
            List<EstadoEvento> estado = null;
            string listita = "USP_LISTAR_ESTADO_EVENTO";
            SqlCommand comando = new SqlCommand(listita, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                estado = new List<EstadoEvento>();
                while (reader.Read())
                {
                    EstadoEvento estados = new EstadoEvento();
                    estados.COD_ESTADO = int.Parse(reader["COD_ESTADO"].ToString());
                    estados.DES_ESTADO = reader["DES_ESTADO"].ToString();
                    estado.Add(estados);
                }
            }
            conexion.Close();
            return estado;
        }

        //MOTIVOS DE LOS EVENTOS
        public List<Motivacion> MotivoEventos()
        {
            List<Motivacion> motivacion = null;
            string listita = "USP_LISTAR_MOTIVO_EVENTO";
            SqlCommand comando = new SqlCommand(listita, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                motivacion = new List<Motivacion>();
                while (reader.Read())
                {
                    Motivacion motivaciones = new Motivacion();
                    motivaciones.COD_MOT = int.Parse(reader["COD_MOT"].ToString());
                    motivaciones.DES_MOT = reader["DES_MOT"].ToString();
                    motivacion.Add(motivaciones);
                }
            }
            conexion.Close();
            return motivacion;
        }

        public List<EventoAprobado> Listarunidadquefaltarobar(int cod)
        {
            List<EventoAprobado> evento = null;
            string listita = "USP_UNIDAD_QUE_FALTA_APROBAR";
            SqlCommand comando = new SqlCommand(listita, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@COD_EVEN", cod);
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                evento = new List<EventoAprobado>();
                while (reader.Read())
                {
                    EventoAprobado eventitos = new EventoAprobado();
                    eventitos.COD_EVEN = int.Parse(reader["COD_EVEN"].ToString());
                    eventitos.NOMBRE_EVEN = reader["NOMBRE_EVEN"].ToString();
                    eventitos.DIRECCION = reader["DIRECCION"].ToString();
                    eventitos.FECH_INC_EVEN = reader["FECH_INC_EVEN"].ToString();
                    eventitos.FECH_FIN_EVEN = reader["FECH_FIN_EVEN"].ToString();
                    eventitos.DESC_EVEN = reader["DESC_EVEN"].ToString();
                    evento.Add(eventitos);
                }
            }
            conexion.Close();
            return evento;
        }
        //LISTAR EVENTOS POR APROBAR
        public List<ListarEventoPorAprobar> ListarEventosAprobar()
        {
            List<ListarEventoPorAprobar> evento = null;
            string listita = "USP_LISTAR_EVENTOS_APROBAR";
            SqlCommand comando = new SqlCommand(listita, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                evento = new List<ListarEventoPorAprobar>();
                while (reader.Read())
                {
                    ListarEventoPorAprobar eventitos = new ListarEventoPorAprobar();
                    eventitos.COD_EVEN = int.Parse(reader["COD_EVEN"].ToString());
                    eventitos.NOM_EVEN = reader["NOMBRE_EVEN"].ToString();
                    eventitos.DIRECCION = reader["DIRECCION"].ToString();
                    eventitos.FECH_INI = reader["FECH_INC_EVEN"].ToString();
                    eventitos.FECH_FIN = reader["FECH_FIN_EVEN"].ToString();
                    eventitos.ID_USU_TIENDA = reader["ID_USU_TIENDA"].ToString();
                    eventitos.RAZON_SOCIAL = reader["RAZON_SOCIAL"].ToString();
                    eventitos.DESC_EVEN = reader["DESC_EVEN"].ToString();
                    evento.Add(eventitos);
                }
            }
            conexion.Close();
            return evento;
        }

        //APROBAR EVENTOS
        public void AprobarEvento(EventoAprobado evento)
        {
            conexion.Open();
            string sqlStatement = "USP_APROBAR_EVENTOSE";
            SqlCommand comandos = new SqlCommand(sqlStatement, conexion);
            comandos.CommandType = System.Data.CommandType.StoredProcedure;
            comandos.Parameters.AddWithValue("@COD_EVEN", evento.COD_EVEN);
            comandos.Parameters.AddWithValue("@NOM_EVEN", evento.NOMBRE_EVEN);
            comandos.Parameters.AddWithValue("@DIRECCION", evento.DIRECCION);
            comandos.Parameters.AddWithValue("@FECH_INI", evento.FECH_INC_EVEN);
            comandos.Parameters.AddWithValue("@FECG_FIN", evento.FECH_FIN_EVEN);
            comandos.Parameters.AddWithValue("@DESC_EVENT", evento.DESC_EVEN);
            comandos.ExecuteNonQuery();
            conexion.Close();
        }

        public List<EventoAprobado> ListarEventosAprobados()
        {
            List<EventoAprobado> evento = null;
            string listita = "USP_APROBAR_EVENTOS";
            SqlCommand comando = new SqlCommand(listita, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                evento = new List<EventoAprobado>();
                while (reader.Read())
                {
                    EventoAprobado eventitos = new EventoAprobado();
                    eventitos.COD_EVEN = int.Parse(reader["COD_EVEN"].ToString());
                    eventitos.NOMBRE_EVEN = reader["NOMBRE_EVEN"].ToString();
                    eventitos.DIRECCION = reader["DIRECCION"].ToString();
                    eventitos.FECH_INC_EVEN = reader["FECH_INC_EVEN"].ToString();
                    eventitos.FECH_FIN_EVEN = reader["FECH_FIN_EVEN"].ToString();
                    eventitos.DESC_EVEN = reader["DESC_EVEN"].ToString();
                    evento.Add(eventitos);
                }
            }
            conexion.Close();
            return evento;
        }

        //DESAPROBAR EVENTOS
        public void DesaprobarEvento(EventoDesaprobado eventomalo)
        {
            conexion.Open();
            string sqlStatement = "USP_DESAPROBAR_EVENTOSes";
            SqlCommand comandos = new SqlCommand(sqlStatement, conexion);
            comandos.CommandType = System.Data.CommandType.StoredProcedure;
            comandos.Parameters.AddWithValue("@COD_EVE", eventomalo.COD_EVEN);
            comandos.Parameters.AddWithValue("@NOM_EVEN", eventomalo.NOMBRE_EVEN);
            comandos.Parameters.AddWithValue("@DIRECCION", eventomalo.DIRECCION);
            comandos.Parameters.AddWithValue("@FECH_INI_EVEN", eventomalo.FECH_INC_EVEN);
            comandos.Parameters.AddWithValue("@FECH_FIN_EVENT", eventomalo.FECH_FIN_EVEN);
            comandos.Parameters.AddWithValue("@DESC_EVENT", eventomalo.DESC_EVEN);
            comandos.Parameters.AddWithValue("@COD_MOT", eventomalo.COD_MONTO);
            comandos.Parameters.AddWithValue("@OBSERVACION", eventomalo.OBSERVACION);
            comandos.ExecuteNonQuery();
            conexion.Close();
        }

        public List<EventoDesaprobado> ListarEventosDesaprobadados()
        {
            List<EventoDesaprobado> evento = null;
            string listita = "USP_DESAPROBAR_EVENTOS";
            SqlCommand comando = new SqlCommand(listita, conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                evento = new List<EventoDesaprobado>();
                while (reader.Read())
                {
                    EventoDesaprobado eventitos = new EventoDesaprobado();
                    eventitos.COD_EVEN = int.Parse(reader["COD_EVEN"].ToString());
                    eventitos.NOMBRE_EVEN = reader["NOMBRE_EVEN"].ToString();
                    eventitos.DIRECCION = reader["DIRECCION"].ToString();
                    eventitos.FECH_INC_EVEN = reader["FECH_INC_EVEN"].ToString();
                    eventitos.FECH_FIN_EVEN = reader["FECH_FIN_EVEN"].ToString();
                    eventitos.DESC_EVEN = reader["DESC_EVEN"].ToString();
                    eventitos.COD_MONTO = int.Parse(reader["COD_MONTO"].ToString());
                    eventitos.DES_MONTO = reader["DES_MONTO"].ToString();
                    eventitos.OBSERVACION = reader["OBSERVACION"].ToString();
                    evento.Add(eventitos);
                }
            }
            conexion.Close();
            return evento;
        }
    }
}


