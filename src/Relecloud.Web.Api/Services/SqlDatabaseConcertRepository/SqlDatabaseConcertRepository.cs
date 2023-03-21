using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Relecloud.Web.Api.Infrastructure;
using Relecloud.Web.Models.ConcertContext;
using System.Text.Json;

namespace Relecloud.Web.Api.Services.SqlDatabaseConcertRepository
{
    public class SqlDatabaseConcertRepository : IConcertRepository, IDisposable
    {
        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public Task<CreateResult> CreateConcertAsync(Concert newConcert)
        {
            throw new NotImplementedException();
        }

        public Task<CreateResult> CreateCustomerAsync(Customer newCustomer)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateResult> CreateOrUpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteResult> DeleteConcertAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<Ticket>> GetAllTicketsAsync(string userId, int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<Concert?> GetConcertByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Concert>> GetConcertsByIdAsync(ICollection<int> ids)
        {
            throw new NotImplementedException();
        }

        public Task<Customer?> GetCustomerByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket?> GetTicketByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Concert>> GetUpcomingConcertsAsync(int count)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetUserByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateResult> UpdateConcertAsync(Concert model)
        {
            throw new NotImplementedException();
        }
    }
}