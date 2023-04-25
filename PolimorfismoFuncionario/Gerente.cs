using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    class Gerente : Funcionario
    {
        public Gerente(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {


        }
        //aplicação do polimorfismo

        public override double CalcularBonificacao() //metodo de polimorfismo usa-se override na SUB-CLASSE!!!! (sobrescrita)
        {
            return Salario * 15 / 100;
        }
    }
}
