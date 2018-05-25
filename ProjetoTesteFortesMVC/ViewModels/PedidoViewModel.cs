

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoTesteFortesMVC.ViewModels
{
    public class PedidoViewModel
    {
        [Key]
        public int PedidoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Data de Cadastro.")]
        [DisplayName("Data do Pedido")]
        public DateTime DataPedido { get; set; }

        [Required(ErrorMessage = "Preencha o campo Quantidade de Produtos.")]
        [DisplayName("Qtd de Produtos")]
        public int QtdProdutos { get; set; }

        [Required(ErrorMessage = "Preencha o campo Valor do Pedido.")]
        [Range(typeof(decimal), "0", "999999999999")]
        [DataType(DataType.Currency)]
        [DisplayName("Valor do Pedido")]
        public decimal ValorTotalPedido { get; set; }

        public int ProdutoId { get; set; }
        public virtual ProdutoViewModel Produto { get; set; }

    }
}