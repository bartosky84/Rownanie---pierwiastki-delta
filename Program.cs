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
            double a, b, c, delta, x1, x2;
            byte liczba_pierwiastkow = 0;

            Console.WriteLine("Program oblicza równanie ax^2+bx+c = 0");

            Console.WriteLine("Podaj liczbe a: ");
            a = double.Parse(Console.ReadLine());

           
            if(a==0)
            {
                Console.Write("Niedozwolona wartość " + a + " Wciśni ENTER");
            }
            else
            {
                Console.WriteLine("Podaj liczbe b: ");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine("Podaj liczbe c: ");
                c = double.Parse(Console.ReadLine());
                delta = b * b - 4 * a * c;
                if (delta < 0) liczba_pierwiastkow = 0;
                if (delta == 0) liczba_pierwiastkow = 1;
                if (delta > 0) liczba_pierwiastkow = 2; 

                switch (liczba_pierwiastkow)
                {
                    case 0:

                        {
                            Console.WriteLine("Dla ");
                            Console.WriteLine("a = {0} ", a);
                            Console.WriteLine("b = {0} ", b);
                            Console.WriteLine("c = {0} ", c);
                            Console.Write("Brak pierwiastków rzeczywistych");
                        }
                        break;
                    case 1:
                        {
                            x1 = -b / (2 * a);
                            Console.WriteLine();
                            Console.WriteLine("a = {0} ", a);
                            Console.WriteLine("b = {0} ", b);
                            Console.WriteLine("c = {0} ", c);
                            Console.Write("Trójmian ma jeden pierwiastek podwojny x1={0:##.##}", x1);
                        }
                        break;
                    case 2:
                        {
                            x1 = (-b - Math.Sqrt(delta)) /(2*a);
                            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                            Console.WriteLine();
                            Console.WriteLine("a = {0} ", a);
                            Console.WriteLine("b = {0} ", b);
                            Console.WriteLine("c = {0} ", c);
                            Console.Write("Trójmian ma jeden pierwiastek podwojny x1={0:##.##} ", x1);
                            Console.Write("Trójmian ma jeden pierwiastek podwojny x2={0:##.##} ", x2);
                        }
                        break;
                       
                }
            }
            Console.Read();

        }
       
    }
}
