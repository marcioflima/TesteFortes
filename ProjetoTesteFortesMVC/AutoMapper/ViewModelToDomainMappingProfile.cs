using AutoMapper;
using ProjetoTesteFortes.Domain.Entities;
using ProjetoTesteFortesMVC.ViewModels;

namespace ProjetoTesteFortesMVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName { get { return "DomainToViewModelMappings"; } }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Fornecedor, FornecedorViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
            CreateMap<Pedido, PedidoViewModel>();

        }

    }
}