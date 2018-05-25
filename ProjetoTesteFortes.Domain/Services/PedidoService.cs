using System;
using System.Collections.Generic;
using ProjetoTesteFortes.Domain.Entities;
using ProjetoTesteFortes.Domain.Interfaces.Repositories;
using ProjetoTesteFortes.Domain.Interfaces.Services;

namespace ProjetoTesteFortes.Domain.Services
{
    public class PedidoService : ServiceBase<Pedido>, IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        
        public PedidoService(IPedidoRepository pedidoRepository)
            : base(pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public IEnumerable<Pedido> BuscarPorForncedor(int fornecedorId)
        {
            return _pedidoRepository.BuscarPorForncedor(fornecedorId);
        }
    }
}
