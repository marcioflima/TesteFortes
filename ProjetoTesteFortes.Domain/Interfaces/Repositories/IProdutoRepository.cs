

using ProjetoTesteFortes.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoTesteFortes.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
