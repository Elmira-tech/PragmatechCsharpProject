using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapşırıq_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adını öyrəndiyim şəxsə onun adını çəkərək salam verdim.
            Console.WriteLine("Adınız: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
            string lastName = Console.ReadLine();
           

            Console.WriteLine(firstName + " " +lastName + " "+"Salamlarrr");
            
            Console.ReadLine();
        }
    }
}
