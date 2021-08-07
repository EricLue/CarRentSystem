using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRent.ReservationManagement.Domain;
using CarRent.ReservationManagement.Model;
using AutoMapper;

namespace CarRent.ReservationManagement.Mapper
{
    public class ReservationProfileMapper : Profile
    {
        public ReservationProfileMapper()
        {
            CreateMap<Reservation, ReservationDto>()
                .ForMember(goal => goal.CarName, extr => extr.MapFrom(src => src.Car.Make + ' ' + src.Car.Class.Type))
                .ForMember(goal => goal.CustomerName, extr => extr.MapFrom(src => src.Customer.Firstname + ' ' + src.Customer.Familyname))
                .AfterMap((src, goal) => goal.Cost = src.DaysTotal * src.Car.Class.DailyPrice);

            CreateMap<ReservationDto, Reservation>()
                .ForMember(dest => dest.Car, opt => opt.Ignore())
                .ForMember(dest => dest.Customer, opt => opt.Ignore());
        }
    }
}
