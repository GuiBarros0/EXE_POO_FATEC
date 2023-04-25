using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoContaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Ana", 
                               "222", "123");
            Conta conta = new Conta(1, cliente1, 100);
            Cliente cliente2 = new Cliente();
            cliente2.Nome = "";
        }
    }
}
