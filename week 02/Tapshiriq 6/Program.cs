using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapshiriq_6
{
    class Program
    { 
        

        public struct Person
        {
            public string Name;
            public string Username;
            public int Age;
            public Person (int age)
            {
                Name = "Elmira";
                Username = "Mammadova";
                Age = age;
               
            }

        }
        static void Main(string[] args)
        {
            //Person adında struct götürün, name, username, age adında propertyləri olsun.
            //Name və username constructorun içində initialize edilsin və
            //hardcode dəyərlər alsın. Age isə constructor çağrıldıqdan sonra dinamik olaraq kənardan daxil edilsin.
            //Daha sonra name və username adında iki dəyişən götürün və onlara da dinamik dəyərlər mənimsədin. Əvvəlcə girilən ad soyadın
            //qabaqcadan götürülmüş ad soyadla üst üstə düşüb düşmədiyini yoxlayın. Daha sonra əgər result true olarsa age-i yoxlayın.
            //18dən kiçikdirsə "sizin yaşınız uyğun deyil" çıxardın. Böyük olarsa uyğundur çıxardın

            Person prsn = new Person(18);
            Console.WriteLine("Adinizi daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Istifadeci adinizi daxil edin");
            string username = Console.ReadLine();

            if (prsn.Name==name && prsn.Username==username)
            {
                Console.WriteLine("Yashinizi daxil edin");
                int x = Convert.ToInt32(Console.ReadLine());
                if(x>prsn.Age)
                    Console.WriteLine("Xosh gelmisiniz");
                else 
                    Console.WriteLine("Yashiniz uygun deyil");
                   

            }
            else
            {
                Console.WriteLine("Istifadeci adiniz yanlishdir");
            }
            Console.ReadLine();
        
        } 
       
    }
}
