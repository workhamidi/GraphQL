using GraphQL.Server.Models;
using GraphQL.Server.QraphQL.Mutations.DimAccount;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Server.QraphQL.Mutations.DimAccount
{
    public class DimAccountMutation
    {
        public async Task<PayloadAddDimAccount> AddDimAccount
        (AdventureWorksDw2019Context context, InputAddDimAccount addDimAccount)
        {

            var newDimAccount = new Models.DimAccount()
            {
                ParentAccountKey = addDimAccount.parentAccountKey,
                AccountType = addDimAccount.accountType
            };


            var res = await context
                .DimAccounts.AddAsync(newDimAccount);

            await context.SaveChangesAsync();

            return new PayloadAddDimAccount(res.Entity.AccountKey);
        }
    }

}
