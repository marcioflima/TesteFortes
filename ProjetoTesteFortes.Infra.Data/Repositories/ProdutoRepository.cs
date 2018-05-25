using System;
using System.Collections.Generic;
using ProjetoTesteFortes.Domain.Entities;
using System.Linq;
using ProjetoTesteFortes.Domain.Interfaces.Repositories;

namespace ProjetoTesteFortes.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string descricao)
        {
            return Db.Produtos.Where(p => p.Descricao == descricao);
        }
    }
}
