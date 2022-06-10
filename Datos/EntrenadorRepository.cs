using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Datos
{
    public class EntrenadorRepository
    {
        private string ruta = @"Entrenadores.txt";

        public void Guardar(Entrenador entrenador)
        {
            StreamWriter escritor = new StreamWriter(ruta, true);
            escritor.WriteLine($"{entrenador.Identificacion};{entrenador.Nombre};{entrenador.FechaDeNacimiento};{entrenador.Edad};{entrenador.Direccion};{entrenador.Sexo};{entrenador.CodigoEntrenador};{entrenador.PagoDeSalario};{entrenador.HorasExtrasDeTrabajo};{entrenador.DiasDeTrabajo};{entrenador.TipoDeContrato}");
            escritor.Close();
        }
        public List<Entrenador> Consultar()
        {
            List<Entrenador> entrenadores = new List<Entrenador>();
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                Entrenador entrenador = new Entrenador()
                {
                    Identificacion = dato[0],
                    Nombre = dato[1],
                    FechaDeNacimiento = dato[2],
                    Edad = int.Parse(dato[3]),
                    Direccion = dato[4],
                    Sexo = char.Parse(dato[5]),
                    CodigoEntrenador = dato[6],
                    PagoDeSalario = float.Parse(dato[7]),
                    HorasExtrasDeTrabajo = int.Parse(dato[8]),
                    DiasDeTrabajo = int.Parse(dato[9]),
                    TipoDeContrato = dato[10]
                };
                entrenadores.Add(entrenador);
            }
            lector.Close();
            return entrenadores;
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
        public void Modificar(Entrenador entrenador, string identificacion)
        {
            List<Entrenador> entrenadores = new List<Entrenador>();
            entrenadores = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in entrenadores)
            {
                if (!EsEncontrado(item.Identificacion, identificacion))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(entrenador);
                }
            }
        }
        public void Eliminar(string id)
        {
            List<Entrenador> entrenadores = new List<Entrenador>();
            entrenadores = Consultar();

            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();

            foreach (var item in entrenadores)
            {
                if (!item.Identificacion.Equals(id))
                {
                    Guardar(item);
                }
            }
        }
    }
}
