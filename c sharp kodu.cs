using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c;

            Console.WriteLine("A sayisini giriniz : ");
            a=double.Parse(Console.ReadLine());
            Console.WriteLine("B sayisini giriniz : ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("C sayisini giriniz : ");
            c = double.Parse(Console.ReadLine());


            if (a>b)
            {
                if (a > c)
               
                Console.WriteLine("Girdiginiz A sayisi olan {0} degeri en buyuktur",a);
                else
                    Console.WriteLine("Girdiginiz C sayisi olan {0} degeri en buyuktur", c);

            }
            else
                if (b>c)
            {
                Console.WriteLine("Girdiginiz B sayisi olan {0} degeri en buyuktur", b);
            }
            else
                Console.WriteLine("Girdiginiz C sayisi olan {0} degeri en buyuktur", c);

        }
    }

   
}
