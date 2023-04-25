using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFuncionario //nome do prjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração do vetor
            Funcionario[] vetF = new Funcionario[3];
            //cadastrar elementos dentro do vetor
            for (int i = 0; i < vetF.Length; i++)
            {
                //instancia de cada posição do vetor
                vetF[i] = new Funcionario();
                Console.Write("Cadastre a matrícula: ");
                vetF[i].matricula = Convert.ToInt32(Console.ReadLine());
                Console.Write("Cadastre o nome: ");
                vetF[i].nome = Console.ReadLine();
                Console.Write("Cadastre o salário: ");
                vetF[i].salario = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Informe a porcentagem de aumento: ");
            double percent = Convert.ToDouble(Console.ReadLine());

            foreach (Funcionario f in vetF)
            {
                f.CalcularAumento(percent);
                f.MostrarAtributos();
            }
            Console.ReadKey();
        }
    }
}
