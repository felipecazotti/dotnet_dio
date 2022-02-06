using System;
using System.Collections.Generic;

public class Problem {
    public static void Main() {

        List<string> meses = new List<string> {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};

        int mes = int.Parse(Console.ReadLine());

        if (mes < 1 || mes > 12){
            Console.WriteLine("Digite um número válido de 1 a 12");
        }
        else{
            Console.WriteLine(meses[mes-1]);
        }
            Console.ReadLine();
    }
}