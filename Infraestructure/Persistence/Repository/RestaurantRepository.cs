using Application.Interfaces;
using Ardalis.Specification.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repositoty
{
    public class RestaurantRepository<T> : RepositoryBase<T>, IRepositoryAsync<T> where T : class
    {
        private readonly RestaurantDbContext dbContext;

        public RestaurantRepository(RestaurantDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
