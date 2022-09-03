using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DolarAEuro{
class Program{
    static void Main(string[] args){

        float dolar = 0, cantidad = 0, cambio = 0;
       
        Console.WriteLine("Ingrese el tipo de cambio del dia: ");
        cambio = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Ingrese la candidad que decea a convertir: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

         dolar = cantidad / cambio;
        Console.WriteLine("La conversion en dolar es igual a: "+ dolar);
        
        }
    }
}