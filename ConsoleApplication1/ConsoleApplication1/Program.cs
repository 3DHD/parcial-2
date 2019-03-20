using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibery1;
       

namespace ConsoleApplication1
{
    class Program
    {
        int opc = 0;
        static void Main(string[] args)
        {
            

            Console.WriteLine("Bienvenido al parcial");
            Console.WriteLine("Seleccione un numero");
            Console.WriteLine("1) Multiplique 2 numeros");
            Console.WriteLine("2) Dividir dos numeros");
            Console.WriteLine("3) Captura de nombres");
            Console.WriteLine("4) Captura de edades");
            Console.WriteLine("5) ingrese un numero");

            int opc= int.Parse(Console.ReadLine());
            
            switch (opc)
            {
                
                case 1:

                    Console.WriteLine("Usted a seleccionado el ejercicio 1");
                    Numeros obj1 = new Numeros();
                    obj1.Multi();
                    break;

                case 2:
                    Console.WriteLine("Usted a elejido el ejercicio 2");
                    enteros obj2 = new enteros();
                    obj2.Usuarios();
                    break;

                case 3:
                    Console.WriteLine("Usted a elejido el ejercicio 3");
                    nombres obj3 = new nombres();
                    obj3.Nombres();
                    break;
                case 4 :
                    Console.WriteLine("Usted a elejido el ejercicio 4");
                    edades obj4 = new edades();
                    obj4.Edades();
                    break;                          
                default:
                    break;
            }
        }
    }
}
