using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseConta
{
    class Conta // Conta é o tipo de dados
    {
        //Declaração dos atributos
        public int numero;
        public string titular;
        public double saldo;

        //declaração dos métodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Número da conta: " + numero +
                "\tNome do titular: " + titular +
                "\tSaldo do titular R$ " + saldo);
        }
        public void Transferir(double valorTransferencia, 
            Conta outraConta)
        {
            Console.WriteLine("Valor " + valorTransferencia);
            outraConta.saldo -= valorTransferencia;
            saldo = saldo + valorTransferencia;
        }

        public void Sacar(double retirar)//parâmetro
        {
            if (retirar <= saldo)
                saldo = saldo - retirar;
            else
                Console.WriteLine("Saldo insuficiente");
        }
        public void Depositar(double valorDepositado)
        {
            if (valorDepositado > 0)
                saldo = saldo + valorDepositado;
            else
                Console.WriteLine("Valor inválido");
        }

    }
}
