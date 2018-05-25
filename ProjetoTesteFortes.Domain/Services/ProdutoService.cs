using System;
using System.Collections.Generic;
using ProjetoTesteFortes.Domain.Entities;
using ProjetoTesteFortes.Domain.Interfaces.Repositories;
using ProjetoTesteFortes.Domain.Interfaces.Services;

namespace ProjetoTesteFortes.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {

        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}
