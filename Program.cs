using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //circulo
            //int r;
            //double A;
            //Console.WriteLine("Coloque o raio:");
            //r = Convert.ToInt32(Console.ReadLine());
            //A = (3.14) * r * r;
            //Console.WriteLine("A área da circunferência é = " + A);
            //Console.ReadLine();

            //triangulo
            //int a;
            //Console.WriteLine("Coloque a medida do lado do triângulo: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //double ate = Math.Sqrt(3) / 4 * (a * a);

            //Console.Write("Área do triângulo equilátero = " + ate);
            //Console.ReadKey();

            //Octagono
            {
                double a;
                Console.WriteLine("Coloque a medida do lado do octagono: ");
                a = Convert.ToDouble(Console.ReadLine());
                double area = 2 * (a * a) * (1 + Math.Sqrt(2));
                Console.Write("A área do octagono de lado " + a + " é : " + area + "\n");
            }
            Console.ReadKey();
        }
    }
}
