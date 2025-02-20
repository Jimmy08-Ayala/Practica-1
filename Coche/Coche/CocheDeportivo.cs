using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coche
{
    class CocheDeportivo : Coche
    {
        public CocheDeportivo(string marca, string modelo, int velocidadMaxima)
            : base(marca, modelo, velocidadMaxima) { }

        public void Frenar()
        {
            VelocidadActual = 0; // Se puede modificar porque es protected
            Console.WriteLine("El coche ha frenado y la velocidad es 0 km/h.");
        }
    }
}
