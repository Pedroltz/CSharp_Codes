using System;

namespace SoPraFazerTarefa
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pi = 3.14;
            double r;
            double h;
            double Ab;
            double Al;
            double At;


            Console.WriteLine("Digite o valor do raio do 'Cilindro'");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura do 'Cilindro'");
            h = Convert.ToDouble(Console.ReadLine());
            Ab = ((Pi * (r * r)) * 2);
            Al = 2 * Pi * r * h;
            At = Ab + Al;

            Console.WriteLine("Resultado: {0}", At);
        }
    }
}
