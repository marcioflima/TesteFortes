using ProjetoTesteFortes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteFortes.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.ValorProduto)
                .IsRequired();

            HasRequired(p => p.Fornecedor)
                .WithMany()
                .HasForeignKey(p => p.FornecedorId);
        }
    }
}
