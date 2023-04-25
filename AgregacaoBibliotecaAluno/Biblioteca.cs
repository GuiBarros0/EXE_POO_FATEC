using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoBibliotecaAluno
{
    class Biblioteca
    {
        private int codigo;
        private string nome;
        private Aluno alunos;
        //encapsulamentos
        public string Nome
        {
            set { this.nome = value; }
            get { return this.nome; }
        }
        public Aluno Alunos
        {
            set { this.alunos = value; }
            get { return this.alunos; }
        }
        public int Codigo
        {
            set { this.codigo = value; }
            get { return this.codigo; }
        }
    }
}
