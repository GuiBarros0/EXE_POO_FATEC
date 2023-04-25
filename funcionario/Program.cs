using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario(3, "gustavo", 55.55);
            f1.Mostrar();

            Mensalista ff2 = new Mensalista(4,
                "gusta", 105.55, "5 horas");
            ff2.Mostrar();

            Horista ff3 = new Horista(5,
                "gu", 550.55, "60 horas");
            ff3.Mostrar();
            Console.ReadKey();
        }
    }
}
