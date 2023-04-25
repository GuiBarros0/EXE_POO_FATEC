using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    class Conta
    {
        //declaração dos atributos encapsulados
        private int numero;
        private string titular;
        private double saldo;

        //declaração do construtor
        public Conta() //construtor padrão 
        {

        }
        public Conta(int numero)
        {
            this.numero = numero;
        }
        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        //declaração de métodos
        public void Mostrar()
        {
            Console.WriteLine("Número da conta: " + numero +
                "\tNome do titular: " + titular +
                "\tSaldo do titular R$ " + saldo);
        }
    }
}
