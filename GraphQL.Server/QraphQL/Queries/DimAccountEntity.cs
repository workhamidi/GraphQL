using GraphQL.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Server.QraphQL.Queries
{
    public class DimAccountEntity
    {
        public Task<IQueryable<DimAccount>> DimAccountQuery(AdventureWorksDw2019Context context)
        {
            return Task.FromResult(context.DimAccounts.AsNoTracking());
        }
    }
}
