using System;
using System.Collections.Generic;
using System.Linq;

class MinhaClasse {
  public static void Main (string[] args) {
    var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
    for (int i = 0; i < totalDeCasosDeTeste; i++){
        List<string> itens = Console.ReadLine().Split(" ").ToList();
        itens = itens.Distinct().OrderBy(x => x).ToList();
        foreach (string item in itens){
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
  }
}