using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConta
{
    class Program
    {
        static void Main(string[] args)
        {
            //decalarara o vetor
            Conta[] vetConta = new Conta[3];
            for (int i = 0; i < vetConta.Length; i++)
            {
                //instanciar cada posição do vetor
                vetConta[i] = new Conta();
                Console.WriteLine("Cadastre o número: ");
                vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cadastre o titular: ");
                vetConta[i].titular = Console.ReadLine();
                Console.WriteLine("Cadastre o saldo: ");
                vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
            }
            //mostrar contúdo do vetConta
            foreach (Conta c in vetConta)
                c.MostrarAtributos();

            Console.ReadKey();
        }
    }
}
