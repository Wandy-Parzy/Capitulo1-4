using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace NumeroALaPotencia{
class Program{
    static void Main(string[] args){

        int numero = 0;
        Console.WriteLine("Ingrese un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        double NumPotencia = Math.Pow(numero, 2);
        Console.WriteLine("El numero: " + numero + " elvado a la potencia es:"+ NumPotencia);
        }
    }
}