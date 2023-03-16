using Application.Features.Clients.Commands.CreateRestaurant;
using Application.Features.Restaurants.Queries.GetRestaurantById;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantsApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class RestaurantsController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreateRestaurant(CreateRestaurantCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetRestaurantById(int id)
        {
            return Ok(await Mediator.Send(new GetRestaurantByIdQuery { Id = id }));
        }
    }
}
