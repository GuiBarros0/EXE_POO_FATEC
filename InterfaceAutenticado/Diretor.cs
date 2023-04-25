using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAutenticado
{
    class Diretor : Funcionario, IAutenticavel
    {
        public Diretor(int codigo, string nome, int senha) : base(codigo, nome, senha)
        {

        }

        public bool Autentica(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("diretor validado");
                return true;
            }
            Console.WriteLine("diretor nao validado");
            return false;
        }
    }
}
