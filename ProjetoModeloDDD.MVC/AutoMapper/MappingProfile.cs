using AutoMapper;
using PrimeiroModelo.Domain.Entities;
using ProjetoModelo.Domain.Entities;
using ProjetoModeloDDD.Aplication.ViewModels;
using System.Collections.Generic;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class MappingProfile : Profile
    {      
        public MappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>()
                .ForMember(dest => dest.Produtos, opt => opt.Ignore()).ReverseMap();

            CreateMap<Cliente, ClienteViewModel>()
                .ForMember(dest => dest.Produtos, opt => opt.Ignore()).ReverseMap();

            CreateMap<List<ClienteViewModel>, List<Cliente>>().ReverseMap();
            CreateMap<List<Cliente>, List<ClienteViewModel>>().ReverseMap();

            CreateMap<ProdutoViewModel, Produto>().
                ForMember(dest => dest.Cliente, opt => opt.Ignore()).ReverseMap();

            CreateMap<List<ProdutoViewModel>, List<Produto>>().ReverseMap();
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
    }
}