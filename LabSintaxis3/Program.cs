using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones=5;
            string[] vec = new string[5];
            for (int i = 0; i < cantIteraciones; i++)
            {
                int aux = i + 1;
                Console.WriteLine("ingrese el elemento" + aux );
                vec[i] = Console.ReadLine();
                Console.Clear();

            }
            for (int i = cantIteraciones - 1; i < cantIteraciones; i--)
            {
              
                          
               int aux = i + 1  ;
                 Console.WriteLine("el elemento numero " + aux + " es " + vec[i]);
                 Console.ReadKey();   
                if (i==0){break;} 
             }

        }
    }
}
