using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CarculandoPerimetro{
class Program{
    static void Main(string[] args){

        int a = 0, b = 0;
        int perimetro = 0;
         

        Console.WriteLine("Lados del perimetro: ");
        a = Int16.Parse(Console.ReadLine());

        Console.WriteLine("Longitud de un dado: ");
        b = Int16.Parse(Console.ReadLine());

        perimetro = a * b;
        Console.WriteLine("El resultado es: "+ perimetro);
        
        }
    }
}