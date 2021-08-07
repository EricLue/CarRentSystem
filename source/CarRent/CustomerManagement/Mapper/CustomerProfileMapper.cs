using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CustomerManagement.Domain;
using CarRent.CustomerManagement.Model;
using AutoMapper;

namespace CarRent.CustomerManagement.Mapper
{
    public class CustomerProfileMapper : Profile
    {
        public CustomerProfileMapper()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(goal => goal.PostCode, extr => extr.MapFrom(src => src.PostCode.PostCode))
                .ForMember(goal => goal.Country, extr => extr.MapFrom(src => src.PostCode.Country))
                .ForMember(goal => goal.City, extr => extr.MapFrom(src => src.PostCode.Country));
            CreateMap<CustomerDto, Customer>()
                .ForMember(goal => goal.PostCode, opt => opt.Ignore());

            CreateMap<PostalCode, PostalCodeDto>();
            CreateMap<PostalCodeDto, PostalCode>();
        }
    }
}
