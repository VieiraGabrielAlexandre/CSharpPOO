using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            Console.WriteLine("Digite o saldo da conta: ");
            double valor = Convert.ToInt32(Console.ReadLine());
            conta.SetSaldo (valor);

            Console.WriteLine(conta.GetSaldo());

            Console.ReadLine();
        }
    }
}
