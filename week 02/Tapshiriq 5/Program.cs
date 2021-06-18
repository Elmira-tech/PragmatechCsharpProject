using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapshiriq_5
{
    class Program
    {
        struct Student
        {
            public int grade;

            public Student (int x)
            {
                this.grade = x;

            }
        }

        static void Main(string[] args)
        {
            //Student adında bir struct tamamlayın və onun imtahan balı (grade) adında bir propertysi olsun.
            //Ona kənardan dinamik olaraq 100 bal limitində bir ədəd mənimsədin. 
            //Həmin ədədi universitet imtahanlarında bir fəndən yığılan bala görə yoxlayın.

            Student stud = new Student();

            Console.WriteLine("Telebenin topladigi bali daxil edin");
            stud.grade = Convert.ToInt32(Console.ReadLine());

            if(stud.grade>100)
            {
                Console.WriteLine("Toplanan bal 100den boyuk ola bilmez");
                Console.ReadLine();
            }
            else if (stud.grade < 100 && stud.grade >= 90)
            {
                Console.WriteLine("Netice: A");
                Console.ReadLine();
            }
            else if (stud.grade < 90 && stud.grade >= 80)
            {
                Console.WriteLine("Netice: B");
                Console.ReadLine();
            }
            else if (stud.grade < 80 && stud.grade >= 70 )
            {
                Console.WriteLine("Netice: C");
                Console.ReadLine();
            }
            else if (stud.grade < 70 && stud.grade >= 60)
            {
                Console.WriteLine("Netice: D");
                Console.ReadLine();
            }
            else if (stud.grade < 60 && stud.grade >= 50)
            {
                Console.WriteLine("Netice: E");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Netice: F Teessufler olsun ki, kesildiniz");
                Console.ReadLine();
            }
        }
    }
}
