using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            //insiram/digitem valores para os atributos
            //calcule um aumento de 5% no preco e mostre 
            //o resultado
            Produto p1 = new Produto();
            Console.Write("Digite o código: ");
            p1.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Digite o preço: ");
            p1.Preco = Convert.ToDouble(Console.ReadLine());
            //cálculo de 5% no preço do produto
            //      set     get     get
            p1.Preco = p1.Preco + p1.Preco * 5 / 100;
            //                                get
            Console.Write("Preço final: " + p1.Preco);
            Console.ReadKey();
        }
    }
}
