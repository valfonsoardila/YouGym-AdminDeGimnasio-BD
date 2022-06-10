using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class ClienteService
    {
        private readonly ClienteRepository ClienteRepository;
        public ClienteService()
        {
            ClienteRepository = new ClienteRepository();
        }

        public string Guardar(Cliente cliente)
        {
            try
            {
                cliente.CalcularPagoMensual();
                cliente.GenerarCodigoCliente();
                cliente.CalcularTiempoDeEntrenamiento();
                ClienteRepository.Guardar(cliente);
                return "Cliente Guardado Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al Guardar:" + e.Message;
            }
        }

        public ClienteConsultaResponse Consultar()
        {
            try
            {
                return new ClienteConsultaResponse(ClienteRepository.Consultar());
            }
            catch (Exception e)
            {
                return new ClienteConsultaResponse("Error al Guardar:" + e.Message);
            }
        }
        public bool FiltroIdentificaicon(string identificacion)
        {

            try
            {
                return (ClienteRepository.FiltroIdentificaicon(identificacion));
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public string Modificar(Cliente cliente, string identificacion)
        {
            try
            {
                cliente.CalcularPagoMensual();
                cliente.GenerarCodigoCliente();
                cliente.CalcularTiempoDeEntrenamiento();
                ClienteRepository.Modificar(cliente, identificacion);
                return "Cliente Modificado Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al Modificar:" + e.Message;
            }
        }
        public string Eliminar(string identificacion)
        {
            try
            {
               ClienteRepository.Eliminar(identificacion);
                return  "Cliente Eliminado";
            }
            catch (Exception)
            {
                return ("Error al Eliminar");
            }
        }
    }
}
