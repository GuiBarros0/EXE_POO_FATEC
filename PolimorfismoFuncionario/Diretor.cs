using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    class Diretor : Funcionario
    {
        // usa private na subclasse
        private double porcentagem;
        public Diretor(int codigo, string nome, double salario, double porcentagem) : base(codigo, nome, salario)
        {
            this.porcentagem = porcentagem;
        }

        public override double CalcularBonificacao() //metodo de polimorfismo usa-se override na SUB-CLASSE!!!! (sobrescrita)
        {
            return base.CalcularBonificacao() + 1000;
        }
    }
}
