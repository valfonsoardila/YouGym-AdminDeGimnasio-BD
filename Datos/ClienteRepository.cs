using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Datos
{
    public class ClienteRepository
    {
        private string ruta = @"Clientes.txt";

        public void Guardar(Cliente cliente)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{cliente.Identificacion};{cliente.Nombre};{cliente.FechaDeNacimiento};{cliente.Edad};{cliente.Direccion};{cliente.Sexo};{cliente.CodigoCliente};{cliente.PagoDeMensualidad};{cliente.DiasDeEntrenamiento};{cliente.TiempoDeEntrenamiento}"); 
            escritor.Close();
            file.Close();
        }
        public List<Cliente> Consultar()
        {
            List<Cliente> clientes = new List<Cliente>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                Cliente cliente = new Cliente()
                {
                    Identificacion = dato[0],
                    Nombre = dato[1],
                    FechaDeNacimiento = dato[2],
                    Edad = int.Parse(dato[3]),
                    Direccion = dato[4],
                    Sexo = char.Parse(dato[5]),
                    CodigoCliente = dato[6],
                    PagoDeMensualidad = float.Parse(dato[7]),
                    DiasDeEntrenamiento = int.Parse(dato[8]),
                    TiempoDeEntrenamiento = int.Parse(dato[9]),
                };
                clientes.Add(cliente);
            }
            lector.Close();
            file.Close();
            return clientes;
        }
        public bool FiltroIdentificaicon(string identificacion)
        {
            List<Cliente> clientes = new List<Cliente>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');       
                if (dato[0].Equals(identificacion))
                {
                    lector.Close();
                    file.Close();
                    return true;
                }
            }
            lector.Close();

            file.Close();
            return false;

        }
        private bool EsEncontrado(string identificacioRegistrada, string identificacionBuscada)
        {
            return identificacioRegistrada == identificacionBuscada;
        }
        public void Modificar(Cliente cliente, string identificacion)
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in clientes)
            {
                if (!EsEncontrado(item.Identificacion, identificacion))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(cliente);
                }
            }
        }
        public void Eliminar(string id)
        {
            List<Cliente> clientes = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();

            foreach (var item in clientes)
            {
                if (!item.Identificacion.Equals(id))
                {
                    Guardar(item);
                }
            }
        }
    }
}
