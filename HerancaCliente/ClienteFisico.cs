using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{//     classe derivada : classe base
    class ClienteFisico : Cliente
    {
        private int rg;
        private int cpf;
        public ClienteFisico(int codigo, string nome,
            int rg, int cpf) : base(codigo, nome)
        {
            Rg = rg;
            Cpf = cpf;
        }
        public int Rg
        {
            set { this.rg = value; }
            get { return this.rg; }
        }
        public int Cpf
        {
            set { this.cpf = value; }
            get { return this.cpf; }
        }
        public void Mostrar()
        {//a palavra base chama o método da superclasse
            base.Mostrar();//apresenta apenas codigo e nome
            Console.WriteLine("Rg: " + Rg + 
                "\tCpf:" + Cpf);
        }
    }
}
