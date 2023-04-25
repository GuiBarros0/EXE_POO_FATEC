using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1;// declaração de variável
            conta1 = new Conta();// instância de objeto
            conta1.numero = 13;
            conta1.titular = "Fatec";
            conta1.saldo = 1000;
            conta1.MostrarAtributos();
            /*Console.Write("Informe o valor a sacar? ");
            double valorSaque = Convert.ToDouble(Console.ReadLine());
            conta1.Sacar(valorSaque);
            conta1.MostrarAtributos();
            Conta conta2 = new Conta();//Conta() - construtor da clase
            Console.Write("Digite o número da conta: ");
            conta2.numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            conta2.titular = Console.ReadLine();
            Console.Write("Digite o saldo da conta: ");
            conta2.saldo = Convert.ToDouble(Console.ReadLine());
            conta2.MostrarAtributos();
            */
            Conta conta3= new Conta();
            Console.Write("Informe o valor a depositar: ");
            double valorDepositado = Convert.ToDouble(Console.ReadLine());
            conta3.Depositar(valorDepositado);
            conta3.MostrarAtributos();
            conta3.Transferir(100,conta1);
            conta3.MostrarAtributos();

            Console.ReadKey();
        }
    }
}
