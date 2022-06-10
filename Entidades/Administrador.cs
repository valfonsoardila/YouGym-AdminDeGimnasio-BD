using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador
    {
        //Constructor
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string FechaDeNacimiento { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public char Sexo { get; set; }
    }
}
