using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            while (x > 0)
            {
                if (x%2 == 0){

                    /*
                    Se for par:
                    (x) + (x+2) + (x+4) + (x+6) + (x+8) = 
                    = 5*x + 20
                    */
                    Console.WriteLine(5*x + 20);
                }
                else
                {
                    /*
                    Se for ímpar:
                    (x+1) + (x+3) + (x+5) + (x+7) + (x+9)
                    = 5*x + 25
                    */
                    Console.WriteLine(5*x + 25);
                }
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}