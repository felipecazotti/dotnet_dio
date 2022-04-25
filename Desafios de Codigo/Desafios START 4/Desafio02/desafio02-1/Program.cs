using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nota, quociente, resto;

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            resto = n;
            resto = separaNotas(100, resto);
            resto = separaNotas(50, resto);
            resto = separaNotas(20, resto);
            resto = separaNotas(10, resto);
            resto = separaNotas(5, resto);
            resto = separaNotas(2, resto);
            resto = separaNotas(1, resto);              
        }

        static int separaNotas(int nota, int resto){
            int quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;
            return resto;
        }
    }
}