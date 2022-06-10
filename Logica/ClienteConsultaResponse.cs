using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class ClienteConsultaResponse
    {
        public List<Cliente> Clientes { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public bool Encontrado { get; set; }
        public bool ClienteEncontrada { get; set; }

        public ClienteConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Encontrado = false;
        }
        public ClienteConsultaResponse(List<Cliente> clientes)
        {
            Clientes = new List<Cliente>();
            Clientes = clientes;
            Encontrado = true;

        }
    }
}
