using Application.DTOs;
using Application.Exceptions;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entitities;
using MediatR;

namespace Application.Features.Restaurants.Queries.GetRestaurantById
{
   public class GetRestaurantByIdQuery : IRequest<Response<RestaurantDTO>>
    {
        public int Id;
    }

    public class GetRestaurantByIdQueryHandler : IRequestHandler<GetRestaurantByIdQuery, Response<RestaurantDTO>>
    {
        private readonly IRepositoryAsync<Restaurant> _repositoryAsync;
        private readonly IMapper _mapper;

        public GetRestaurantByIdQueryHandler(IRepositoryAsync<Restaurant> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<RestaurantDTO>> Handle(GetRestaurantByIdQuery request, CancellationToken cancellationToken)
        {
            var restaurant = await _repositoryAsync.GetByIdAsync(request.Id);

            if (restaurant == null)
            {
                throw new ApiException($"Registry was not found with given id {request.Id}");
            }
            else 
            {
                var restaurantDto = _mapper.Map<RestaurantDTO>(restaurant);

                return new Response<RestaurantDTO>(restaurantDto);
            }       
        }
    }
}
