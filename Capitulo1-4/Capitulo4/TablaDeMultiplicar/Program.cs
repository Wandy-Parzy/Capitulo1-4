using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TablaDemultiplicar{
class Program{
    static void Main(string[] args){

        int numero = 0, resultado;


        Console.WriteLine("Ingrese un numero: ");
         numero = Convert.ToInt32(Console.ReadLine());
        
        for(int i=1;i<=10;i++){
           resultado = numero*i;
             Console.WriteLine($"{numero} x {i} = {resultado}");
        }
        
        }
    }
}