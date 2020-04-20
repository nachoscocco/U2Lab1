using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxisF
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 1) Sumatoria de 2 numeros
            int num1;
            int num2;
            Console.WriteLine("ingrese el num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el num2");
            num2 = int.Parse(Console.ReadLine());
            int aux = num1 + num2;
            Console.Clear();
            Console.WriteLine("El resultado de la suma de " + num1 + " y " + num2 + " es " + aux);
            Console.ReadKey();
/*
            // 2) Año biciesto
            int anio;
            Console.WriteLine("ingrese el año a ver");
            anio = int.Parse(Console.ReadLine());
            if (anio % 4 == 0)
            {
                if (anio % 100 == 0)
                {
                    if (anio % 400 == 0) { Console.WriteLine("Año(div 400) " + anio + "es bisiesto");
                        Console.ReadKey();
                    }
                    else { Console.WriteLine("Año(div 400) " + anio + "NO es bisiesto");
                        Console.ReadKey();
                    }
                }
                else { Console.WriteLine("Año(div 100) " + anio + "si es bisiesto");
                    Console.ReadKey();
                }

            }
            else { Console.WriteLine("Año(div 4) " + anio + "NO es bisiesto");
                Console.ReadKey();
            }

            // 3)Sumatoria de Fibonacci

            int fib = 0;
            int fib2 = 1;
            int numSuma;

            Console.WriteLine("ingrese la cantidad de repeticiones para calcular a el numero de fibonacci");
            numSuma = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSuma; i++)
            {
                int auxFib = 0;
                auxFib = fib + fib2;
                fib = fib2;
                fib2 = auxFib;
            }
            numSuma = numSuma + 2;
            Console.WriteLine("el numero de Fibonacci en la posicion " + numSuma + " es " + fib2);
            Console.ReadKey();
            

            // 4) Numeros pares de 1 a 100

            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0) { Console.WriteLine(i); }

            }
            Console.ReadKey();  

            // 5) Numero de mes a string

            int numeroMes;
            Console.WriteLine("Ingrese el numero de mes ");
            numeroMes = int.Parse(Console.ReadLine());
            switch (numeroMes)
            {
                case 1:
                    Console.WriteLine("Mes 1 es Enero");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Mes 2 es Febrero");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Mes 3 es Marzo");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Mes 4 es Abril");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Mes 5 es Mayo");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Mes 6 es Junio");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine("Mes 7 es Julio");
                    Console.ReadKey();
                    break;
                case 8:
                    Console.WriteLine("Mes 8 es Agosto");
                    Console.ReadKey();
                    break;
                case 9:
                    Console.WriteLine("Mes 9 es Septiembre");
                    Console.ReadKey();
                    break;
                case 10:
                    Console.WriteLine("Mes 10 es Octubre");
                    Console.ReadKey();
                    break;
                case 11:
                    Console.WriteLine("Mes 11 es Noviembre");
                    Console.ReadKey();
                    break;
                case 12:
                    Console.WriteLine("Mes 12 es Diciembre");
                    Console.ReadKey();
                    break;
            }


    */








       }
    }
}