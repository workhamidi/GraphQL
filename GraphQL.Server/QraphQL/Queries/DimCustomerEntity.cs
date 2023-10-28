using GraphQL.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Server.QraphQL.Queries
{
    public class DimCustomerEntity 
    {
        public Task<IQueryable<DimCustomer>> DimCustomerQuery(AdventureWorksDw2019Context context)
        {
            return Task.FromResult(context
                    .DimCustomers
                    .Include(dc => dc.GeographyKeyNavigation)
                    .AsNoTracking()
                    .AsQueryable());
        }
    }
}
