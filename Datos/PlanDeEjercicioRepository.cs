using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Datos
{
    public class PlanDeEjercicioRepository
    {
        private string ruta = @"PlanDeEjercicio.txt";

        public void Guardar(PlanDeEjercicio planDeEjercicio)
        {
            StreamWriter escritor = new StreamWriter(ruta, true);
            escritor.WriteLine($"{planDeEjercicio.IdPlanEjercicio};{planDeEjercicio.NombreDePlanEjercicio};{planDeEjercicio.Sesion};{planDeEjercicio.Objetivo};{planDeEjercicio.FechaDeEntreno};{planDeEjercicio.MetodoDeEntrenamiento};{planDeEjercicio.DescripcionDePlanEjercicio};{planDeEjercicio.Estado};{planDeEjercicio.HorasSemanales};{planDeEjercicio.DiaDeSemana};{planDeEjercicio.Ciclo}");
            escritor.Close();
        }
        public List<PlanDeEjercicio> Consultar()
        {
            List<PlanDeEjercicio> planesDeEjercicios = new List<PlanDeEjercicio>();
            StreamReader lector = new StreamReader(ruta);
            var linea = "";
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                PlanDeEjercicio planDeEjercicio = new PlanDeEjercicio()
                {
                    IdPlanEjercicio= dato[0],
                    NombreDePlanEjercicio = dato[1],
                    Sesion = dato[2],
                    Objetivo = dato[3],
                    FechaDeEntreno = dato[4],
                    MetodoDeEntrenamiento = dato[5],
                    DescripcionDePlanEjercicio = dato[6],
                    Estado = dato[7],
                    HorasSemanales = int.Parse(dato[8]),
                    DiaDeSemana = int.Parse(dato[9]),
                    Ciclo = dato[10]
                };
                planesDeEjercicios.Add(planDeEjercicio);
            }
            lector.Close();
            return planesDeEjercicios;
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
        public void Modificar(PlanDeEjercicio planDeEjercicio, string idPlanDeEjercicio)
        {
            List<PlanDeEjercicio> planesDeEjercicio = new List<PlanDeEjercicio>();
            planesDeEjercicio = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in planesDeEjercicio)
            {
                if (!EsEncontrado(item.IdPlanEjercicio, idPlanDeEjercicio))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(planDeEjercicio);
                }
            }
        }
        public void Eliminar(string id)
        {
            List<PlanDeEjercicio> planesDeEjercicios = new List<PlanDeEjercicio>();
            planesDeEjercicios = Consultar();

            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();

            foreach (var item in planesDeEjercicios)
            {
                if (!item.IdPlanEjercicio.Equals(id))
                {
                    Guardar(item);
                }
            }
        }
    }
}
