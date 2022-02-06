/*DEASFIO*/
//Leia quatro valores inteiros A, B, C e D. 
//A seguir, calcule e mostre a diferença do produto de A e B 
//pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
/*DESAFIO*/

using System;
 
namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
          int A = int.Parse(Console.ReadLine());
          int B = int.Parse(Console.ReadLine());
          int C = int.Parse(Console.ReadLine());
          int D = int.Parse(Console.ReadLine());

          //int produto1 = A*B;
          //int produto2 = C*D;

          int diferenca = (A*B)-(C*D);

        //Declare suas variáveis nos espaços em branco
            Console.WriteLine($"DIFERENCA = {diferenca}");
            Console.ReadKey();
        }
 
       
    }
   
}