using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceItributavel
{
    class ContaCorrente : Itributavel
    {
        private double saldo;

        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        public double CalculaTributos()
        {
            Console.Write("porcentagem do saldo de 5% é de: ");
            return Saldo * 0.05;

        }
    }
}
