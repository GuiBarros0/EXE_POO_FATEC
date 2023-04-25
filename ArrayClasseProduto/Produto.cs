using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClasseProduto
{
    class Produto
    {
        //declaração de atributos
        public int codigo;
        public string nome;
        public double preco;
        //declaração do vetor
        public Produto[] vetP = new Produto[3];

        //declaração dos métodos
        public void Cadastrar()
        {
            for (int i = 0; i < vetP.Length; i++)
            {
                vetP[i] = new Produto();
                Console.Write("Digite o código: ");
                vetP[i].codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o nome: ");
                vetP[i].nome = Console.ReadLine();
                Console.Write("Digite o preço: ");
                vetP[i].preco = Convert.ToDouble(Console.ReadLine());
                Console.Write("vetp " + vetP[i].preco);
            }
        }       


           
        public void Mostrar()
        {
            for (int i = 0; i < vetP.Length; i++)
                Console.WriteLine("Código: " + vetP[i].codigo +
                                "\tNome: " + vetP[i].nome + 
                                "\tPreço R$ " + vetP[i].preco);
        }
    }
}
