

using System;
using System.Collections.Generic;
using ProjetoTesteFortes.Application.Interface;
using ProjetoTesteFortes.Domain.Entities;
using ProjetoTesteFortes.Domain.Interfaces.Services;

namespace ProjetoTesteFortes.Application
{
    public class PedidoAppService : AppServiceBase<Pedido>, IPedidoAppService
    {
        private readonly IPedidoService _pedidoService;
        public PedidoAppService(IPedidoService pedidoService) 
            : base(pedidoService)
        {
            _pedidoService = pedidoService;
        }

        public IEnumerable<Pedido> BuscarPorForncedor(int fornecedorId)
        {
            return _pedidoService.BuscarPorForncedor(fornecedorId);
        }
    }
}
