using System;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            double ValorCheque, TotalBanco, ValorTotal;
            TotalBanco = 500.00;
            Console.WriteLine("Bem vindo ao banco Banco Jupter, seu saldo atual e de {0:N}",TotalBanco);
            Console.WriteLine("Digite o valor que deseja adicionar");
            ValorCheque = Convert.ToDouble(Console.ReadLine());
            ValorTotal = ValorCheque + TotalBanco;
            Console.WriteLine("O valor total foi de: {0:N}", ValorTotal);
        }
    }
}
