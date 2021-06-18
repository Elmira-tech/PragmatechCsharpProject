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
            //Dinamik daxil edilmish reqemleri müqaisə etdim


            Console.WriteLine("Ilk reqemi daxil edin");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci reqemi daxil edin");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Daxil edilen ilk reqem boyukdur");
                Console.ReadLine();
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Daxil edilen ilk reqem kicikdir");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Daxil edilen reqemler beraberdir");
                Console.ReadLine();
            }
        }
    }
}
