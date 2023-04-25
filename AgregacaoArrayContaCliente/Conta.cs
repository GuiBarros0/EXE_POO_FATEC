using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoArrayContaCliente
{
    class Conta
    {
        private int numero;
        private List<Cliente> titular;//vetor de clientes
        private double saldo;
        public List<Cliente> Titular
        {
            get { return this.titular; }
            set { this.titular = value; }
        }
        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }
        
    }
}
