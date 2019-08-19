using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        { 

            ContaCorrente contaDoGabriel = new ContaCorrente();
            contaDoGabriel.titular = Console.ReadLine();
            Console.WriteLine(contaDoGabriel.titular);
            Console.WriteLine(contaDoGabriel.saldo);

            Console.ReadLine();
        }
    }
}
