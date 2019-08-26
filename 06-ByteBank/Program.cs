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
            conta.Saldo = valor;
            Console.WriteLine(conta.Saldo);

            Cliente cliente = new Cliente();
            Console.WriteLine("Digite o nome:");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF:");
            cliente.CPF = Console.ReadLine();
            Console.WriteLine("Digite a Profissao");
            cliente.Profissao = Console.ReadLine();

            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Titular.CPF);
            Console.WriteLine(conta.Titular.Profissao); 

            Console.ReadLine();
        }
    }
}
