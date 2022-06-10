using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrenador
    {

        //Constructor
        public Entrenador(string identificacion, string nombre, string fechaDeNacimiento, int edad,string direccion, char sexo)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            FechaDeNacimiento = fechaDeNacimiento;
            Edad = edad;
            Direccion = direccion;
            Sexo = sexo;
        }

        public Entrenador()
        {

        }

        /*Atributos de la clase*/
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string FechaDeNacimiento { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public char Sexo { get; set; }
        public string CodigoEntrenador { get; set; }
        public double PagoDeSalario { get; set; }
        public int HorasExtrasDeTrabajo{ get; set; }
        public int DiasDeTrabajo { get; set; }
        public int MesesDeContrato { get; set; }
        public string TipoDeContrato { get; set; }
        /*Metodos de la clase*/
        public void CalcularSalario()
        {
            string TipoC;
            Console.WriteLine("Escoja su tipo de Contrato");
            Console.WriteLine(">>Prestacion de servicios (Ps) o Contrato fijo (Cf): ");
            TipoC = Console.ReadLine();
            if (TipoC == "Ps" || TipoC == "ps")
            {
                TipoDeContrato = "Prestacion de servicios";
                Console.WriteLine("Ingrese la cantidad de dias trabajados: ");
                DiasDeTrabajo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de horas extras: ");
                HorasExtrasDeTrabajo = int.Parse(Console.ReadLine());
                PagoDeSalario = (60000 * DiasDeTrabajo) + (HorasExtrasDeTrabajo * 100000);
                Console.WriteLine("SU SALARIO ES DE: $"+ PagoDeSalario);
                Console.ReadKey();
            }
            else
            {
                if (TipoC == "Cf" || TipoC == "cf")
                {
                    TipoDeContrato = "Contrato fijo";
                    Console.WriteLine("Digite por cuantos meses se firmo su contrato: ");
                    MesesDeContrato = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese cantidad de horas extras: ");
                    HorasExtrasDeTrabajo = int.Parse(Console.ReadLine());
                    PagoDeSalario = (2000000* MesesDeContrato) + (HorasExtrasDeTrabajo * 100000);
                    Console.WriteLine("SU SALARIO ES DE: $" + PagoDeSalario);
                    Console.ReadKey();
                }
            }
        }
        public void GenerarCodigoEntrenador()
        {
            string a = "#En";
            int b;
            string codigo;
            Random aleatorio = new Random();
            b = aleatorio.Next(400000, 500000);
            codigo = a + b;
            CodigoEntrenador = codigo;
            Console.WriteLine("Su codigo de membresia es: " + CodigoEntrenador);
        }
        public override string ToString()
        {
            return $"\n" +
                   $"- Identificacion: {Identificacion}\n" +
                   $"- Nombre: {Nombre}\n" +
                   $"- Edad: {Edad}\n" +
                   $"- Sexo: {Sexo}\n" +
                   $"- Fecha de nacimieinto: {FechaDeNacimiento}\n" +
                   $"- Direccion: {Direccion}\n";
        }
    }
}
