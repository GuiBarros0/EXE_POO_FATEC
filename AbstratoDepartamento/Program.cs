using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoDepartamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //nao pode instanciar uma class abstract
            //Funcionario f = new Funcionario(1, "gusta", 1000);

            Assalariado a1 = new Assalariado("gusta", 1, 7500);
            Assalariado a2 = new Assalariado("kovalski", 2, 4000);

            Comissionado c1 = new Comissionado("tadeu", 3, 5400, 0.2);
            Comissionado c2 = new Comissionado("josue", 4, 1000, 0.3);

            Departamento d1 = new Departamento(5570, "TI");
            Departamento d2 = new Departamento(5400, "RH");
            d1.Vetf = new List<Funcionario>();
            d2.Vetf = new List<Funcionario>();

            Dependente dep = new Dependente(5, "jhow", 19);
            Dependente dep1 = new Dependente(6, "romeu", 15);
            Dependente dep2 = new Dependente(7, "kaka", 25);
            Dependente dep3 = new Dependente(8, "romario", 12);

            d1.Admitir(a1);

            a1.VetD = new List<Dependente>();

            // adicionando
            a1.AdicionarDependente(dep);  a1.AdicionarDependente(dep1); a1.AdicionarDependente(dep2); a1.AdicionarDependente(dep3);

            //mostrando qtd de depedentes do func (departamento)
            d1.MostrarQtdeDependentesFuncionario();

            //listando
            a1.ListarDependentes();

            //removendo
            a1.RemoverDependente(5);
            a1.RemoverDependente(6);
            a1.RemoverDependente(7);
            a1.RemoverDependente(8);

            //listando dnv
            a1.ListarDependentes();

            //mostrando qtd de depedentes do func (departamento)
            d1.MostrarQtdeDependentesFuncionario();


            Console.ReadKey();
        }
    }
}
