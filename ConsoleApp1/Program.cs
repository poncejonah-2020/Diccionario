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

            Console.WriteLine(personas[1]);
        }
    }
}
