using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario:PlanDeEjercicio
    {
        public string HoraDeEntrenamiento { get; set; }
        public DateTime FechaDeIngresoGym { get; set; }
        public DateTime FechaDeSalidaGym { get; set; }
        public string CodigoMembresiaUsuario { get; set; }
        //**********************************Metodos****************************************
        public string AsignarHorario()
        {
            return $"{HoraDeEntrenamiento}";
        }
        public string AsignarCodigoMembresiaUsuario()
        {
            return $"{CodigoMembresiaUsuario}";
        }
        public string AsignarFechaDeIngresoGym()
        {
            FechaDeIngresoGym = FechaInicio;
            return $"{CodigoMembresiaUsuario}";
        }
        public string AsignarFechaDeSalidaGym()
        {
            FechaDeSalidaGym = FechaFinalizacion;
            return $"{CodigoMembresiaUsuario}";
        }
    }
}
