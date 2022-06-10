using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class EntrenadorService
    {
        public EntrenadorRepository EntrenadorRepository { get; set; }
        public EntrenadorService()
        {
            EntrenadorRepository = new EntrenadorRepository();
        }
        public string Guardar(Entrenador entrenador)
        {
            try
            {
                entrenador.CalcularSalario();
                entrenador.GenerarCodigoEntrenador();
                EntrenadorRepository.Guardar(entrenador);
                return "Entrenador Guardado Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al Guardar:" + e.Message;
            }
        }
        public EntrenadorConsultaResponse Consultar()
        {
            try
            {
                return new EntrenadorConsultaResponse(EntrenadorRepository.Consultar());
            }
            catch (Exception e)
            {
                return new EntrenadorConsultaResponse("Error al Guardar:" + e.Message);
            }
        }
        public bool FiltroIdentificaicon(string identificacion)
        {

            try
            {
                return (EntrenadorRepository.FiltroIdentificaicon(identificacion));
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public string Modificar(Entrenador entrenador, string identificacion)
        {
            try
            {
                entrenador.CalcularSalario();
                entrenador.GenerarCodigoEntrenador();
                EntrenadorRepository.Modificar(entrenador, identificacion);
                return "Entrenador Modificado Satisfactoriamente";
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
                EntrenadorRepository.Eliminar(identificacion);
                return "Entrenador Eliminado correctamente";
            }
            catch (Exception)
            {
                return ("Error al Eliminar");
            }
        }
    }
}
