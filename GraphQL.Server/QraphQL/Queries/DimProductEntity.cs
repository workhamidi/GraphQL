using GraphQL.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Server.QraphQL.Queries
{
    public class DimProductEntity
    {
        public Task<IQueryable<DimProduct>> DimProductQuery(AdventureWorksDw2019Context context)
        {
            return Task.FromResult(context.DimProducts.AsNoTracking());
        }

        public async Task<DimProduct?> DimProductWithId(
            AdventureWorksDw2019Context context, int id)
        {
            return await context.DimProducts.AsNoTracking()
                .FirstOrDefaultAsync(dp => dp.ProductKey == id);
        }

    }
}
