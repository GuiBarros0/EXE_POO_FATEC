using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    class ClienteFisico : Cliente
    {
        private int rg;

        //construtor          //passando os parametros com os atrb.       //referenciando o construtor da superclasse
        public ClienteFisico(int codigo, string nome, int idade, int rg) : base (codigo, nome, idade)
        {
            Rg = rg;
        }

        public int Rg
        {
            set { this.rg = value; }
            get { return this.rg; }
        }


        public override void Mostrar()
        {
            base.Mostrar(); //chama a logica da Super classe
            Console.WriteLine("RG: " + Rg);
        }

        public override bool VerificaIdade()
        {
            if (Idade < 50)
            {
                return true;
            }
            return false;
        }
    }
}
