using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoGabriel = new ContaCorrente ();
            contaDoGabriel.titular = Console.ReadLine();
            contaDoGabriel.agencia = 863;
            contaDoGabriel.numero = 11;

            ContaCorrente contaVinculada = new ContaCorrente ();
            contaVinculada.titular = Console.ReadLine();
            contaVinculada.agencia = 863;
            contaVinculada.numero = 11;

            Console.WriteLine(contaDoGabriel == contaVinculada);

            contaVinculada = contaDoGabriel;
            Console.WriteLine(contaDoGabriel == contaVinculada);

            contaDoGabriel.saldo = 1000;

            Console.WriteLine(contaVinculada.saldo);
            Console.ReadLine();
        }
    }
}
