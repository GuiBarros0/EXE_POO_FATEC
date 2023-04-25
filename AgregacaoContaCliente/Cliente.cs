using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoContaCliente
{
    class Cliente
    {
        private string nome;
        private string rg;
        private string cpf;

        public Cliente(string nome,string rg, 
                          string cpf)
        {
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;
        }
        public Cliente()
        {

        }
        public string Nome
        {
            set { this.nome = value; }
        }
        public string Rg
        {
            set { this.rg = value; }
        }
        public string Cpf
        {
            set { this.cpf = value; }
        }
    }
}
