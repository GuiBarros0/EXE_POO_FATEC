using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceItributavel
{
    class TotalizadorDeTributos
    {
        private double total;
        public double Total
        {
            get { return this.total; }
            set { this.total = value; }
        }

        public void Adiciona(Itributavel t)
        {
            Total += t.CalculaTributos();
            Console.WriteLine(Total);
        }
    }
}
