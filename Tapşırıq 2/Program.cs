using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapşırıq_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Kənardan dəyər qəbuletmə
            Console.WriteLine("Adınız: ");
                string firstName = Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
                string lastName = Console.ReadLine();
            Console.WriteLine("Universitetiniz: ");
                string uni = Console.ReadLine();
            Console.WriteLine("Yaşınız: ");
                string age = Console.ReadLine();

            Console.WriteLine("Adınız: " + firstName);
            Console.WriteLine("Soyadınız: " + lastName);
            Console.WriteLine("Universitetiniz: " + uni);
            Console.WriteLine("Yaşınız: " + age);
           
            Console.ReadLine();
        }
    }
}
