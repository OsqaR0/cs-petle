using System;
namespace Pętle
{
    class Program
    {
        static void Main(string[] args)
        {
            // While | For | Do While
            int a = 0;
            while(a <= 5)
            {
                Console.WriteLine(a);
                Console.WriteLine("Tekst");
                a++;
            }

            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            do
            {
                Console.WriteLine("Text");
            }
            while (false);


            Console.ReadKey();   
        }
    }
}