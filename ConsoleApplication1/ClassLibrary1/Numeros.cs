using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Numeros
    {
        public void Multi() 
        {
            int n1, n2;
            Console.WriteLine("Ingrese un numero");
             n1 =int.Parse(Console.ReadLine());
            

             if (n1 == 0)
             {
                 Console.WriteLine("El producto de cero(0) por cualquier numero es cero(0)");
             }
             else
             {
                 Console.WriteLine("Ingrese otro numero");
                 n2 = int.Parse(Console.ReadLine());

                 int resultado = n1 * n2;

                 Console.WriteLine("El resultado del producto es : "+ resultado);

             }
        }
    }
}
