

using ProjetoTesteFortes.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoTesteFortes.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
