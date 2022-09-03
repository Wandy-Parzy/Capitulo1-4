using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PromedioDeEdad{
class Program{
    static void Main(string[] args){

        int edad = 0 ,total, x = 0, promedio = 0;
        //int menor, mayor;

        Console.WriteLine("Ingrese el total: ");
            total = Convert.ToInt32(Console.ReadLine());

       while(x <= total){
            Console.WriteLine("Ingrese su edad: ");
               edad = Convert.ToInt32(Console.ReadLine());
            promedio += edad;
                x +=1;
       }
         Console.WriteLine("El promedio de edades es: " + edad / total);
          
        }
    }
}