using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_manhã
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // em Python print('Bom dia!')
            Console.Write("Digite o ano de nascimento: ");

            // em Ptyhon input('Digite o ano de nascimento: ')
            int anon = Convert.ToInt32(Console.ReadLine());
            int idade = 2022 - anon;
            Console.WriteLine("Idade " + idade + " anos.");

            Console.WriteLine("\nExemplo do comando if else if else");
            //em Pytho if idade > 18:     elif idade == 18:       else:
            if (idade > 18) 
                Console.WriteLine("Maior de idade");
            else if (idade == 18)
                Console.WriteLine("Maior de idade e você já pode tirar sua habilitação");
            else
            {
                Console.Write("Menor");
                Console.WriteLine(" de idade");
            }
            //cw tab tab escreve automaticamente o comando Console.WriteLine();
            //em Python for cont in range(1,6): <
            Console.WriteLine("\nExemplo do comando for");
            int cont;
            for (cont = 13; cont <= 25; cont++)  
                Console.WriteLine(cont);

            Console.WriteLine("\nExemplo do comando while");
            //em Python while cont <= 25:
            cont = 13; // 1º inicialização
            while (cont <= 25) // 2º condição/critério de para
            {
                Console.WriteLine(cont);
                cont = cont + 1;// 3º incremento cont += 1;    cont++;
            }

            Console.WriteLine("\nExemplo do comando do .. while");
            //em Python não tem comando corresponde
            cont = 13; // 1º inicialização
            do
            {
                Console.WriteLine(cont);
                cont += 1;// 3º incremento
            } while (cont <= 25); // 2º condição/critério de para
            */
            Console.WriteLine("\nExemplo do comando while SEM CONTADOR");
            //somar salários de alguns funcionários
            Console.Write("Digite o salário..: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            double soma = 0;
            while (salario > 0) // 2º condição/critério de parada
            {
                soma = soma + salario;  // soma += salario
                Console.Write("Digite o salário: ");
                salario = Convert.ToDouble(Console.ReadLine());                
            }
            Console.WriteLine("O resultado é R$ " + soma);
            Console.WriteLine("\nExemplo do comando do .. while SEM CONTADOR");
            soma = 0;
            salario = 1;
            do
            {
                Console.Write("Digite o salário: ");
                salario = Convert.ToDouble(Console.ReadLine());
                if (salario > 0)
                {                    
                    soma = soma + salario;
                }
            } while (salario > 0);

            Console.WriteLine("O resultado é R$ " + soma);
            Console.WriteLine("\n\n\nTérmino do programa");
            Console.ReadKey();
        }
    }
}
