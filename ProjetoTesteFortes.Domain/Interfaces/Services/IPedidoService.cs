using ProjetoTesteFortes.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoTesteFortes.Domain.Interfaces.Services
{
    public interface IPedidoService : IServiceBase<Pedido>
    {
        IEnumerable<Pedido> BuscarPorForncedor(int fonnecedorId);
    }
}
