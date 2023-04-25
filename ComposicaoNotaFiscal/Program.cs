using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemNotaFiscal i1 = new ItemNotaFiscal(10);
            ItemNotaFiscal i2 = new ItemNotaFiscal(45);
            List<ItemNotaFiscal> vetItens = new List<ItemNotaFiscal>();
            vetItens.Add(i1);
            vetItens.Add(i2);
            NotaFiscal nf = new NotaFiscal(1, "30/03/2022", vetItens);
            nf = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}
