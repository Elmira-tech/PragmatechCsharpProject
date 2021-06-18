using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapshiriq_1
{
    class Program
    {
        struct Person
        {
            public string username;
            public int password;

            public Person(int x )
            {
                username = "Elmira";
                password = 123456;
            }

        }

        static void Main(string[] args)
        {
            // Bir struct tamamlayın, iki propertysi olsun username və password adında.Uyğun olaraq string və int
            // tiplərində.Və həmin property-ləri structun constructorunda initialize edin, hardcore olaraq username və
            // password tamamlayın. Daha sonra console'a "username daxil edin" çıxardın. Dinamik olaraq username daxil edin
            // və dəyişənə mənimsədin. Eyni şəkildə "password daxil edin" çıxardın. Dinamik olaraq password daxil edin və
            // dəyişənə mənimsədin. Daxil edilmiş dəyərləri hardcode yazılmış dəyərlərlə müqaisə edin. Əgər uyğundursa console'a
            // "sayta xoş gəlmisiniz" yazısı çıxardın. Deyilsə "username və password yanlışdır" çıxardın.Bu əməliyyatların
            // hamısını bir programda edin. 

            Person prsn = new Person(5);

            Console.WriteLine("Username daxil edin");
            string Username = Console.ReadLine();
            Console.WriteLine("Password daxil edin");
            int Password = Convert.ToInt32(Console.ReadLine());

            if(prsn.username== Username && prsn.password==Password)
            {
                Console.WriteLine("Sayta xosh gelmisiniz");
            }
            else
            {
                Console.WriteLine("Username ve ya password yanlishdir");
            }
            Console.ReadLine();

        }   
    }
}
