using System;
using Logica;
using System.Threading;
using Entidades;

namespace Consola
{
    class Program
    {
        public static Cliente cliente = new Cliente();
        public static ClienteService clienteService = new ClienteService();
        public static Entrenador entrenador = new Entrenador();
        public static EntrenadorService entrenadorService = new EntrenadorService();
        public static PlanDeEjercicio planDeEjercicio = new PlanDeEjercicio();
        public static PlanDeEjercicioService planDeEjercicioService = new PlanDeEjercicioService();
        public static void Main(string[] args)
        {
            char opc = 's';
            int op = 0;
            while (opc=='s' || opc=='S')
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*******************************************");
                Console.WriteLine("*        ADMINISTRADOR DE GIMNASIO        *");
                Console.WriteLine("*-----------------------------------------*");
                Console.WriteLine("*                  MENU                   *");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("* 1. Gestionar Cliente                    *");
                Console.WriteLine("* 2. Gestionar Entrenador                 *");
                Console.WriteLine("* 3. Salir                                *");
                Console.WriteLine("*-----------------------------------------*");
                Console.WriteLine(">>Elige opcion: ");op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    GestionarCliente();
                }
                else
                {
                    if (op == 2)
                    {
                        GestionarEtrenador();
                    }
                    else
                    {
                        if (op == 3)
                        {
                            break;   
                        }
                    }
                }
            }
        }
        //Metodo Gestionar Cliente
        public static void GestionarCliente()
        {
            Cliente cliente = new Cliente();
            PlanDeEjercicio planDeEjercicio = new PlanDeEjercicio();
            char opc = 's';
            int op = 0;
            while (opc == 's' || opc == 'S')
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*******************************************");
                Console.WriteLine("*           GESTION DE CLIENTE           *");
                Console.WriteLine("*-----------------------------------------*");
                Console.WriteLine("*                  MENU                   *");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("* 1. Registrar Datos                      *");
                Console.WriteLine("* 2. Consultar Datos                      *");
                Console.WriteLine("* 3. Modificar Datos                      *");
                Console.WriteLine("* 4. Eliminar  Datos                      *");
                Console.WriteLine("* 5. Consultar Plan de Ejercicios         *");
                Console.WriteLine("* 6. Calcular  Pago Mensual               *");
                Console.WriteLine("* 7. Calcular  tiempo de entrenamiento    *");
                Console.WriteLine("* 8. Volver al menu principal             *");
                Console.WriteLine("*-----------------------------------------*");
                Console.WriteLine(">>Elige opcion: "); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        if (op == 1) { RegistrarDatosCliente(); }
                        break;
                    case 2:
                        if (op == 2) { ConsultarDatosCliente(clienteService); }
                        break;
                    case 3:
                        if (op == 3) { ModificarDatosCliente(); }
                        break;
                    case 4:
                        if (op == 4) { EliminarDatosCliente(); }
                        break;
                    case 5:
                        if (op == 5) { ConsultarDatosPlanDeEjercicio(); planDeEjercicio.ImprimirPlanDeEjercicio(); }
                        break;
                    case 6:
                        if (op == 6) { cliente.CalcularPagoMensual(); }
                        break;
                    case 7:
                        if (op == 7) { planDeEjercicio.CalcularHorasSemanales(); cliente.CalcularTiempoDeEntrenamiento(); }
                        break;
                    case 8:
                        if (op == 8) { opc = 'n'; }
                        break;
                }
            }   
        }
        //Procedimientos del metodo Gestionar Cliente>>
        public static void RegistrarDatosCliente()//Registrar cliente CRUD
        {
            string Identificacion, Nombre, FechaDenacimiento, Direccion;
            int Edad;
            char Sexo;
            char opAgregar='s';
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*          REGISTRAR DATOS DE CLIENTE          *");
            while (opAgregar=='s'|| opAgregar == 'S')
            {
                Console.WriteLine("Ingrese su identificacion: ");
                Identificacion=Console.ReadLine();
                Console.WriteLine("Ingrese su nombre: ");
                Nombre= Console.ReadLine();
                Console.WriteLine("Ingrese su fecha de nacimiento: ");
                FechaDenacimiento = Console.ReadLine();
                Console.WriteLine("Ingrese su edad: ");
                Edad= int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su direccion: ");
                Direccion= Console.ReadLine();
                Console.WriteLine("Digite su sexo Femenino (F) o Masculino (M): ");
                Sexo = char.Parse(Console.ReadLine());                

                Cliente cliente = new Cliente(Identificacion, Nombre, FechaDenacimiento, Edad, Direccion, Sexo);
                ClienteService clienteService = new ClienteService();
                Console.WriteLine("Generando codigo de membresia"); Thread.Sleep(500); Console.WriteLine("."); Thread.Sleep(500); Console.WriteLine("."); Thread.Sleep(500); Console.WriteLine(".");
                string mensaje = clienteService.Guardar(cliente);
                Console.WriteLine(mensaje);

                Console.WriteLine("Desea Registrar otro Cliente? S(si) o N(no): ");
                opAgregar = char.Parse(Console.ReadLine());
            }            
        }
        public static void ConsultarDatosCliente(ClienteService clienteService)//Consultar cliente CRUD
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*          CONSULTAR DATOS DE CLIENTE          *");
            ClienteConsultaResponse clienteConsultaResponse = clienteService.Consultar();
            if (clienteConsultaResponse.Encontrado == true)
            {
                foreach (var item in clienteConsultaResponse.Clientes)
                {
                    Console.WriteLine("Lista de Clientes: ");
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine(clienteConsultaResponse.Mensaje);
            }
            Console.ReadKey();
        }
        public static void ModificarDatosCliente()//Modificar cliente CRUD
        {
            string id;
            string Identificacion, Nombre, FechaDenacimiento, Direccion;
            int Edad;
            char Sexo;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*          MODIFICAR DATOS DE CLIENTE          *");
            Console.WriteLine("Digite la identificacion: ");
            id = Console.ReadLine();
            Console.WriteLine("\n");
            if (clienteService.FiltroIdentificaicon(id) == true)
            {
                
                Console.WriteLine("Ingrese su identificacion: ");
                Identificacion = Console.ReadLine();
                Console.WriteLine("Ingrese su nombre: ");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su fecha de nacimiento: ");
                FechaDenacimiento = Console.ReadLine();
                Console.WriteLine("Ingrese su edad: ");
                Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su direccion: ");
                Direccion = Console.ReadLine();
                Console.WriteLine("Digite su sexo Femenino (F) o Masculino (M): ");
                Sexo = char.Parse(Console.ReadLine());

                Cliente cliente = new Cliente(Identificacion, Nombre, FechaDenacimiento, Edad, Direccion, Sexo);
                ClienteService clienteService = new ClienteService();
                Console.WriteLine("Generando codigo de membresia"); Thread.Sleep(500); Console.WriteLine("."); Thread.Sleep(500); Console.WriteLine("."); Thread.Sleep(500); Console.WriteLine(".");

                cliente.GenerarCodigoCliente();
                string mensaje = clienteService.Modificar(cliente,id);

                Console.WriteLine(mensaje);


                Console.WriteLine("\nCliente Modificado correctamente...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No encontrado");
                Console.ReadKey();
            }
        }

        public static void EliminarDatosCliente()//Eliminar cliente CRUD
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite la identificacion:");
            string id = Console.ReadLine();
            if (clienteService.FiltroIdentificaicon(id) == true)
            {
                ClienteService clienteService = new ClienteService();
                string mensaje = clienteService.Eliminar(id);
            }
        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        //Metodo Gestionar Entrenador
        public static void GestionarEtrenador()
        {
            Entrenador entrenador = new Entrenador();
            char opc = 's';
            int op = 0;
            while (opc == 's' || opc == 'S')
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*******************************************");
                Console.WriteLine("*          GESTION DE ENTRENADOR          *");
                Console.WriteLine("*-----------------------------------------*");
                Console.WriteLine("*                  MENU                   *");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("* 1. Registrar Datos                      *");
                Console.WriteLine("* 2. Consultar Datos                      *");
                Console.WriteLine("* 3. Modificar Datos                      *");
                Console.WriteLine("* 4. Eliminar  Datos                      *");
                Console.WriteLine("* 5. Asignar   Plan de Ejercicio          *");
                Console.WriteLine("* 6. Consultar Salario                    *");
                Console.WriteLine("* 7. Volver al Menu principal             *");
                Console.WriteLine("*-----------------------------------------*");
                Console.WriteLine(">>Elige opcion: "); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        if (op == 1) { RegistrarDatosEntrenador(); }
                        break;
                    case 2:
                        if (op == 2) { ConsultarDatosEntrenador(entrenadorService); }
                        break;
                    case 3:
                        if (op == 3) { ModificarDatosEntrenador(); }
                        break;
                    case 4:
                        if (op == 4) { EliminarDatosEntrenador(); }
                        break;
                    case 5:
                        if (op == 5) { RegistrarPlandeEjercicio(); }
                        break;
                    case 6:
                        if (op == 6) { entrenador.CalcularSalario(); }
                        break;
                    case 7:
                        if (op == 7) { opc = 'n'; }
                        break;
                }
            }
        }
        //Procedimientos Metodo Gestionar Entrenador>>
        public static void RegistrarDatosEntrenador()//Registrar entrenador CRUD
        {
            string Identificacion, Nombre, FechaDenacimiento, Direccion;
            int Edad;
            char Sexo;
            char opAgregar = 's';
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*          REGISTRAR DATOS DE ENTRENADOR          *");
            while (opAgregar == 's' || opAgregar == 'S')
            {
                Console.WriteLine("Ingrese su identificacion: ");
                Identificacion = Console.ReadLine();
                Console.WriteLine("Ingrese su nombre: ");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su fecha de nacimiento: ");
                FechaDenacimiento = Console.ReadLine();
                Console.WriteLine("Ingrese su edad: ");
                Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su direccion: ");
                Direccion = Console.ReadLine();
                Console.WriteLine("Digite su sexo Femenino (F) o Masculino (M): ");
                Sexo = char.Parse(Console.ReadLine());

                Entrenador entrenador = new Entrenador(Identificacion, Nombre, FechaDenacimiento, Edad, Direccion, Sexo);
                EntrenadorService entrenadorService = new EntrenadorService();
                Console.WriteLine("Generando codigo de membresia");  Console.WriteLine("."); Thread.Sleep(500); Console.WriteLine("."); Thread.Sleep(500); Console.WriteLine(".");
                entrenador.GenerarCodigoEntrenador();
                string mensaje = entrenadorService.Guardar(entrenador);
                Console.WriteLine(mensaje);

                Console.WriteLine("\nEntrenador Registrado correctamente...");
                Console.WriteLine("Desea Registrar otro Entrenador? S(si) o N(no): ");
                opAgregar = char.Parse(Console.ReadLine());
            }
        }
        public static void ConsultarDatosEntrenador(EntrenadorService entrenadorService)//Consultar entrenador CRUD
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*          CONSULTAR DATOS DE ENTRENADOR          *");
            EntrenadorConsultaResponse entrenadorConsultaResponse = entrenadorService.Consultar();
            if (entrenadorConsultaResponse.Encontrado == true)
            {
                Console.WriteLine("Lista de Entrenadores");
                foreach (var item in entrenadorConsultaResponse.Entrenadores)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine(entrenadorConsultaResponse.Mensaje);
            }
            Console.ReadKey();
        }
        public static void ModificarDatosEntrenador()//Modificar entrenador CRUD
        {
            string id;
            string Identificacion, Nombre, FechaDenacimiento, Direccion;
            int Edad;
            char Sexo;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*          MODIFICAR DATOS DE ENTRENADOR          *");
            Console.WriteLine("Digite la identificacion:");
            id = Console.ReadLine();
            Console.WriteLine("\n");
            if (entrenadorService.FiltroIdentificaicon(id) == true)
            {

                Console.WriteLine("Ingrese su identificacion: ");
                Identificacion = Console.ReadLine();
                Console.WriteLine("Ingrese su nombre: ");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su fecha de nacimiento: ");
                FechaDenacimiento = Console.ReadLine();
                Console.WriteLine("Ingrese su edad: ");
                Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su direccion: ");
                Direccion = Console.ReadLine();
                Console.WriteLine("Digite su sexo Femenino (F) o Masculino (M): ");
                Sexo = char.Parse(Console.ReadLine());

                Entrenador entrenador = new Entrenador(Identificacion, Nombre, FechaDenacimiento, Edad, Direccion, Sexo);
                EntrenadorService entrenadorService = new EntrenadorService();
                Console.WriteLine("Generando codigo de membresia"); Thread.Sleep(500); Console.WriteLine("."); Thread.Sleep(500); Console.WriteLine("."); Thread.Sleep(500); Console.WriteLine(".");

                entrenador.GenerarCodigoEntrenador();
                string mensaje = entrenadorService.Modificar(entrenador, id);
                Console.WriteLine(mensaje);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No encontrado");
                Console.ReadKey();
            }
        }
        public static void EliminarDatosEntrenador()//Eliminar entrenador CRUD
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite la identificacion:");
            string id = Console.ReadLine();
            if (entrenadorService.FiltroIdentificaicon(id) == true)
            {
                EntrenadorService entrenadorService = new EntrenadorService();
                string mensaje = entrenadorService.Eliminar(id);
            }
        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        //Procedimientos Metodo Gestionar plan de ejercicio>>
        public static void RegistrarPlandeEjercicio()//Registrar plan de ejercicio CRUD
        {
            string idPlanEjercicio, nombreDePlanEjercicio, sesion, objetivo, fechaDeEntreno, metodoDeEntrenamiento, descripcionDePlanEjercicio, estado, ciclo;
            int diaDeSemana;
            char opAgregar = 's';
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*          REGISTRAR PLAN DE EJERCICIO          *");
            while (opAgregar == 's' || opAgregar == 'S')
            {
                Console.WriteLine("Registrar Plan de Ejercicio");
                Console.WriteLine("Digite la ID del plan de ejercicio: ");
                idPlanEjercicio = Console.ReadLine();
                Console.WriteLine("Introduzca nombre del plan de ejercicio: ");
                nombreDePlanEjercicio = Console.ReadLine();
                Console.WriteLine("Introduzca si la sesion es en la mañana (M) o en la tarde(T): ");
                sesion = Console.ReadLine();
                Console.WriteLine("Introduzca el objetivo del Entrenamiento: ");
                objetivo = Console.ReadLine();
                Console.WriteLine("Introduzca Fecha de sesion de entrenamiento: ");
                fechaDeEntreno = Console.ReadLine();
                Console.WriteLine("Registre el metodo de entrenamiento: ");
                metodoDeEntrenamiento = Console.ReadLine();
                Console.WriteLine("Describa el plan de ejercicio: ");
                descripcionDePlanEjercicio = Console.ReadLine();
                Console.WriteLine("Digite (en numero) el dia de la semana: ");
                diaDeSemana = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el ciclo Inicio(I),Proceso(P),Finalizado(F): ");
                ciclo = Console.ReadLine();
                Console.WriteLine("Escriba el estado del plan de ejercicio Activo o Inactivo");
                estado = Console.ReadLine();
                PlanDeEjercicio planDeEjercicio = new PlanDeEjercicio(idPlanEjercicio, nombreDePlanEjercicio, sesion, objetivo, fechaDeEntreno, metodoDeEntrenamiento, descripcionDePlanEjercicio, estado, diaDeSemana,ciclo);
                PlanDeEjercicioService planDeEjercicioService = new PlanDeEjercicioService();
                string mensaje = planDeEjercicioService.Guardar(planDeEjercicio);
                Console.WriteLine(mensaje);
                Console.WriteLine("Desea Agregar otro Plan de ejrcicio? S(si) o N(no): ");
                opAgregar = char.Parse(Console.ReadLine());
            }
        }
        public static void ConsultarDatosPlanDeEjercicio()//Consultar plan de ejercicio CRUD
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*          CONSULTAR DATOS DEL PLAN DE EJERCICIO           *");
            PlanDeEjercicioConsultaResponse planDeEjercicioConsultaResponse = planDeEjercicioService.Consultar();
            if (planDeEjercicioConsultaResponse.Encontrado == true)
            {
                Console.WriteLine("Lista de Entrenadores");
                foreach (var item in planDeEjercicioConsultaResponse.PlanesDeEjercicios)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine(planDeEjercicioConsultaResponse.Mensaje);
            }
            Console.ReadKey();
        }
        public static void ModificarDatosPlanDeEjercicio()//Modificar plan de ejercicio CRUD
        {
            string id;
            string idPlanEjercicio, nombreDePlanEjercicio, sesion, objetivo, fechaDeEntreno, metodoDeEntrenamiento, descripcionDePlanEjercicio, estado, ciclo;
            int diaDeSemana;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*          MODIFICAR DATOS DE CLIENTE          *");
            Console.WriteLine("Digite la identificacion:");
            id = Console.ReadLine();
            Console.WriteLine("\n");
            if (planDeEjercicioService.FiltroIdentificaicon(id) == true)
            {

                Console.WriteLine("Registrar Plan de Ejercicio");
                Console.WriteLine("Digite la ID del plan de ejercicio: ");
                idPlanEjercicio = Console.ReadLine();
                Console.WriteLine("Introduzca nombre del plan de ejercicio: ");
                nombreDePlanEjercicio = Console.ReadLine();
                Console.WriteLine("Introduzca si la sesion es en la mañana (M) o en la tarde(T): ");
                sesion = Console.ReadLine();
                Console.WriteLine("Introduzca el objetivo del Entrenamiento: ");
                objetivo = Console.ReadLine();
                Console.WriteLine("Introduzca Fecha de sesion de entrenamiento: ");
                fechaDeEntreno = Console.ReadLine();
                Console.WriteLine("Registre el metodo de entrenamiento: ");
                metodoDeEntrenamiento = Console.ReadLine();
                Console.WriteLine("Describa el plan de ejercicio: ");
                descripcionDePlanEjercicio = Console.ReadLine();
                Console.WriteLine("Digite (en numero) el dia de la semana: ");
                diaDeSemana = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el ciclo Inicio(I),Proceso(P),Finalizado(F): ");
                ciclo = Console.ReadLine();
                Console.WriteLine("Escriba el estado del plan de ejercicio Activo o Inactivo");
                estado = Console.ReadLine();
                PlanDeEjercicio planDeEjercicio = new PlanDeEjercicio(idPlanEjercicio, nombreDePlanEjercicio, sesion, objetivo, fechaDeEntreno, metodoDeEntrenamiento, descripcionDePlanEjercicio, estado, diaDeSemana, ciclo);
                PlanDeEjercicioService planDeEjercicioService = new PlanDeEjercicioService();
                string mensaje = planDeEjercicioService.Guardar(planDeEjercicio);
                Console.WriteLine(mensaje);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No encontrado");
                Console.ReadKey();
            }
        }
        public static void EliminarDatosPlanDeEjercicio()//Eliminar plan de ejercicio CRUD
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite la identificacion:");
            string id = Console.ReadLine();
            if (planDeEjercicioService.FiltroIdentificaicon(id) == true)
            {
                PlanDeEjercicioService planDeEjercicioService = new PlanDeEjercicioService();
                string mensaje = planDeEjercicioService.Eliminar(id);
            }
        }
            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }
}

