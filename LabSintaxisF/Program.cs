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

             //6 numeros romanos 

            i0nt num;
            int numaux;
            string romano = string.Empty; ;
            Console.WriteLine("Ingrese el numero que quiere tranformar entre 1 y 3000");        
            num = int.Parse(Console.ReadLine());
            numaux = num;
            while (num != 0)
            {
                romano += Conversor(ref num);
            }
            Console.WriteLine("El numero " + numaux + " es " + romano + " en romano ");
            Console.ReadKey();

            string Conversor (ref int nm)
            {
                

                    if (nm >= 1000) {
                        
                        nm = nm - 1000;
                        return "M";
                }
                    if (nm >= 900) {
                       
                        nm = nm - 900;
                        return "CM";

                }
                    if (nm >= 500) {
                        
                        nm = nm - 500;
                    return "D";
                }

                    if (nm >= 400) {
                        
                        nm = nm - 400;
                    return "CD";
                }

                    if (nm >= 100) {
                        
                        nm = nm - 100;
                    return "C";
                }

                    if (nm >= 90) {
                        
                        nm = nm - 90;
                    return  "XC";
                }
                    if (nm >= 50) {
                        
                        nm = nm - 50;
                    return "L";
                }
                    if (nm >= 40) {
                        
                        nm = nm - 40;
                    return "XL";
                }
                    if (nm >= 10) {
                        
                        nm = nm - 10;
                    return "X";
                }
                    if (nm >= 9) {
                        
                        nm = nm - 9;
                    return "IX";
                }
                    if (nm >= 5) {
                        
                        nm = nm - 5;
                    return "V";
                }
                    if (nm >= 4) {
                        
                        nm = nm - 4;
                    return "IV";
                }
                    if (nm >= 1) {
                        
                        nm = nm - 1;
                    return "I";
                   
                }
                return "No existe"; 
            } 

    
            // 7
             Console.WriteLine("ingrese hasta que numero quiere comprabar numeros primos gemelos.");
            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i != num; i++)
            {                
                if (Esprimo(i))
                {
                    for (int j = i + 1; j != num; j++)
                    {                  
                        if (Esprimo(j))
                        {              
                            if (Esgemelo(i, j))
                            {
                                Console.WriteLine($"({i},{j});");                           
                            }
                                                        
                        }
                    }

                }

            }

            Console.ReadKey();

            bool Esprimo(int val)
            {                
                for (int r = 2; r != val - 1; r++)
                {                  
                    if (val % r == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            bool Esgemelo(int numa, int numb)
            {
                int re;
                re = numb - numa;
                return (re == 2);
            }

            //8

             string texto=string.Empty; 
           string clave = "123456";
           for (int i =0; i < 4; i++)
            {
            texto = Console.ReadLine();
            if (clave == texto) break;
           Console.WriteLine("Clave incorrecta");
            }
            if (clave == texto) Console.WriteLine("Clave correcta");
            Console.ReadKey();





       }
    }
}