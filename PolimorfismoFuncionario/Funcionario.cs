using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    class Funcionario
    {
        protected int codigo;
        protected string nome;
        protected double salario;

        public virtual double CalcularBonificacao() //metodo de polimorfismo usa-se virtual feito na CLASSE BASE!!!!!
        {
            return Salario * 10/100;
        }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public double Salario
        {
            get { return this.salario; }
            set { this.salario = value; }
        }
    }
}
