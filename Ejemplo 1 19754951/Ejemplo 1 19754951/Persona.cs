using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1_19754951
{
public class Persona
    {
        public Persona(string ojos, string altura, string peso, string sexo)
        {
            this.ojos = ojos;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
        }

        public string ojos;
        public string altura;
        public string peso;
        public string sexo;

        public void Hablar(string texto)
        {
            // Se muestra la conversacion a decir
            Console.WriteLine("Voy a decir:" + texto);
        }
        public void Comer(double calorias)
        {
            // Se indican las calorias que se ganan al comer
            Console.WriteLine("Ganado" + calorias + "Calorias");
            this.peso += calorias / 1000;
        }
        public void correr(double calorias)
        {
            // Se indican la calorias que se pierden al correr
            Console.WriteLine("perdiendo" + calorias + " calorias");
            this.peso = Convert.ToString(calorias / 1000);
        }

    }
}
