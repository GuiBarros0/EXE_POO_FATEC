using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    class Conta
    {
        //declaração de atributos encapsulados
        private int numero;
        private string titular;
        private double saldo;

        //declaração dos métodos de encapsulamento
        public int Numero
        {
            set
            {
                this.numero = value;
            }
            get
            {
                return this.numero;
            }
        }
        public string Titular
        {
            set
            {
                this.titular = value;
            }
            get
            {
                return this.titular;
            }
        }
        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }

    }
}
