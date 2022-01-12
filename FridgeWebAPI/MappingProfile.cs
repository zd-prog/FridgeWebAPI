using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FridgeWebAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<Fridge, FridgeDto>();
            CreateMap<FridgeProducts, FridgeProductDto>();
            CreateMap<FridgeModel, ModelDto>();
        }
    }
}
