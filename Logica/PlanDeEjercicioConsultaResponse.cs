using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class PlanDeEjercicioConsultaResponse
    {
        public List<PlanDeEjercicio> PlanesDeEjercicios { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public bool Encontrado { get; set; }
        public bool ClienteEncontrada { get; set; }
        public PlanDeEjercicioConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Encontrado = false;
        }
        public PlanDeEjercicioConsultaResponse(List<PlanDeEjercicio> planesDeEjercicios)
        {
            PlanesDeEjercicios = new List<PlanDeEjercicio>();
            PlanesDeEjercicios = planesDeEjercicios;
            Encontrado = true;
        }
    }
}
