using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    class Aluno
    {
        private static long ra;
        private string nome;
        private double media;
        private static int contador;
        //declarar 3 contrutores
        
        public Aluno()//construtor padrão
        {
            contador = contador + 1;
            ra = ra + 1;
        }
        public Aluno(string nome)
        {
            this.nome = nome;
            contador = contador + 1;
            ra = ra + 1;
        }
        public Aluno(string nome, double media)
        {
            this.nome = nome;
            this.media = media;
            contador = contador + 1;
            ra = ra + 1;
        }
        static Aluno()//construtor estático
        {
            ra = 1570482021039;
        }

        //declarar o método mostrar
        public void Mostrar()
        {
            Console.WriteLine("RA: " + ra +
                "\tNome: " + nome +
                "\tMédia: " + media);
        }
        public static int Contador
        {
            get { return contador; }
        }
    }
}
