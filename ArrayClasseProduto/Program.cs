using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClasseProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Cadastrar();

            foreach (Produto objetoProduto in p.vetP)
                objetoProduto.Mostrar();
            Console.ReadKey();



        }
    }
}
