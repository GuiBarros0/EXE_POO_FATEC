using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoContaCliente
{
    class Conta
    {
        private int numero;
        private Cliente titular;
        private double saldo;

        public Conta(int numero, Cliente titular,
            double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }
        public Conta()
        {

        }
    }
}
