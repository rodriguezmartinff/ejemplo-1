using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hla mundo puta");

            Persona p1 = new Persona();

            p1.Nombre = "chatumadre";

            Console.WriteLine("el nombre de p1 es: " + p1.Nombre);

            Developer d1 = new Developer();
            d1.Nombre = "dev1";

            Console.WriteLine("El nombre del developer es: " + d1.Nombre);

            Tester t1 = new Tester();

            t1.Nombre = "tesster julio";
            Console.WriteLine(t1.Nombre);

            Developer d2 = new Developer();
            Developer d3 = new Developer();

            d1.Categoria = "senior";

            List<Developer> listadevelopers = new List<Developer>();
            listadevelopers.Add(d1);
            listadevelopers.Add(d2);
            listadevelopers.Add(d3);

            listadevelopers[1].Categoria = "junior";
            d3.Categoria = "tranee";

            Console.WriteLine("La cantidad de developers es: " + listadevelopers.Count);
            Console.WriteLine("La categoria de d1 es: " + listadevelopers[0].Categoria);

            
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("indice: " + (i + 1) + " categoria: " + listadevelopers[i].Categoria);
            }

            foreach (Developer dev in listadevelopers)
            {
                Console.WriteLine("categoria: " + dev.Categoria);
            }
            listadevelopers.Remove(d2);
            Console.ReadKey();
        }
    }
}
