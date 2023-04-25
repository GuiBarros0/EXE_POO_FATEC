using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoArrayContaCliente
{
    class Cliente
    {
        private string nome;
        private string rg;
        private string cpf;
        public string Nome
        {
            set { this.nome = value; }
            get { return this.nome; }
        }
        public string Rg
        {
            set { this.rg = value; }
            get { return this.rg; }
        }
        public string Cpf
        {
            set { this.cpf = value; }
            get { return this.cpf; }
        }
    }
}
