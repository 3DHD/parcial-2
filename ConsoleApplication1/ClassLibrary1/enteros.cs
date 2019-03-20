using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public  class enteros
    {
        public void Usuario() 
        {
            Console.WriteLine("Ingrese dos numeros enteros ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (n2 != 0)
            {
                int resultado = n1 / n2;
            }
            else
            {
                Console.WriteLine("Error no se puede dividir entre ceros");
            }

        }
    }
}
