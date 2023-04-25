using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceItributavel
{
    class SeguroDeVida : Itributavel
    {
        public double CalculaTributos()
        {
            Console.Write("custo do seguro de vida é de: ");
            return 75;
        }
    }
}
