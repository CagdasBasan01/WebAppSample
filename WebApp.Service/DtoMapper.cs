using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Core.DTOs;
using WebApp.Core.Models;

namespace WebApp.Service
{
    internal class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}