using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> personas = new Dictionary<int, string>();
            personas.Add(1, "julia");
            personas.Add(2, "martin");
            personas.Add(3, "jonah");
            personas.Add(4, "yesica");
            personas.Add(5, "sebas");

            Console.WriteLine(personas[1]);
            Console.ReadKey();

            personas.Remove(2);

            if(personas.Remove(3))
            {
                Console.WriteLine("el elemento fue eliminado");
            }
            else
            {
                Console.WriteLine("el elemento no fue encontrado");
            }

            foreach(KeyValuePair<int, string> elemento in personas)
            {
                Console.WriteLine("clave " + elemento.Key + ":" + elemento.Value);
            }
        }
    }
}
