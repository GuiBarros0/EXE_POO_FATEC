using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProduto
{
    class Produto
    {
        //declaração de atributos
        public int codigo;
        public string nome;
        public double preco;

        //declaração dos métodos
        public void Mostrar()
        {
            Console.WriteLine("Código: " + codigo +
                "\tNome: " + nome + "\tPreço R$ " + preco);
        }
        public double CalcularAumento(double porc)
        {
            preco = preco + preco * porc / 100;
            return preco;
        }

        public void AlterarNome(string nomePesquisa)
        {
            // se o nome a alterar for diferente de vazio
            if (!nomePesquisa.Equals("") && nome == nomePesquisa)
            {
                Console.Write("Informe o nome para alteração: ");
                nome = Console.ReadLine();
            }
        }

    }
}
