using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class PlanDeEjercicioService
    {
        public PlanDeEjercicioRepository PlanDeEjercicioRepository { get; set; }
        public PlanDeEjercicioService()
        {
            PlanDeEjercicioRepository = new PlanDeEjercicioRepository();
        }

        public string Guardar(PlanDeEjercicio planDeEjercicio)
        {
            try
            {
                planDeEjercicio.ImprimirPlanDeEjercicio();
                planDeEjercicio.CalcularHorasSemanales();
                PlanDeEjercicioRepository.Guardar(planDeEjercicio);
                return "Plan de Ejercicio Guardado Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al Guardar:" + e.Message;
            }
        }

        public PlanDeEjercicioConsultaResponse Consultar()
        {
            try
            {
                return new PlanDeEjercicioConsultaResponse(PlanDeEjercicioRepository.Consultar());
            }
            catch (Exception e)
            {
                return new PlanDeEjercicioConsultaResponse("Error al Guardar:" + e.Message);
            }
        }
        public bool FiltroIdentificaicon(string idPlanDeEjercicio)
        {

            try
            {
                return (PlanDeEjercicioRepository.FiltroIdentificaicon(idPlanDeEjercicio));
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public string Modificar(PlanDeEjercicio planDeEjercicio, string idPlanDeEjercicio)
        {
            try
            {
                planDeEjercicio.ImprimirPlanDeEjercicio();
                planDeEjercicio.CalcularHorasSemanales();
                PlanDeEjercicioRepository.Modificar(planDeEjercicio, idPlanDeEjercicio);
                return "Plan de ejercicio Modificado Satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al Modificar:" + e.Message;
            }
        }
        public string Eliminar(string idPlanDeEjercicio)
        {
            try
            {
                PlanDeEjercicioRepository.Eliminar(idPlanDeEjercicio);
                return "Plan de ejercicio Eliminado correctamente";
            }
            catch (Exception)
            {
                return ("Error al Eliminar");
            }
        }
    }
}
