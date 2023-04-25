using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoDepartamento
{
    class Comissionado : Funcionario
    {
        private double porcentagem;

        public Comissionado(string nome, int codigo, double salario, double porcentagem) : base(nome, codigo, salario)
        {
            Porcentagem = porcentagem;
        }

        public double Porcentagem
        {
            set { this.porcentagem = value; }
            get { return this.porcentagem; }
        }

        public override double CalcularSalario(int diaUteis)
        {
            return Salario / 30 * diaUteis * Porcentagem + Salario;
        }

        public override void Mostrar() //polimorfismo dinamico
        {
            base.Mostrar();
            Console.WriteLine("Porcentagem: " + Porcentagem);
        }
    }
}
