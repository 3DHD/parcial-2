using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class nombres
    {
        public void Nombres() 
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese los nombres de los alumnos");

                string alum1 = Convert.ToString(Console.ReadLine());
                string alum2 = Convert.ToString(Console.ReadLine());
                string alum3 = Convert.ToString(Console.ReadLine());
                string alum4 = Convert.ToString(Console.ReadLine());
                string alum5 = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Los nombres de los alumnos son : "+ alum1);
                Console.WriteLine("Los nombres de los alumnos son : "+ alum2);
                Console.WriteLine("Los nombres de los alumnos son : "+alum3);
                Console.WriteLine("Los nombres de los alumnos son : "+ alum4);
                Console.WriteLine("Los nombres de los alumnos son : "+ alum5);
                Console.ReadKey();

            }
            
        }
    }
}
