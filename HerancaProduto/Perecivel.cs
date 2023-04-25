using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaProduto
{
    class Perecivel : Produto
    {
        private string dtFabricacao;
        private string dtValidade;
        private int lote;

        public Perecivel(int codigo, string nome,
            double preco, string dtFabricacao, string dtValidade,
            int lote) : base(codigo, nome,preco)
        {
            DtFabricacao = dtFabricacao;
            DtValidade = dtValidade;
            Lote = lote;
        }

        public string DtFabricacao
        {
            set { this.dtFabricacao = value; }
            get { return this.dtFabricacao; }
        }
        public string DtValidade
        {
            set { this.dtValidade = value; }
            get { return this.dtValidade; }
        }
        public int Lote
        {
            set { this.lote = value; }
            get { return this.lote; }
        }
        public void Mostrar()
        {//a palavra base chama o método da superclasse
            base.Mostrar();//apresenta apenas codigo e nome
            Console.WriteLine("Data de fabricação: " 
                + DtFabricacao + "\tData de validade:" 
                + DtValidade + "\nLote: " + lote);
        }
    }
}
