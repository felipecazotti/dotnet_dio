using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
              int esferas = 0;
              int quantidade = int.Parse(Console.ReadLine());
              for (int estrelas = 1; estrelas <= quantidade; estrelas++)
              {
                int divisores = 0;
                for (int j = 1; j <= estrelas; j++)
                {
                  if (estrelas%j == 0) divisores++;
                }
                if (divisores%2 == 0) esferas++; 
              }
              Console.WriteLine(esferas);
            }
        }
    }
}
