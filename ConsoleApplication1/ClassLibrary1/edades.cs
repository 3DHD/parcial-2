using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class edades
    {
       public void Edades() 
       {
           for (int i = 0; i < 5; i++)
           {
               Console.WriteLine("Ingrese las edades de los alumnos");
               int alum1 = Convert.ToInt32(Console.ReadLine());
               int alum2 = Convert.ToInt32(Console.ReadLine());
               int alum3 = Convert.ToInt32(Console.ReadLine());
               int alum4 = Convert.ToInt32(Console.ReadLine()); 
               int alum5 = Convert.ToInt32(Console.ReadLine());


               Console.WriteLine("Las edades de los alumnos son : "+ alum1);
               Console.WriteLine("Las edades de los alumnos son : " + alum2);
               Console.WriteLine("Las edades de lños alumnos son : " + alum3);
               Console.WriteLine("Las edades de los alumnos son : " + alum4);
               Console.WriteLine("Las edades de los alumnos son : " + alum5);
               Console.ReadKey();
           }
       }
    }
}
