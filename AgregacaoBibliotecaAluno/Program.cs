using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoBibliotecaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            Console.Write("Informe a matrícula: ");
            a1.Matricula = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o nome: ");
            a1.Nome = Console.ReadLine();

            Biblioteca b1 = new Biblioteca();
            Console.Write("Informe o código: ");
            b1.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o nome: ");
            b1.Nome = Console.ReadLine();
            b1.Alunos = a1;//Agregação
            //////////////////
            // ou
            //////////////////
            Biblioteca b2 = new Biblioteca();
            Console.Write("Informe o código: ");
            b2.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o nome: ");
            b2.Nome = Console.ReadLine();
            b2.Alunos = new Aluno();//agregação
            Console.Write("Informe a matrícula: ");
            b2.Alunos.Matricula = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o nome: ");
            b2.Alunos.Nome = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
