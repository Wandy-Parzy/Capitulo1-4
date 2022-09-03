using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace parOImpar{
class Program{
    static void Main(string[] args){

        int numero = 0;


        Console.WriteLine("Ingrese un numero: ");
        numero = Int16.Parse(Console.ReadLine());
        
        if(numero%2 ==0){
            Console.WriteLine("Es un numero par ");
        }else {
            Console.WriteLine("Es un numero Impar: ");
        }
        
        }
    }
}