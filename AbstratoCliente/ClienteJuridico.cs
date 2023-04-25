using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    class ClienteJuridico : Cliente
    {
        private int cnpj;

        public ClienteJuridico(int codigo, string nome, int idade, int cnpj) : base(codigo, nome, idade)
        {
            CNPJ = cnpj;
        }

        public int CNPJ
        {
            set { this.cnpj = value; }
            get { return this.cnpj; }
        }

        public override void Mostrar()
        {
            base.Mostrar(); //chama a logica da Super classe
            Console.WriteLine("CNPJ: " + CNPJ);
        }

        public override bool VerificaIdade()
        {
            if (Idade > 50)
            {
                return true;
            }
            return false;
        }
    }
}
