
using ProjetoTesteFortes.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoTesteFortes.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscaPorNome(string nome);
    }
}
