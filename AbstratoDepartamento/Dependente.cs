using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoDepartamento
{
    class Dependente

    {
		private int codigo;
		private string nome;
		private int idade;

		public Dependente(int codigo, string nome, int idade)
		{
			Codigo = codigo;
			Nome = nome;
			Idade = idade;
		}

		public int Codigo
		{
			get { return this.codigo; }
			set { this.codigo = value; }
		}

		public string Nome
		{
			get { return this.nome; }
			set { this.nome = value; }
		}

		public int Idade
		{
			get { return this.idade; }
			set { this.idade = value; }
		}

		public bool VerificaIdade()
        {
			if (Idade > 18){
				return true;
            }
			return false;
        }

		public void MostrarD()
		{
			Console.WriteLine("idade : " + Idade + "\tNome: " + Nome);
			
		}


	}
}
