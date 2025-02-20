using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coche
{
    public class Coche
    {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int VelocidadMaxima { get; set; }
            protected int VelocidadActual { get; set; } // Se protege para la herencia

            public Coche(string marca, string modelo, int velocidadMaxima)
            {
                Marca = marca;
                Modelo = modelo;
                VelocidadMaxima = velocidadMaxima;
                VelocidadActual = 0;
            }

            public void Acelerar()
            {
                if (VelocidadActual + 5 <= VelocidadMaxima)
                {
                    VelocidadActual += 5;
                }
                else
                {
                    VelocidadActual = VelocidadMaxima;
                }
                Console.WriteLine($"Velocidad actual: {VelocidadActual} km/h");
            }

            public void Decelerar()
            {
                if (VelocidadActual - 5 >= 0)
                {
                    VelocidadActual -= 5;
                }
                else
                {
                    VelocidadActual = 0;
                }
                Console.WriteLine($"Velocidad actual: {VelocidadActual} km/h");
            }
        }

    }
