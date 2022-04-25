using System;

class minhaClasse {

    static void Main(string[] args) { 

            double a, b, c;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if (a + b > c && a + c > b && b + c > a)
            {
                double perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("00.0"));
            }
            else
            {
                double area = ((a + b) * c)/2;
                Console.WriteLine("Area = " + area.ToString("00.0"));
            }
    }
}