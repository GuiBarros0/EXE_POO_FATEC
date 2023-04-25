using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    class Mensalista : Funcionario
    {
        private string qtdHorasTrabalhadas;

        public Mensalista(int codigo, string nome, double salario, string qtdHorasTrabalhadas)
            : base(codigo, nome, salario)
        {
            Horas = qtdHorasTrabalhadas;
        }

        public string Horas
        {
            set { this.qtdHorasTrabalhadas = value; }
            get { return this.qtdHorasTrabalhadas; }
        }
        public void Mostrar()
        {//a palavra base chama o método da superclasse
            base.Mostrar();//apresenta apenas codigo e nome
            Console.WriteLine("Horas trabalhadas: " + Horas);
        }
    }
}
