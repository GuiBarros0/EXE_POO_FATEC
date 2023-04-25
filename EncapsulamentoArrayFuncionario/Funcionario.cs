using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoArrayFuncionario
{
    class Funcionario
    {
        private int matricula;
        private string nome;
        private double salario;

        public int Matricula
        {
            get { return this.matricula; }
            set { this.matricula = value; }
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
