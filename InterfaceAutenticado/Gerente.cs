using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAutenticado
{
    class Gerente : Funcionario, IAutenticavel
    {
        public Gerente(int codigo, string nome, int senha) : base(codigo, nome, senha)
        {

        }
        //a classe gerente herda da classe func. e implementa a interface IAutenticavel
        public bool Autentica(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("gerente validado");
                return true;
            }
            Console.WriteLine("gerente não validado");
            return false;
        }
    }
}
