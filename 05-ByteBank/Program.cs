using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            ContaCorrente conta = new ContaCorrente();

            Console.WriteLine("Digite o nome do Cliente: ");
            string titular = Console.ReadLine();
            cliente.nome = titular;

            Console.WriteLine("Digite o CPF: ");
            string cpf = Console.ReadLine();
            cliente.cpf = cpf;

            Console.WriteLine("Digite a profissão:");
            string profissao = Console.ReadLine();
            cliente.profissao = profissao;

            Console.WriteLine("Nome: " + cliente.nome);
            Console.WriteLine("CPF: " + cliente.cpf);
            Console.WriteLine("Profissão: " + cliente.profissao);

            conta.titular = cliente;

            Console.WriteLine("Acessando a instancia cliente atrave de conta");

            Console.WriteLine("Digite o numero da Agencia: ");
            conta.agencia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o numero da Conta:");
            conta.numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Saldo: ");
            conta.saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Numero da agencia: " + conta.agencia);
            Console.WriteLine("Numero da conta: " + conta.numero);
            Console.WriteLine("Saldo: " + conta.saldo);
            
            
            Console.ReadLine();
            
        }
    }
}
