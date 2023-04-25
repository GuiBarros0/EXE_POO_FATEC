using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.Mostrar();
            Aluno a2 = new Aluno("Bia");
            a2.Mostrar();
            Aluno a3 = new Aluno("Ana",9.5);
            a3.Mostrar();
            Console.WriteLine("Quantidade de intâncias? " + Aluno.Contador);
            Console.ReadKey();
        }
    }
}
