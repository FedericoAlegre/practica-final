using System;

namespace practica_final
{
    class Program
    {      
        public struct Partidas
        {
            public string code;
            public string airline;
            public string destino;
            public int hora;
            public string duracion;
            public string estado;
        }
        public struct Arribos
        {
            public string code;
            public string airline;
            public string origen;
            public int hora;
            public string duracion;
            public string estado;
        }
        static void Main(string[] args)
        {
            Lista listVueloCiudades = new Lista();
            Partidas[] partidas = new Partidas[10];
            Arribos[] arribos = new Arribos[10];
            void InsertaEnLista(Partidas[] par, Arribos[] arr)
            {
                Console.WriteLine("PARTIDAS:");
                for (int i = 0; i < par.Length; i++)
                {
                    if (par[i].code != null)
                    {
                        Console.WriteLine(par[i].code);
                        if (par[i].estado == "Despegado")
                        {
                            listVueloCiudades.InsertarNodo(par[i].destino, 1, 0);
                        }
                    }
                }

                Console.WriteLine("ARRIBOS:");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].code != null)
                    {
                        Console.WriteLine(arr[i].code);
                        if (arr[i].estado == "Aterrizado")
                        {
                            listVueloCiudades.InsertarNodo(arr[i].origen, 0, 1);
                        }
                    }
                }
            }


            Console.WriteLine("¿Que desea hacer?" +
                "\n1: Carar partida." +
                "\n2: Cargar arribo." +
                "\n3: Modificar estado  de una partida" +
                "\n4: Modificar estado de un arribo" +
                "\n5: Apagar\n");
            int maquina = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int countPart = 0;
            int countArr = 0;

            while (maquina != 5)
            {
                if (maquina == 1)
                {
                    LlenarArregloPartidas(partidas, countPart);
                    countPart++;                    
                }

                else if (maquina == 2)
                {
                    LlenarArregloArribos(arribos, countArr);
                    countArr++;                                                           
                }

                else if (maquina == 3)
                {
                    Console.WriteLine("MODIFICAR Partida\nIngrese el codigo de vuelo:");
                    string modcode = Console.ReadLine();

                    ModificarEstadoPartida(partidas, modcode);                    
                }

                else if (maquina == 4)
                {
                    Console.WriteLine("MODIFICAR Arribo\nIngrese el codigo de vuelo:");
                    string modcode = Console.ReadLine();

                    ModificarEstadoArribo(arribos, modcode);                    
                }

                else
                {
                    Console.WriteLine("Error!! Intente devuelta");
                }
                Console.WriteLine("¿Que desea hacer?" +
                    "\n1: Carar partida." +
                    "\n2: Cargar arribo." +
                    "\n3: Modificar estado de una partida" +
                    "\n4: Modificar estado de un arribo" +
                    "\n5: Apagar\n");
                maquina = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            InsertaEnLista(partidas, arribos);
            Console.WriteLine("\nLista:");
            listVueloCiudades.RecorrerLista();
        }

        static void LlenarArregloPartidas(Partidas[] arreglo, int i)
        {          
            Console.WriteLine("Ingrese los datos del vuelo" +
                "\nCodigo de vuelo:");
            arreglo[i].code = Console.ReadLine();
            Console.WriteLine("Aerolinia:");
            arreglo[i].airline = Console.ReadLine();
            Console.WriteLine("Horario:");
            arreglo[i].hora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Destino:");
            arreglo[i].destino = Console.ReadLine();
            arreglo[i].destino.ToUpper();
            Console.WriteLine("Duracion de vuelo");
            arreglo[i].duracion = Console.ReadLine();
            Console.WriteLine($"Elija el estado:\n" +
            $"  1: Despegado\n" +
            $"  2: Demorado\n" +
            $"  3: Consulte compañia\n" +
            $"  4: En horario:\n" +
            $"  5: No informa");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    arreglo[i].estado = "Despegado";
                    Console.WriteLine("Ingresado con exito");

                    break;
                case 2:
                    arreglo[i].estado = "Demorado";
                    Console.WriteLine("Ingresado con exito");
                    break;
                case 3:
                    arreglo[i].estado = "Consulte compañia";
                    Console.WriteLine("Ingresado con exito");
                    break;
                case 4:
                    arreglo[i].estado = "En horario";
                    Console.WriteLine("Ingresado con exito");
                    break;
                case 5:
                    arreglo[i].estado = "No informa";
                    Console.WriteLine("Ingresado con exito");
                    break;
                default:
                    arreglo[i].estado = "No informa";
                    break;
            }

        }
        static void LlenarArregloArribos(Arribos[] arreglo, int i)
        {
            Console.WriteLine("Ingrese los datos del vuelo" +
                "\nCodigo de vuelo:");
            arreglo[i].code = Console.ReadLine();
            Console.WriteLine("Aerolinia:");
            arreglo[i].airline = Console.ReadLine();
            Console.WriteLine("Horario:");
            arreglo[i].hora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Origen:");
            arreglo[i].origen = Console.ReadLine();
            arreglo[i].origen.ToUpper();
            Console.WriteLine("Duracion de vuelo");
            arreglo[i].duracion = Console.ReadLine();
            Console.WriteLine($"Elija el estado:\n" +
                $"  1: Aterrizado\n" +
                $"  2: Demorado\n" +
                $"  3: Consulte compañia\n" +
                $"  4: En horario:\n" +
                $"  5: No informa"); 
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    arreglo[i].estado = "Aterrizado";
                    Console.WriteLine("Ingresado con exito");

                    break;
                case 2:
                    arreglo[i].estado = "Demorado";
                    Console.WriteLine("Ingresado con exito");
                    break;
                case 3:
                    arreglo[i].estado = "Consulte compañia";
                    Console.WriteLine("Ingresado con exito");
                    break;
                case 4:
                    arreglo[i].estado = "En horario";
                    Console.WriteLine("Ingresado con exito");
                    break;
                case 5:
                    arreglo[i].estado = "No informa";
                    Console.WriteLine("Ingresado con exito");
                    break;
                default:
                    arreglo[i].estado = "No informa";
                    break;
            }

        }
        static void ModificarEstadoPartida(Partidas[] arreglo, string a)
        {
            bool p = false;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i].code == a)
                {
                    p = true;
                    Console.WriteLine($"el estado actual es: {arreglo[i].estado}\n" +
                        $"Elija el nuevo estado:\n" +
                        $"1: Despegado\n" +
                        $"2: Demorado\n" +
                        $"3: Consulte compañia\n" +
                        $"4: En horario:\n" +
                        $"5: No informa");
                    int x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            arreglo[i].estado = "Despegado";
                            Console.WriteLine("Modificado con exito");

                            break;
                        case 2:
                            arreglo[i].estado = "Demorado";
                            Console.WriteLine("Modificado con exito");
                            break;
                        case 3:
                            arreglo[i].estado = "Consulte compañia";
                            Console.WriteLine("Modificado con exito");
                            break;
                        case 4:
                            arreglo[i].estado = "En horario";
                            Console.WriteLine("Modificado con exito");
                            break;
                        case 5:
                            arreglo[i].estado = "No informa";
                            Console.WriteLine("Modificado con exito");
                            break;
                        default:
                            Console.WriteLine("ERROR! Ingreso un numero invalido. No se modifico el estado");
                            break;
                    }
                }
            }

            if (p == false)
            {
                Console.WriteLine("No existe ese codigo.");
            }
        }
        static void ModificarEstadoArribo(Arribos[] arreglo, string a)
        {
            bool p = false;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i].code == a)
                {
                    p = true;
                    Console.WriteLine($"el estado actual es: {arreglo[i].estado}\n" +
                        $"Elija el nuevo estado:\n" +
                        $"1: Aterrizado\n" +
                        $"2: Demorado\n" +
                        $"3: Consulte compañia\n" +
                        $"4: En horario:\n" +
                        $"5: No informa");
                    int x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            arreglo[i].estado = "Aterrizado";
                            Console.WriteLine("Modificado con exito");
                            break;
                        case 2:
                            arreglo[i].estado = "Demorado";
                            Console.WriteLine("Modificado con exito");
                            break;
                        case 3:
                            arreglo[i].estado = "Consulte compañia";
                            Console.WriteLine("Modificado con exito");
                            break;
                        case 4:
                            arreglo[i].estado = "En horario";
                            Console.WriteLine("Modificado con exito");
                            break;
                        case 5:
                            arreglo[i].estado = "No informa";
                            Console.WriteLine("Modificado con exito");
                            break;
                        default:
                            Console.WriteLine("ERROR! Ingreso un numero invalido.");
                            break;
                    }
                }
            }

            if (p == false)
            {
                Console.WriteLine("No existe ese codigo.");
            }
        }
                
    }
}
