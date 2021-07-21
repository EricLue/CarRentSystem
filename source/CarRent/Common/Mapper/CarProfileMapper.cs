using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.CarManagement.Domain;
using CarRent.CarManagement.Model;
using AutoMapper;

namespace CarRent.Common.Mapper
{
    public class CarProfileMapper : Profile 
    {
        public CarProfileMapper()
        {
            CreateMap<Car, CarDto>()
                .ForMember(goal => goal.Class, extr => extr.MapFrom(src => src.Class.Type))
                .ForMember(goal => goal.DailyPrice, extr => extr.MapFrom(src => src.Class.DailyPrice));

            CreateMap<CarDto, Car>()
                .ForMember(goal => goal.Class, extr => extr.Ignore());

            CreateMap<CarClass, CarClassDto>();

            CreateMap<CarClassDto, CarClass>();
        }
    }
}
