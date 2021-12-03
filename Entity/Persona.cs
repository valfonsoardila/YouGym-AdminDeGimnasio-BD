using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public string Estado { get; set; }
        public string Edad { get; set; }
        public string Escribir()
        {
            return $"{Identificacion};{Nombre};{Direccion};{Sexo};{Estado};{Edad}";
        }
    }
}
