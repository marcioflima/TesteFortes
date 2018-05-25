
using ProjetoTesteFortes.Domain.Interfaces;
using ProjetoTesteFortes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoTesteFortes.Domain.Interfaces.Repositories;

namespace ProjetoTesteFortes.Infra.Data.Repositories
{
    public class PedidoRepository : RepositoryBase<Pedido>, IPedidoRepository
    {      
        public IEnumerable<Pedido> BuscarPorForncedor(int fonnecedorId)
        {
            return Db.Pedidos.Where(p => p.FornecedorId == fonnecedorId);
        }
    }
}
