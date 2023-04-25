using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoArrayFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] vetF = new Funcionario[3];
            //for ....
            // calcule o aumento de salário, aplicando
            //5% a todos eles e apresente o resulado
            for (int i = 0; i < vetF.Length; i++)
            {
                //instancia de cada posição do vetor
                vetF[i] = new Funcionario();
                Console.Write("Cadastre a matrícula: ");
                vetF[i].Matricula = Convert.ToInt32(Console.ReadLine());
                Console.Write("Cadastre o nome: ");
                vetF[i].Nome = Console.ReadLine();
                Console.Write("Cadastre o salário: ");
                vetF[i].Salario = Convert.ToDouble(Console.ReadLine());
            }
            foreach (Funcionario f in vetF)
            {
                f.Salario = f.Salario + f.Salario * 5 / 100;
                Console.WriteLine("Matricula: " + f.Matricula +
                "\tNome: " + f.Nome + "\tSaldo: " + f.Salario);
            }
            Console.ReadKey();
        }
    }
}
