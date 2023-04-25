using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoBibliotecaAluno
{
    class Aluno
    {
        private int matricula;
        private string nome;
        // encapsulamentos
        public int Matricula
        {
            get { return this.matricula; }
            set { this.matricula = value; }
        }
        public string Nome
        {
            set { this.nome = value; }
            get { return this.nome; }
        }
    }
}
