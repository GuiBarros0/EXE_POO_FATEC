using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoDepartamento
{
    class Departamento
    {
        private int codigo;
        private string descricao;
        private List<Funcionario> vetf;

        public Departamento(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }

        public int Codigo
        {
            set { this.codigo = value; }
            get { return this.codigo; }
        }

        public string Descricao
        {
            set { this.descricao = value; }
            get { return this.descricao; }
        }

        public List<Funcionario> Vetf
        {
            set { this.vetf = value; }
            get { return this.vetf; }
        }

        public void Admitir(Funcionario ObjetoFuncionario)
        {
            
            Vetf.Add(ObjetoFuncionario);
        }

        public void Listar()
        {
            Console.WriteLine("\n---------Listagem de funcionários---------\n");
            foreach (Funcionario f in Vetf)
            {
                f.Mostrar();
            }
        }

        public void Demitir(int codigoPesquisa)
        {
            for(int i = 0; i < Vetf.Count; i++)
            {
                Funcionario f = Vetf.ElementAt<Funcionario>(i);
                if (f.Codigo == codigoPesquisa)
                {
                    Vetf.Remove(f);
                }
            }
        }

        public double CalcularPagamento(int diaUteis)
        {
            Console.WriteLine("\n--------Calculo da folha de pgmt-----------\n");
            double folha = 0;
            for (int i = 0; i < Vetf.Count; i++)
            {
                Funcionario f = Vetf.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(30);
            }
            return folha;
        }

        public void MostrarQtdeDependentesFuncionario()
        {
            Console.WriteLine("\n--------Calculo total dependentes do departamento-----------\n");
            foreach (Funcionario f in Vetf)
            {
                Console.WriteLine(f.CalcularTotalDependente());
            }
        }
    }
}
