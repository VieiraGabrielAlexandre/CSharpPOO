using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = Convert.ToInt16(Console.ReadLine());
            int agencia = Convert.ToInt16(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(numero, agencia);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            Console.WriteLine(ContaCorrente.TotalContasCriadas);

            Console.ReadLine();
        }
    }
}
