using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coche
{

    class Program
    {
        static void Main() // Método Main válido
        {
            CocheDeportivo miCoche = new CocheDeportivo("Lamborghini", "Huracán", 320);

            miCoche.Acelerar(); // +5 km/h
            miCoche.Acelerar(); // +5 km/h
            miCoche.Decelerar(); // -5 km/h
            miCoche.Frenar(); // Velocidad = 0 km/h
        }
    }

}
