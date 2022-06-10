using Dall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Bll
{
    public class UsuarioService
    {
        private readonly UsuarioRepository repository;
        private readonly ConnectionManager connection;
        public UsuarioService(string conexion)
        {
            connection = new ConnectionManager(conexion);
            repository = new UsuarioRepository(connection);
        }
        //Metodo Guardar
        public string Guardar(Usuario usuario)
        {
            try
            {
                connection.Open();
                repository.Guardar(usuario);
                return "Se a Guardado con Exito";
            }
            catch (Exception e)
            {
                return $"Error de la Alpicacion {e.Message}";
            }
            finally { connection.Close(); }

        }
        //Metodos Response *Buscar*
        public BuscarUsuarioResponse BuscarPorIdentificacion(string identificacion)
        {
            BuscarUsuarioResponse response = new BuscarUsuarioResponse();
            try
            {
                connection.Open();
                response.Usuarios = repository.BuscarPorIdentificacion(identificacion);
                response.Error = false;
                response.Mensaje = (response.Usuarios.Count > 0) ? "Se consultan los datos" : "No hay datos para consultar";
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
        public ConsultarUsuarioRespons Consultar()
        {
            ConsultarUsuarioRespons respons = new ConsultarUsuarioRespons();
            try
            {
                connection.Open();
                respons.Usuarios = repository.Consultar();
                respons.Error = false;
                respons.Mensaje = (respons.Usuarios.Count > 0) ? "Se consultan los datos" : "No hay datos para consultar";
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
    public class ConsultarUsuarioRespons
    {
        public List<Usuario> Usuarios { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
    }

    public class BuscarUsuarioResponse
    {
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public IList<Usuario> Usuarios { get; set; }
    }
}
