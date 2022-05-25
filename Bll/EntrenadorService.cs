using System;
using Dall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Bll
{
    public class EntrenadorService
    {
        private readonly EntrenadorRepository repository;
        private readonly ConnectionManager connection;
        public EntrenadorService(string conexion)
        {
            connection = new ConnectionManager(conexion);
            repository = new EntrenadorRepository(connection);
        }
        //Metodo Guardar
        public string Guardar(Entrenador entrenador)
        {
            try
            {
                connection.Open();
                repository.Guardar(entrenador);
                return "Se a Guardado con Exito";
            }
            catch (Exception e)
            {
                return $"Error de la Alpicacion {e.Message}";
            }
            finally { connection.Close(); }

        }
        //Metodos Response *Buscar*
        public BuscarEntrenadorResponse BuscarPorIdentificacion(string identificacion)
        {
            BuscarEntrenadorResponse response = new BuscarEntrenadorResponse();
            try
            {
                connection.Open();
                response.Entrenadores = repository.BuscarPorIdentificacion(identificacion);
                response.Error = false;
                response.Mensaje = (response.Entrenadores.Count > 0) ? "Se consultan los datos" : "No hay datos para consultar";
                return response;
            }
            catch (Exception e)
            {
                response.Mensaje = $"Error de la Aplicacion {e.Message}";
                response.Error = true;
                return response;
            }
            finally { connection.Close(); }
        }
        //Metodo Response *Consultar*
        public ConsultarEntrenadorRespons Consultar()
        {
            ConsultarEntrenadorRespons respons = new ConsultarEntrenadorRespons();
            try
            {
                connection.Open();
                respons.Entrenadores = repository.Consultar();
                respons.Error = false;
                respons.Mensaje = (respons.Entrenadores.Count > 0) ? "Se consultan los datos" : "No hay datos para consultar";
                return respons;
            }
            catch (Exception e)
            {
                respons.Error = true;
                respons.Mensaje = $"Error de la Aplicacion: {e.Message}";
                return respons;
            }
            finally { connection.Close(); }
        }
    }
    //Creacion de clases *Response*
    public class ConsultarEntrenadorRespons
    {
        public List<Entrenador> Entrenadores { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
    }

    public class BuscarEntrenadorResponse
    {
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public IList<Entrenador> Entrenadores { get; set; }
    }
}
