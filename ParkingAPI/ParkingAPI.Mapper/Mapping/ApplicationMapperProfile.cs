using AutoMapper;
using ParkingAPI.Contracts.Parking;
using ParkingAPI.Domain.Entities;

namespace ParkingAPI.Mapper.Mapping
{
    public class ApplicationMapperProfile : Profile
    {
        public ApplicationMapperProfile()
        {
            CreateMap<Parking, ParkingDTO>();
            CreateMap<ParkingDTO, Parking>();
        }
    }
}