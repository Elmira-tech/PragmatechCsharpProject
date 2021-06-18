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
            // Dinamik olaraq daxil edilmish reqemlerin menfi ve ya musbet olmasinin yoxlanmasi

            Console.WriteLine("Reqem daxil edin");
            int numeral = Convert.ToInt32(Console.ReadLine());

            if (numeral < 0)
            {
                Console.WriteLine("Menfi ededdir");
                Console.ReadLine();
            }
            else if(numeral == 0)
            {
                Console.WriteLine("Sifir neytral ededdir");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Musbet ededdir");
                Console.ReadLine();
            }
        }
    }
}
