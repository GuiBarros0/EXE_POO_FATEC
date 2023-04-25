using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAutenticado
{
    class Program
    {
        static void Main(string[] args)
        {
            //IAutenticavel = new IAutenticavel(); //n é possivel instanciar a interface a uma interface!!!!!!
            Cliente c = new Cliente();
            IAutenticavel i = c;
            c.Senha = 100;
            Console.WriteLine(i.Autentica(100));

            ////////////////////////////////////////////////
            Gerente g = new Gerente(1, "rico", 111);
            Diretor d = new Diretor(2, "kovalski", 155);
            IAutenticavel i2 = g;


            Console.WriteLine(i2.Autentica(100));

            i2 = d;
            Console.WriteLine(i2.Autentica(155));

            Console.ReadKey();


        }
    }
}


//ANOTAÇÕES INTERFACE
//interface é obrigado a usar os metodos dela, tipo como se fosse assinar um aluguel de uma casa, vc deve realizar as coisas que o dono pede (tipo abstract
// interface tem apenas metodos, n possui atributos || n pode ser instanciada tmb!)
// pq utilizar? quando queremos usar classes n relacionadas mas implementam metodos similares (transferir ou sacar)
// interface tmb é um tipo de dado (pode ser comparado como herança multipla MAS N EXISTE HERANÇA MULTIPLA)
// N TEM LOGICA DE PROGRAMAÇÃO NOS METODOS DELA
//METODOS DENTRO DA INTERFACE SÃI IGUAIS AOS ABSTRACT
//a interface pode receber obj de outra classe
// n podemos usar a palavra override, mesmo sendo um polimor.. pqn é hrança
//a interface pode ser instancia por outra classe(pessoaInterface = new PESSOA() PESSOA: é um classe qualquer)
// pessoaInterface = new PessoaInterface() x errado <<<<<<
