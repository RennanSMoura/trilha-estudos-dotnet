using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidade 3.Serializacao
{
    public class Venda
    {

        public Venda(int id, string produto, decimal preco, DateTime dataVenda, decimal desconto)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
            Desconto = desconto;
            // this.id = ID;
            // this.produto = Produto;
            // this.preco = Preco;
        }
        
        public int ID { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }
        // A propriedade desconto é do tipo decimal, mas ao colocar o ? ao final ela passa a aceitar valores nulos
    }
}