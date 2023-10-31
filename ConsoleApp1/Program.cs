using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> notas = new List<int>();

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Interfaz.MostrarMenu();
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Interfaz.RegistrarNota();
                        if (int.TryParse(Console.ReadLine(), out opcion))
                        {
                            switch (opcion)
                            {
                                case 1:Interfaz.RegistrarNota();
                                    break;
                                case 2:break;
                                default:Console.WriteLine("Opción no válida. Seleccionando la opción 2 para regresar.");break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida. Seleccionando la opción 2 para regresar.");
                        }

                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Interfaz.MostrarNotaMayor();
                        break;
                    case 3:
                        Console.Clear();
                        Interfaz.MostrarNotaMenor();
                        break;
                    case 4:
                        Console.Clear();
                        Interfaz.BuscarNota();
                        break;
                    case 5:
                        Console.Clear();
                        Interfaz.ModificarNota();
                        break;
                    case 6:
                        Console.Clear();
                        Interfaz.MostrarNotasRegistradas();
                        break;
                    case 7:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                        break;
                }
            }
        } while (opcion != 7);
        Console.ReadKey();
    }
}