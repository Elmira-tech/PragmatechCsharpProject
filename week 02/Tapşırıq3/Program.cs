using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapşırıq3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dinamik olaraq daxil edilmish reqemin tek ve ya cut olmasinin yoxlanmasi

            Console.WriteLine("Reqem daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = num % 2;
            
            if(result==0)
            {
                Console.WriteLine("Cut ededdir");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Tek ededdir");
                Console.ReadLine();
            }
        }
    }
}
