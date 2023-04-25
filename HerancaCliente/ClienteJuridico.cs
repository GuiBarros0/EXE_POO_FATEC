using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{
    class ClienteJuridico : Cliente
    {
        private int cnpj;
        private int ie;

        public ClienteJuridico(int codigo, string nome,
            int cnpj, int ie) : base(codigo, nome)
        {
            Cnpj = cnpj;
            Ie = ie;
        }

        public int Cnpj
        {
            set { this.cnpj = value; }
            get { return this.cnpj; }
        }
        public int Ie
        {
            set { this.ie = value; }
            get { return this.ie; }
        }
        public void Mostrar()
        {//a palavra base chama o método da superclasse
            base.Mostrar();//apresenta apenas codigo e nome
            Console.WriteLine("Cnpj: " + Cnpj +
                "\tIe:" + Ie);
        }
    }
}
