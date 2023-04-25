using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFuncionario
{
    class Funcionario
    {
        //declaração de atributos
        public int matricula;
        public string nome;
        public double salario;
        //aqui vai um vetor de dependente

        //declarção de métodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Matricula: " + matricula +
                "\tNome: " + nome + "\tSaldo: " + salario);
        }
        public double CalcularAumento(double porc)
        {
            salario = salario + salario * porc / 100;
            return salario;
        }

    }
}


