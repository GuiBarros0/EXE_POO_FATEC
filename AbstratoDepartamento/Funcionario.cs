using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoDepartamento
{
    abstract class Funcionario
    {
        protected string nome;
        protected int codigo;
        protected double salario;
        protected List<Dependente> vetD;

        public Funcionario(string nome, int codigo, double salario)
        {
            Nome = nome;
            Codigo = codigo;
            Salario = salario;
        }

        public abstract double CalcularSalario(int diaUteis);

        public virtual void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tSalário: " + Salario);
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
        public double Salario
        {
            set { this.salario = value; }
            get { return this.salario; }
        }
        public List<Dependente> VetD
        {
            set { this.vetD = value; }
            get { return this.vetD; }
        }

        public void AdicionarDependente(Dependente novoDep)
        {
            Console.WriteLine(novoDep.Nome + " - ADICIONADO");
            VetD.Add(novoDep);
        }

        
        public void RemoverDependente(int codigoPesquisa)
        {
            
            for (int i = 0; i < VetD.Count; i++)
            {

                Dependente d = VetD.ElementAt<Dependente>(i);
                if (d.Codigo == codigoPesquisa)
                {
                    
                    if (d.VerificaIdade() == true)
                    {
                        VetD.Remove(d);
                        Console.WriteLine(d.Nome +" - REMOVIDO!");
                    }
                    else
                    {
                        Console.WriteLine(d.Nome +" - NÃO REMOVIDO ELE NÃO TEM 18 ANOS");
                    }
                }
            }
        }
        public void ListarDependentes()
        {
            Console.WriteLine("\n---------Listagem de dependentes de cada funcionario---------\n");
            foreach (Dependente d in VetD)
            {
                d.MostrarD();
            }
        }
        public int CalcularTotalDependente()
        {
            int qtdDep = 0;
            for (int i = 0; i < VetD.Count; i++)
                {
                    Dependente d = VetD.ElementAt<Dependente>(i);
                    qtdDep++;
                }
            return qtdDep;
        }

    }
}
