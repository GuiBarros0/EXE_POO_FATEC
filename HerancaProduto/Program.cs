using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(1, "Mouse", 130);
            p.Mostrar();
            Perecivel pe = new
                Perecivel(2, "mussarela",15, 
                "09/04/2022","14/04/2022",1);
            pe.Mostrar();
            Console.ReadKey();
        }
    }
}
