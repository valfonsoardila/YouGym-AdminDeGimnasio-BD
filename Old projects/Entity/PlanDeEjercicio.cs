using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PlanDeEjercicio
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public string DiasDeSemana { get; set; }
        public string FaseProgreso { get; set; }
        public string Ciclo { get; set; }
        public string DescripcionPlanEjercicio { get; set; }
        public string AsignarFechaInicio()
        {
            return $"{FechaInicio}";
        }
        public string AsignarFechaFinalizacion()
        {
            return $"{FechaFinalizacion}";
        }
        public string AsignarDiasDeSemana()
        {
            return $"{DiasDeSemana}";
        }
        public string AsignarFaseProgreso()
        {
            return $"{FaseProgreso}";
        }
        public string AsignarCiclo()
        {
            return $"{Ciclo}";
        }
        public string AsignarDescripcionPlanEjercicio()
        {
            return $"{DescripcionPlanEjercicio}";
        }
    }
}
