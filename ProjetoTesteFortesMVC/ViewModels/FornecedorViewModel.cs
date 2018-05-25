using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoTesteFortesMVC.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public int FornecedorId { get; set; }

        [Required(ErrorMessage = "Preecha o campo Razão Social")]
        [MaxLength(100, ErrorMessage ="Máximo de {0} caracteres")]
        [MinLength(3, ErrorMessage = "Mínino de {0} caracteres")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Preecha o campo Cnpj")]
        [MaxLength(14, ErrorMessage = "Máximo de {0} caracteres")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Preecha o campo Uf")]
        [MaxLength(2, ErrorMessage = "Máximo de {0} caracteres")]
        public string Uf { get; set; }

        [Required(ErrorMessage = "Preecha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        public string EmailContato { get; set; }

        [Required(ErrorMessage = "Preecha o campo Nome Contato")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(3, ErrorMessage = "Mínino de {0} caracteres")]
        public string NomeContato { get; set; }
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}