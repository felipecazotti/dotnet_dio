using System;

class DIO {

  static void Main(string[] args) {

    double raio, volume;
    const double pi = 3.14159;
    
    raio = double.Parse(Console.ReadLine());
    volume = (4.0/3.0)*pi*raio*raio*raio;
    
    Console.WriteLine("VOLUME = " + volume.ToString("0.000"));
  }
}