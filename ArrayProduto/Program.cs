using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração do vetor
            Produto[] vetP = new Produto[3];
            //cadastrar elementos dentro do vetor
            for (int i = 0; i < vetP.Length; i++)
            {
                //instancia de cada posição do vetor
                vetP[i] = new Produto();
                Console.Write("Cadastre o código: ");
                vetP[i].codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Cadastre o nome: ");
                vetP[i].nome = Console.ReadLine();
                Console.Write("Cadastre o preço: ");
                vetP[i].preco = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Informe a porcentagem de aumento: ");
            double percent = Convert.ToDouble(Console.ReadLine());
            foreach (Produto p in vetP)
            {
                p.CalcularAumento(percent);
                p.Mostrar();
            }
            Console.Write("Informe o nome a pesquisar: ");
            string n = Console.ReadLine();
            //lógica para pesquisar e alterar
            foreach (Produto p in vetP)
                p.AlterarNome(n);
            //lógica para mostrar o nome após a alteração
            foreach (Produto p in vetP)          
                p.Mostrar();
            Console.ReadKey();
        }
    }
}
