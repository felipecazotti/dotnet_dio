using System;
using System.Linq;
using System.Collections.Generic;

class Program {
  
  static void Main(string[] args) {
    List<string> listaJoias = new List<string>();
    string joia = Console.ReadLine();
    while(!String.IsNullOrEmpty(joia)){
      listaJoias.Add(joia);
      joia = Console.ReadLine();
    }
    List<string> listaJoiasDistintas = listaJoias.Distinct().ToList();

    Console.WriteLine(listaJoiasDistintas.Count);
  }
}