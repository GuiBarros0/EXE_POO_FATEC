using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario(1, "gustavo", 1000);
            Console.WriteLine("Bonificação do funcionário: " + f.CalcularBonificacao() );

            Secretario s = new Secretario(2, "rico", 1000);
            Console.WriteLine("Bonificação do secretario: " + s.CalcularBonificacao());

            Gerente g = new Gerente(3, "covalski", 1000);
            Console.WriteLine("Bonificação do gerente: " + g.CalcularBonificacao());

            Diretor d = new Diretor(4, "recruta", 1000, 5);
            Console.WriteLine("Bonificação do diretor: " + d.CalcularBonificacao());

            Console.ReadKey();
        }
    }
}
