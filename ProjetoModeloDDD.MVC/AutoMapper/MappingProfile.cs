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
            CreateMap<ClienteViewModel, Cliente>().ReverseMap();
            CreateMap<List<ClienteViewModel>, List<Cliente>>().ReverseMap();

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