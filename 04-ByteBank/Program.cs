    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args) 
        {
            ContaCorrente conta = new ContaCorrente();
            ContaCorrente destino = new ContaCorrente();

            Console.WriteLine("Digite o nome do titular: ");
            conta.titular = Console.ReadLine();

            Console.WriteLine("Digite o saldo: ");
            conta.saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do saque: ");
            double saque = Convert.ToDouble(Console.ReadLine());

            string resultado;
            if (conta.Sacar(saque) == true)
            {
                resultado = "Saque realizado com sucesso";
            }
            else resultado = "Não foi possivel realizar o saque";

            Console.WriteLine("Nome: " + conta.titular);
            Console.WriteLine("Saldo atual: " + conta.saldo);
            Console.WriteLine("Total do Saque: " + saque);
            Console.WriteLine("O Saque foi possivel: " + resultado);


            Console.WriteLine("Deseja depositar valores ? 1-Sim 2-Não");
            int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao) {
                case 1:
                    Console.WriteLine("Digite o valor do deposito: ");
                    double deposito = Convert.ToInt32(Console.ReadLine());
                    destino.saldo += deposito;
                    break;
                case 2:
                    Console.WriteLine("Muito obrigado !");
                    break;
                }
            Console.WriteLine("Saldo destino: " + destino.saldo);
            Console.WriteLine("Saldo atual: " + conta.saldo);

            ContaCorrente contaDestino = new ContaCorrente();

            Console.WriteLine("Deseja tranferir valores ? 1-Sim 2-Não");
            int opcao2 = Convert.ToInt32(Console.ReadLine());
            switch (opcao2)
            {
                case 1:
                    Console.WriteLine("Digite a conta de destino:");
                    int numeroContaDestino = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor dq transferencia: ");
                    double valorTransferencia = Convert.ToDouble(Console.ReadLine());
                    
                    conta.Transferir(valorTransferencia,destino);
                    Console.WriteLine("Destino: " + destino.saldo);
                    Console.WriteLine("Valor Atual: " + conta.saldo);
                    break;
                case 2:
                    Console.WriteLine("Muito obrigado !");
                    break;
            }

            Console.ReadLine();
        }
    }
}
