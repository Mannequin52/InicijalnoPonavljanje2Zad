using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalni2_4D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Napišite program u kojem ćete zatražiti od korisnika
             * da unese niz znakova te će svaki razmak zamijeniti znakom '_'.*/
            
            Console.WriteLine("Unesi rečenicu: ");
            string a = Console.ReadLine();
            string b = a.Replace(" ", "_");
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
