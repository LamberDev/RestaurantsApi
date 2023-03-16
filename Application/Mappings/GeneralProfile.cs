using Application.DTOs;
using Application.Features.Clients.Commands.CreateRestaurant;
using AutoMapper;
using Domain.Entitities;

namespace Application.Mappings
{
    public class GeneralProfile: Profile
    {
        public GeneralProfile() 
        {

            #region DTO
            CreateMap<Restaurant,RestaurantDTO>();
            #endregion


            #region Commands
            CreateMap<CreateRestaurantCommand, Restaurant>();
            #endregion
        }
    }
}
