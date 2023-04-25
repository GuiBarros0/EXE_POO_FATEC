using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            // método set
            c1.Numero = 103;
                                    // método get
            Console.WriteLine("Número: "+c1.Numero);
            c1.Titular = "Ana";
            c1.Saldo = 1000;
            Console.WriteLine("Titular: " + c1.Titular);
            Console.WriteLine("Saldo: " + c1.Saldo);
            Console.ReadKey();
        }
    }
}
