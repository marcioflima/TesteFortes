using AutoMapper;
using ProjetoTesteFortes.Domain.Entities;
using ProjetoTesteFortesMVC.ViewModels;

namespace ProjetoTesteFortesMVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        public DomainToViewModelMappingProfile()
        {
            CreateMap<FornecedorViewModel, Fornecedor>();
            CreateMap<ProdutoViewModel, Produto>();
            CreateMap<PedidoViewModel, Pedido>();
        }
       }



   //}
}