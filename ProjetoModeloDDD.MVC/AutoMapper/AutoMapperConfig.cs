using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoModeloDDD.MVC.AutoMapper;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize<DomainToViewModelMappingProfile>();
            Mapper.Initialize<ViewModelToDomainMappingProfile>();
        }
    }
}