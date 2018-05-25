using ProjetoTesteFortes.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoTesteFortes.Infra.Data.EntityConfig
{
    public class PedidoConfiguration : EntityTypeConfiguration<Pedido>
    {
        public PedidoConfiguration()
        {
            HasKey(p => p.PedidoId);

            Property(p => p.DataPedido)
                .IsRequired();

            Property(p => p.ValorTotalPedido)
                .IsRequired();

            HasRequired(p => p.Produto)
                .WithMany()
                .HasForeignKey(p => p.ProdutoId);

        }
    }
}
