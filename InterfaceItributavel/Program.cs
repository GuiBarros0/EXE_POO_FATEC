using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceItributavel
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            Itributavel it = cc;
            cc.Saldo = 100;
            Console.WriteLine(cc.CalculaTributos());

            SeguroDeVida sg = new SeguroDeVida();
            it = sg;
            Console.WriteLine(sg.CalculaTributos());

            
            TotalizadorDeTributos tt = new TotalizadorDeTributos();
            Console.WriteLine("Total de Tributos é: " + tt.Total);

            Console.ReadKey();


        }
    }
}
