using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Entrenador : PlanDeEjercicio
    {
        public string CodigoMembresiaEntrenador { get; set; }
        public string CantidadDeUsuarios { get; set; }
        public string CantidadHorasDeEntrenamientosPorUsuario { get; set; }

        //*********************************************

        public string AsignarCodigoMembresiaEntrenador()
        {
            return $"{CodigoMembresiaEntrenador}";
        }
        public string AsignarUsuarios()
        {
            return $"{CantidadDeUsuarios}";
        }
        public string AsignarHorario()
        {
            return $"{CantidadHorasDeEntrenamientosPorUsuario}";
        }
    }
}
