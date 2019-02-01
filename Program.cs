using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un el numero del ejercicio");
            double ejercicio = double.Parse(Console.ReadLine());
            
            if (ejercicio == 1)
            {
                Console.WriteLine("Para calcular su tarifa escriba su salario");
                double salario = double.Parse(Console.ReadLine());

                if (salario < 1656232)
                {
                    Console.WriteLine("Su tarifa es A");
                }
                else if (salario < 3312464)
                {
                    Console.WriteLine("Su tarifa es B");
                }
                else
                {
                    Console.WriteLine("Su tarifa es C");
                }
            }
            else if (ejercicio == 2)
            {
                Console.WriteLine("Para calcular su tarifa y su cuota moderadora escriba su salario");
                double salario = double.Parse(Console.ReadLine());

                if (salario < 1656232)
                {
                    Console.WriteLine("Su tarifa es A");
                    Console.WriteLine("su valor de cuota moderadora es");
                    Console.WriteLine("3230");
                }
                else if (salario < 4140580)
                {
                    Console.WriteLine("Su tarifa es B");
                    Console.WriteLine("su valor de cuota moderadora es");
                    Console.WriteLine("12725");
                }
                else
                {
                    Console.WriteLine("Su tarifa es C");
                    Console.WriteLine("su valor de cuota moderadora es");
                    Console.WriteLine("33539");
                }
            }
            else
            {
                Console.WriteLine("Reinicie y escriba solo 1 o 2");
            }
        }
    }
}
