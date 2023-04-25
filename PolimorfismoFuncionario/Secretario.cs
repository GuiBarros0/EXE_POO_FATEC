using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    // subclasse : superclasse (classe base)
    class Secretario : Funcionario
    {
        // chama o construtor da super classe |||                  : e cita os argumentos
        public Secretario(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {
                        
        }
    }
}
