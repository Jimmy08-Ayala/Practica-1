using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenador_19754951
{
    internal class Program

    {
        class Ordenador
        {
            // Propiedades de la clase
            public string Marca { get; set; }
            public string Procesador { get; set; }
            public int Memoria { get; set; } // En GB
            public int DiscoDuro { get; set; } // En GB

            // Constructor
            public Ordenador(string marca, string procesador, int memoria, int discoDuro)
            {
                Marca = marca;
                Procesador = procesador;
                Memoria = memoria;
                DiscoDuro = discoDuro;
            }

            // Método para aumentar capacidad del disco duro
            public void MayorCapacidad()
            {
                DiscoDuro += 100;
                Console.WriteLine($"Capacidad del disco aumentada a {DiscoDuro} GB.");
            }

            // Método para reducir capacidad del disco duro
            public void MenorCapacidad()
            {
                if (DiscoDuro >= 100)
                {
                    DiscoDuro -= 100;
                    Console.WriteLine($"Capacidad del disco reducida a {DiscoDuro} GB.");
                }
                else
                {
                    Console.WriteLine("No se puede reducir más la capacidad del disco.");
                }
            }

            // Método para mostrar la información del ordenador
            public void MostrarInformacion()
            {
                Console.WriteLine("\nInformación del Ordenador:");
                Console.WriteLine($"Marca: {Marca}");
                Console.WriteLine($"Procesador: {Procesador}");
                Console.WriteLine($"Memoria: {Memoria} GB");
                Console.WriteLine($"Disco Duro: {DiscoDuro} GB");
            }
        }

            
            static void Main(string[] args)
            {
                // Crear un objeto de la clase Ordenador
                Ordenador miOrdenador = new Ordenador("Dell", "Intel Core i7", 16, 500);

                // Mostrar información inicial
                miOrdenador.MostrarInformacion();

                // Aumentar capacidad del disco duro
                miOrdenador.MayorCapacidad();

                // Reducir capacidad del disco duro
                miOrdenador.MenorCapacidad();

                // Mostrar información final
                miOrdenador.MostrarInformacion();

                Console.WriteLine("\nPresiona cualquier tecla para salir...");
                Console.ReadKey();
            }
        }
    }


