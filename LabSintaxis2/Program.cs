using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputTexto;
            Console.WriteLine("Por favor, ingrese texto (1)");
            
            inputTexto = Console.ReadLine();
            Console.Clear();

            if (String.IsNullOrEmpty(inputTexto))
            {

                Console.WriteLine("no se ingreso texto,ingrese el texto a continuacion");
                inputTexto = Console.ReadLine();
                Console.Clear();

            }
            else
            {
                Console.WriteLine("El texto es " + inputTexto);
                Console.WriteLine(" Pulse enter para continuar " );
                Console.ReadLine();
                Console.Clear();
            }
            
            Console.WriteLine("Ingrese una opcion a continiacion (CON IF)");
            Console.WriteLine("1) Mostrar frase en mayuscula");
            Console.WriteLine("2) Mostrar frase en minusculas");
            Console.WriteLine("3) Mostrar cantidad de caracteres de la frase");
            

            ConsoleKeyInfo opc = Console.ReadKey();
            Console.Clear();


            string aux;

            if (opc.Key == ConsoleKey.D1)
            {
                aux = inputTexto.ToUpper();
                Console.WriteLine("El texto en mayusculas es " + aux);
                Console.ReadKey();
            }
            else if (opc.Key == ConsoleKey.D2)
            {
                aux = inputTexto.ToLower();
                Console.WriteLine("El texto en minusculas es " + aux);
                Console.ReadLine();
            }
            else if (opc.Key == ConsoleKey.D3)
            {

                Console.WriteLine("La medida del texto " + inputTexto + " es  " + inputTexto.Length);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("error, enter para salir");
                Console.ReadLine();
            }


            Console.Clear();
            Console.WriteLine("Ingrese una opcion a continiacion (CON SWITCH)");
            Console.WriteLine("1) Mostrar frase en mayuscula");
            Console.WriteLine("2) Mostrar frase en minuscula");
            Console.WriteLine("3) Mostrar cantidad de caracteres de la frase");

            ConsoleKeyInfo opc2 = Console.ReadKey();
            Console.Clear();

            switch (opc2.Key)
            {
                case ConsoleKey.D1:
                            aux = inputTexto.ToUpper();
                            Console.WriteLine("El texto en mayusculas es " + aux);
                            Console.ReadKey();
                    break;
                case ConsoleKey.D2:
                        aux = inputTexto.ToLower();
                        Console.WriteLine("El texto en minusculas es " + aux);
                        Console.ReadLine();
                    break;
                case ConsoleKey.D3:
                         Console.WriteLine("La medida del texto " + inputTexto + " es  " + inputTexto.Length);
                         Console.ReadLine();
                     break;  
                 default: 
                     Console.WriteLine("opcion incorrecta ,pulse enter");
                     Console.ReadLine();
                     break;
             }
            






        }
    }


}
     