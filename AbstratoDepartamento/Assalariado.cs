using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoDepartamento
{
    class Assalariado : Funcionario
    {
        public Assalariado(string nome, int codigo, double salario) : base (nome, codigo, salario)
        {

        }

        public override double CalcularSalario(int diaUteis)
        {
            return Salario / 30 * diaUteis;
        }
    }
}
