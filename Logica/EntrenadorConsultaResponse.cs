using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class EntrenadorConsultaResponse
    {

        public List<Entrenador> Entrenadores { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public bool Encontrado { get; set; }
        public bool ClienteEncontrada { get; set; }
        public EntrenadorConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Encontrado = false;
        }
        public EntrenadorConsultaResponse(List<Entrenador> entrenadores)
        {
            Entrenadores = new List<Entrenador>();
            Entrenadores = entrenadores;
            Encontrado = true;
        }
    }
}
