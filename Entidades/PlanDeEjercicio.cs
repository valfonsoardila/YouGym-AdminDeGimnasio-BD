using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlanDeEjercicio
    {
        public PlanDeEjercicio(string idPlanEjercicio, string nombreDePlanEjercicio, string sesion, string objetivo, string fechaDeEntreno, string metodoDeEntrenamiento, string descripcionDePlanEjercicio, string estado, int diaDeSemana,string ciclo)
        {
            IdPlanEjercicio = idPlanEjercicio;
            NombreDePlanEjercicio = nombreDePlanEjercicio;
            Sesion = sesion;
            Objetivo = objetivo;
            FechaDeEntreno = fechaDeEntreno;
            MetodoDeEntrenamiento = metodoDeEntrenamiento;
            DescripcionDePlanEjercicio = descripcionDePlanEjercicio;
            Estado = estado;
            DiaDeSemana = diaDeSemana;
            Ciclo = ciclo;
        }

        public PlanDeEjercicio()
        {

        }

        //Atributos de la clase
        public string IdPlanEjercicio { get; set; }
        public string NombreDePlanEjercicio { get; set; }
        public string Sesion { get; set; }
        public string Objetivo { get; set; }
        public string FechaDeEntreno { get; set; }
        public string MetodoDeEntrenamiento { get; set; }
        public string DescripcionDePlanEjercicio { get; set; }
        public int DiaDeSemana { get; set; }
        public string Estado { get; set; }
        public int HorasSemanales { get; set; }
        public string Ciclo { get; set; }
        
        //Metodos De la clase
        public void ImprimirPlanDeEjercicio()
        {
            Console.Clear();
            
            if (DiaDeSemana == 0)
            {
                Console.WriteLine("No se le ha sido asignado plan de ejercicio");
            }
            else {
                Console.WriteLine("Plan de ejercicios");
                PrintRow("Hora", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo");
                if (DiaDeSemana == 1 && (Sesion == "Mañana" || Sesion == "M"))
                {
                    PrintLine();
                    PrintRow("8:00Am-10", "Descripcion: " + DescripcionDePlanEjercicio, " ", " ", " ", " ", " ", " ");
                }
                else
                {
                    if (DiaDeSemana == 2 && (Sesion == "Mañana" || Sesion == "M"))
                    {
                        PrintLine();
                        PrintRow("8:00Am-10", " ", "Descripcion:" + DescripcionDePlanEjercicio, " ", " ", " ", " ", " ");
                    }
                    else
                    {
                        if (DiaDeSemana == 3 && (Sesion == "Mañana" || Sesion == "M"))
                        {
                            PrintLine();
                            PrintRow("8:00Am-10", " ", " ", "Descripcion:" + DescripcionDePlanEjercicio, " ", " ", " ", " ");
                        }
                        else
                        {
                            if (DiaDeSemana == 4 && (Sesion == "Mañana" || Sesion == "M"))
                            {
                                PrintLine();
                                PrintRow("8:00Am-10", " ", " ", " ", "Descripcion:" + DescripcionDePlanEjercicio, " ", " ", " ");
                            }
                            else
                            {
                                if (DiaDeSemana == 5 && (Sesion == "Mañana" || Sesion == "M"))
                                {
                                    PrintLine();
                                    PrintRow("8:00Am-10", " ", " ", " ", " ", "Descripcion:" + DescripcionDePlanEjercicio, " ", " ");
                                }
                                else
                                {
                                    if (DiaDeSemana == 6 && (Sesion == "Mañana" || Sesion == "M"))
                                    {
                                        PrintLine();
                                        PrintRow("10:00Am-12", " ", " ", " ", " ", " ", "Descripcion:" + DescripcionDePlanEjercicio, " ");
                                    }
                                    else
                                    {
                                        if (DiaDeSemana == 7 && (Sesion == "Mañana" || Sesion == "M"))
                                        {
                                            PrintLine();
                                            PrintRow("10:00Am-12", " ", " ", " ", " ", " ", " ", "Descripcion:" + DescripcionDePlanEjercicio);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (DiaDeSemana == 1 && (Sesion == "Tarde" || Sesion == "T"))
                {
                    PrintLine();
                    PrintRow("2:00Pm-4:00Pm", "Descripcion: " + DescripcionDePlanEjercicio, " ", " ", " ", " ", " ", " ");
                }
                else
                {
                    if (DiaDeSemana == 2 && (Sesion == "Tarde" || Sesion == "T"))
                    {
                        PrintLine();
                        PrintRow("2:00Pm-4:00Pm", " ", "Descripcion:" + DescripcionDePlanEjercicio, " ", " ", " ", " ", " ");
                    }
                    else
                    {
                        if (DiaDeSemana == 3 && (Sesion == "Tarde" || Sesion == "T"))
                        {
                            PrintLine();
                            PrintRow("2:00Pm-4:00Pm", " ", " ", "Descripcion:" + DescripcionDePlanEjercicio, " ", " ", " ", " ");
                        }
                        else
                        {
                            if (DiaDeSemana == 4 && (Sesion == "Tarde" || Sesion == "T"))
                            {
                                PrintLine();
                                PrintRow("2:00Pm-4:00Pm", " ", " ", " ", "Descripcion:" + DescripcionDePlanEjercicio, " ", " ", " ");
                            }
                            else
                            {
                                if (DiaDeSemana == 5 && (Sesion == "Tarde" || Sesion == "T"))
                                {
                                    PrintLine();
                                    PrintRow("2:00Pm-4:00Pm", " ", " ", " ", " ", "Descripcion:" + DescripcionDePlanEjercicio, " ", " ");
                                }
                                else
                                {
                                    if (DiaDeSemana == 6 && (Sesion == "Tarde" || Sesion == "T"))
                                    {
                                        PrintLine();
                                        PrintRow("4:00Pm-6:00Pm", " ", " ", " ", " ", " ", "Descripcion:" + DescripcionDePlanEjercicio, " ");
                                    }
                                    else
                                    {
                                        if (DiaDeSemana == 7 && (Sesion == "Tarde" || Sesion == "T"))
                                        {
                                            PrintLine();
                                            PrintRow("4:00Pm-6:00Pm", " ", " ", " ", " ", " ", " ", "Descripcion:" + DescripcionDePlanEjercicio);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            Console.ReadKey();
        }
        /*Start Procedimientos del metodo ConsultarPlanDeEjercicio*/
        public void PrintLine()
        {
            int tableWidth = 73;
            Console.WriteLine(new string('-',tableWidth));
        }
        public void PrintRow(params string[] columns)
        {
            int tableWidth = 73;
            int width=(tableWidth-columns.Length)/columns.Length;
            string row = "|";
            foreach (string column in columns)
            {
                row += Aligncenter(column, width) + "|";
            }
            Console.WriteLine(row);
        }
        public string Aligncenter(string text, int width)
        {
            text = text.Length > width ? text.Substring(0,width-1)+"...":text;
            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width-(width-text.Length)/2).PadLeft(width);
            }
        }
        /*End Procedimientos del metodo ConsultarPlanDeEjercicio*/
        public void CalcularHorasSemanales()
        {
            HorasSemanales = DiaDeSemana * 2;
        }
        public override string ToString()
        {
            return $"- Identificacion: {IdPlanEjercicio}\n" +
                   $"- Nombre del plan de ejercicio: {NombreDePlanEjercicio}\n" +
                   $"- Edad: {Sesion}\n" +
                   $"- Sexo: {Objetivo}\n" +
                   $"- Fecha de nacimieinto: {FechaDeEntreno}\n" +
                   $"- Metodo de entrenamiento: {MetodoDeEntrenamiento}\n" +
                   $"- Descripcion del plan: {DescripcionDePlanEjercicio}\n" +
                   $"- Dias de entrenamiento: {DiaDeSemana}\n" +
                   $"- Cantidad de horas semanales: {HorasSemanales}\n" +
                   $"- Estado Actual: {Estado}\n" +
                   $"- Ciclo: {Ciclo}\n";
        }
    }
}
