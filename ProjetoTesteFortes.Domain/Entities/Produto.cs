using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteFortes.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public int CodProduto { get; set; }
        public string Descricao  { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal ValorProduto { get; set; }
        public int FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual IEnumerable<Pedido> Pedido { get; set; }
        //public int PedidoId { get; set; }
        //public virtual Fornecedor Pedido { get; set; }


    }
}
