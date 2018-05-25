

using ProjetoTesteFortes.Application.Interface;
using ProjetoTesteFortes.Domain.Entities;
using ProjetoTesteFortes.Domain.Interfaces.Services;

namespace ProjetoTesteFortes.Application
{
    public class FornecedorAppService : AppServiceBase<Fornecedor>, IFornecedorAppService
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorAppService(IFornecedorService fornecedorService)
            : base(fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

    }
}
