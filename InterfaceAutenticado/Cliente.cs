using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAutenticado
{
    class Cliente : IAutenticavel //n é uma herança!!!!!!!! isso é uma interface pois começa com "I"
    {
        private int senha;

        public int Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }

        public bool Autentica(int senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("cliente válidado");
                return true;
            }
            Console.WriteLine("cliente invalidado");
            return false;
        }
    }
}
