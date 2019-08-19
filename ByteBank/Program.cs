using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoGabriel = new ContaCorrente();

            Console.WriteLine("Digite o titular: ");
            contaDoGabriel.titular = Console.ReadLine();

            Console.WriteLine("Digite o numero da conta: ");
            contaDoGabriel.numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o numero da agencia: ");
            contaDoGabriel.agencia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Saldo: ");
            contaDoGabriel.saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Titular = " + contaDoGabriel.titular);
            Console.WriteLine("Numero = " + contaDoGabriel.numero);
            Console.WriteLine("Agencia = " + contaDoGabriel.agencia);
            Console.WriteLine("Saldo = " + contaDoGabriel.saldo);

            Console.WriteLine("Deseja acrescentar saldo ? 1(SIM)/2(NÃO)");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    Console.WriteLine("Digite o valor a acrescentar: ");
                    int acrescimo = Convert.ToInt32(Console.ReadLine());
                    contaDoGabriel.saldo += acrescimo;
                    Console.WriteLine("O valor atualizado é = " + contaDoGabriel.saldo);
                    break;
                case 2:
                    Console.WriteLine("Finalizando ...");
                    break;
            }
            Console.ReadLine();
        }
    }
}
