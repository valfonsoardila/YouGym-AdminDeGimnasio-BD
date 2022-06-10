using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Administrador:Persona
    {
        public string CodigoMembresiaAdministrador { get; set; }
        public string NombreServicio { get; set; }
        public string CodigoServicio { get; set; }
        public string DescripcionServicio { get; set; }

        //**********************************Metodos****************************************

        public string AsignarCodigoMembresiaAdministrador()
        {
            return $"{CodigoMembresiaAdministrador}";
        }
        public string AsignarNombreDeServicio()
        {
            return $"{NombreServicio}";
        }
        public string AsignarCodigoDeServicio()
        {
            return $"{CodigoServicio}";
        }
        public string DescripcionDeServicio()
        {
            return $"{DescripcionServicio}";
        }
    }
}
