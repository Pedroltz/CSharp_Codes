using System;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 8;
            int c = -9;

            double delta = (b * b) - (4 * a * c);
            double raiz = Math.Sqrt(delta);
            var x1 = ((-(b)) + raiz) / (2 * a);
            var x2 = ((-(b)) - raiz) / (2 * a);

            Console.WriteLine("Valor de X': {0}", x1);
            Console.WriteLine("Valor de X'': {0}", x2);
        }
    }
}
