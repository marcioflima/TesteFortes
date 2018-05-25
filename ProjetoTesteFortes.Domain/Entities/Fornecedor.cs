using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteFortes.Domain.Entities
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Uf { get; set; }
        public string EmailContato { get; set; }
        public string NomeContato { get; set; }
        public virtual IEnumerable<Produto> Produtos { get; set; }        

        //public bool ValidarFornecedor(Fornecedor fornecedor)
        //{
        //    return fornecedor.Cnpj == 
        //}
    }
}
