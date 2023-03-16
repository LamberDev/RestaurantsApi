using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entitities;
using MediatR;

namespace Application.Features.Clients.Commands.CreateRestaurant
{
    public class CreateRestaurantCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }

        public CreateRestaurantCommand(int id, string name, string email, string phoneNumber, string street, string city, string country, string postalCode)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Street = street;
            City = city;
            Country = country;
            PostalCode = postalCode;
        }
    }

    public class CreateClientCommandHandler : IRequestHandler<CreateRestaurantCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Restaurant> _repositoryAsync;
        private readonly IMapper _mapper;

        public CreateClientCommandHandler(IRepositoryAsync<Restaurant> repositoryAsync, IMapper mapper) 
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }
        public async Task<Response<int>> Handle(CreateRestaurantCommand request, CancellationToken cancellationToken)
        {
            var newRecord = _mapper.Map<Restaurant>(request);
            var data = await _repositoryAsync.AddAsync(newRecord);

            return new Response<int>(data.Id);
        }
    }
}
