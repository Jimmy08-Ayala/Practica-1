using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1_19754951
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personal = new Persona("Verdes", "187", "85", "v");
            Console.WriteLine("Descripcion de la Persona: ");
            Console.WriteLine("Ojos: " + personal.ojos);
            Console.WriteLine("Altura " + personal.altura);
            Console.WriteLine("Peso: " + personal.peso);
            Console.WriteLine("Sexo " + personal.sexo);

            personal.Hablar("Me llamo Borja");
            Console.WriteLine("Color de mis ojos: " + personal.ojos);
            personal.correr(1000);
            Console.WriteLine("Mi peso actual es: " + personal.peso);

            PersonaNadadora Peronal = new PersonaNadadora("Verdes", "187", "85", "v");
            Console.WriteLine("Descripcion de la persona");
            Console.WriteLine("Ojos: " + Peronal.ojos);
            Console.WriteLine("Altura: " + Peronal.altura);
            Console.WriteLine("peso: " + Peronal.peso);
            Console.WriteLine("Sexo: ", Peronal.sexo);
            Peronal.Hablar("Me llamo Borja");
            Console.WriteLine("color de mis ojos: " + Peronal.ojos);
            Peronal.correr(1000);
            Console.WriteLine("Mi peso actual es:", Peronal.peso);
            Peronal.Nadar();
            Console.WriteLine("Tras nafar peso:", Peronal.peso);
            Console.ReadKey();
        }
    }
}
