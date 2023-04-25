using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConta // nome do ppjeto
{
    class Conta
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
    }
}
