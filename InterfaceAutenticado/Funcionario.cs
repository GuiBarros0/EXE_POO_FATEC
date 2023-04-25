using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAutenticado
{
    class Funcionario
    {
        private int codigo, senha;
        private string nome;

        public Funcionario(int codigo, string nome, int senha)
        {
            Codigo = codigo;
            Nome = nome;
            Senha = senha;
        }

        public int Codigo
        {
            set { this.codigo = value; }
            get { return this.codigo; }
        }
        public string Nome
        {
            set { this.nome = value; }
            get { return this.nome; }
        }
        public int Senha
        {
            set { this.senha = value; }
            get { return this.senha; }
        }
    }
}
