using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{
    class Cliente //classe base/superclasse
    {//protected é o modificador de acesso na classe base
        protected int codigo;
        protected string nome;

        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
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
        public void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo +
                "\tNome: " + Nome);            
        }
    }
}
