using ProjetoTesteFortes.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoTesteFortes.Domain.Interfaces.Repositories
{
    public interface IPedidoRepository : IRepositoryBase<Pedido>
    {
        IEnumerable<Pedido> BuscarPorForncedor(int  fonnecedorId);

    }
}
