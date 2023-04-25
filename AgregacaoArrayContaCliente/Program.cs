using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoArrayContaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.Nome = "Ana";
            c1.Rg = "11";
            c1.Cpf = "1111";
            Cliente c2 = new Cliente();
            c2.Nome = "Bia";
            c2.Rg = "22";
            c2.Cpf = "2222";
            Conta conta = new Conta();
            conta.Numero = 1;
            conta.Saldo = 100;
            conta.Titular = new List<Cliente>();
            conta.Titular.Add(c1);//agregação
            conta.Titular.Add(c2);//agregação
            foreach (Cliente cli in conta.Titular)
            {
                Console.WriteLine("Nome: "+cli.Nome);
            }
            Console.ReadKey();
        }
    }
}
