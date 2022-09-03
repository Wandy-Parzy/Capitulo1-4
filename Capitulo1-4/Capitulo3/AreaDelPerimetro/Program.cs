using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AreaDelPerimetro{
class Program{
    public static void Main(string[] args){

       bool salir = false;
 
            while (!salir) {
   
                    Console.WriteLine("Que decea calcular");
                    Console.WriteLine("1.Perimetro");
                    Console.WriteLine("2.Area");
                    Console.WriteLine("3. Salir");
                    int opcion = Convert.ToInt32(Console.ReadLine());
 
                    switch (opcion)
                    {
                        case 1:
                            Perimetro();
                            break;
 
                        case 2:
                             Area();
                            break;

                        case 3:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 4");
                            break;
                    }
 
                }
                 
            }
 

         public  static void Perimetro(){
            float lados, longitud,  perimetro = 0;

            Console.WriteLine("Ingrese los lados: ");
                lados = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Ingrese la longitud de los lados: ");
                longitud = Convert.ToInt32(Console.ReadLine());

            perimetro = lados * longitud;   
            Console.WriteLine("El perimetro del poligono es: "+ perimetro); 

            
        
         }

           public static void Area(){
             double lados, longitud, apotema,  perimetro = 0;

            Console.WriteLine("Ingrese el numero de los lados: ");
                lados = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Ingrese la longitud de los lados: ");
                longitud = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la apotema : ");
                 apotema = Convert.ToInt32(Console.ReadLine());

            perimetro = lados * longitud * apotema;   
            Console.WriteLine("El perimetro del poligono es: "+ perimetro); 

            
           }

        }


    }
    
