using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    class Program
    {

        static void Main(string[] args)
        {
            //nunca instancie um objeto de uma Super classe abstract
            //Cliente c = new Cliente();

            ClienteFisico cf = new ClienteFisico(1, "Kovalski", 33, 46194432);
            

            cf.Mostrar();

            Teste t = new Teste();
            Console.WriteLine("cliente fisico: " + t.AnalisarIdade(cf));

            ClienteJuridico cj = new ClienteJuridico(1, "rico", 60, 5544778);

            cj.Mostrar();

            Teste t2 = new Teste();
            Console.WriteLine("Cliente Juridico: " + t2.AnalisarIdade(cj));

            Console.ReadKey();
        }
    }
}
