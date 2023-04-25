using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();//instanciação de objeto
            f1.matricula = 1;
            f1.nome = "Bia";
            f1.salario = 1000;
            Console.Write("Informe a porcentagem de aumento: ");
            Console.WriteLine("Novo salário R$ " + 
                f1.CalcularAumento(Convert.ToDouble(Console.ReadLine())));
            //f1.MostrarAtributos();

            Console.ReadKey();

            //Calcular o aumento salarial do funcionário
            //crie um método que receba o parâmetro da
            //porcentagem e retorne o salario novo que será 
            //apresentado na main, não use para este caso
            //o método mostrar
        }
    }
}
