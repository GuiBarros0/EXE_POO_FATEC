using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Cliente c = new Cliente();
            c.Codigo = 1;
            c.Nome = "Ana";
            c.Mostrar();

            ClienteFisico cf = new ClienteFisico();
            cf.Codigo = 2;
            cf.Nome = "Bia";
            cf.Rg = 22;
            cf.Cpf = 2222;
            cf.Mostrar();*/

            Cliente c2 = new Cliente(3, "Lia");
            c2.Mostrar();

            ClienteFisico cf2 = new ClienteFisico(4,
                "Leo", 44, 4444);
            cf2.Mostrar();

            ClienteJuridico cj2 = new ClienteJuridico(5,
                "Fatec", 5555, 55);
            cj2.Mostrar();
            Console.ReadKey();
        }
    }
}
