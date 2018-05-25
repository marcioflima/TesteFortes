using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTesteFortesMVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preecha o campo Descrição")]
        public int CodProduto { get; set; }

        [Required(ErrorMessage = "Preecha o campo Descrição")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(3, ErrorMessage = "Mínino de {0} caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Preecha o campo Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999")]
        [Required(ErrorMessage = "Preencha o campo Valor do Produto")]
        public decimal ValorProduto { get; set; }
        public int FornecedorId { get; set; }
        public virtual FornecedorViewModel Fornecedor { get; set; }

        //public int PedidoId { get; set; }
        //public virtual PedidoViewModel Pedido { get; set; }
    }
}