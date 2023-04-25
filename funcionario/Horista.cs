using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionario
{
    class Horista : Funcionario
    {
        private string horasSemanais;

        public Horista(int codigo, string nome, double salario, string horasSemanais)
            : base(codigo, nome, salario)
        {
            HorasS = horasSemanais;
        }

        public string HorasS
        {
            set { this.horasSemanais = value; }
            get { return this.horasSemanais; }
        }
        public void Mostrar()
        {//a palavra base chama o método da superclasse
            base.Mostrar();//apresenta apenas codigo e nome
            Console.WriteLine("Horas semanais: " + HorasS);
        }
    }
}
