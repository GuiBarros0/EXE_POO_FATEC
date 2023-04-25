using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    // herança usamos protected e sem herança usamos private
    abstract class Cliente
        //está classe sendo abstract NUNCA PODE SER INSTANCIADA!!!!!!! CLIENTE C = NEW CLIENTE(); N PODE!!!!!! (SÓ PODE SER SUPERCLASSE)
    {
        protected int codigo;
        protected string nome;
        protected int idade;

        public Cliente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
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

        public int Idade
        {
            set { this.idade = value; }
            get { return this.idade; }
        }


        public virtual void Mostrar()
        {
            //polimorfismo dinamico
            Console.WriteLine("codigo: " + codigo + " \tnome: " + nome + " \tidade: " + idade);
        }

        //metodo abstract n tem linha de logica (promgramação) ele termina com ";" n possui "{ }"
        public abstract bool VerificaIdade();
    }
}
