using ProjetoTesteFortes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteFortes.Application.Interface
{
    public interface IPedidoAppService : IAppServiceBase<Pedido>
    {
        IEnumerable<Pedido> BuscarPorForncedor(int fonnecedorId);
    }
}
