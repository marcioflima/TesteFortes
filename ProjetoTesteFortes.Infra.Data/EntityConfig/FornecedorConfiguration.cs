using ProjetoTesteFortes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteFortes.Infra.Data.EntityConfig
{
    public class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfiguration()
        {
            HasKey(f => f.FornecedorId);

            Property(f => f.NomeContato)
                .IsRequired()
                .HasMaxLength(150);

            Property(f => f.RazaoSocial)
                .IsRequired()
                .HasMaxLength(150);

            Property(f => f.RazaoSocial)
                .IsRequired();

            Property(f => f.EmailContato)
                 .IsRequired();

            //HasRequired(f => f.Produtos)
            //   .WithMany()
            //   .HasForeignKey(f => f.Produtos);

        }
    }
}
