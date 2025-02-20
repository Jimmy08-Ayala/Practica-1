using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1_19754951
{
    public class PersonaNadadora :Persona
    {
        public PersonaNadadora(string ojos, string altura, string Peso, string sexo) : base(ojos, altura, Peso, sexo)
        {
        }
        public void Nadar()
        {
            //La practica de la natacion volver al peso inicial
            Console.WriteLine("Nadando para volver al peso ideal");
            this.peso = "85";
        }
    }
}
