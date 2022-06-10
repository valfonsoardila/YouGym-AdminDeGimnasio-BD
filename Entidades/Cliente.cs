using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        //Constructor
        public Cliente(string identificacion, string nombre,string fechaDeNacimiento, int edad, string direccion, char sexo)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            FechaDeNacimiento = fechaDeNacimiento;
            Edad = edad;
            Direccion = direccion;
            Sexo = sexo;
        }
        //Constructor Sobrecargado
        public Cliente()
        {

        }
        /*Atributos de la clase*/
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string FechaDeNacimiento { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public char Sexo { get; set; }
        public string CodigoCliente { get; set; }
        public double PagoDeMensualidad { get; set; }
        public int DiasDeEntrenamiento { get; set; }
        public int TiempoDeEntrenamiento { get; set; }
        /*Metodos de la clase*/
        int DiasAux;
        public void CalcularPagoMensual()
        {
            Console.WriteLine("ingrese cantidad dias que entrenó o entrenará: ");
            DiasAux = int.Parse(Console.ReadLine());
            DiasDeEntrenamiento = DiasAux;
            PagoDeMensualidad = 20000 * DiasDeEntrenamiento;
            Console.WriteLine("Usted pagará el valor de: "+ PagoDeMensualidad);
            Console.ReadKey();
        }
        public void GenerarCodigoCliente()
        {
            string a="#Cl";
            int b;
            string codigo;
            Random aleatorio = new Random();
            b = aleatorio.Next(100000, 200000);
            codigo = a + b;
            CodigoCliente = codigo;
            Console.WriteLine("Su codigo de membresia es: "+ CodigoCliente);
        }
        public void CalcularTiempoDeEntrenamiento()
        {
            int HoraEntrenamientoDiario = 4;
            TiempoDeEntrenamiento = HoraEntrenamientoDiario * DiasAux;
            Console.WriteLine("Su tiempo(Horas) de entrenamiento total en el gimnasio es: "+ TiempoDeEntrenamiento+" Horas");
            Console.ReadKey();
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
