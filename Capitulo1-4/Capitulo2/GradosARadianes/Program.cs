using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace GradosARadianes{
class Program{
    static void Main(string[] args){

        double grados = 0, radianes = 0;


        Console.WriteLine("Ingrese los grados que descea convertir a radianes: ");
        grados = Convert.ToInt32(Console.ReadLine());

        radianes = 3.141592 * grados;
        radianes /= 100;

        Console.WriteLine("El resultado  en radianes es: "+ radianes);
        
        }
    }
}