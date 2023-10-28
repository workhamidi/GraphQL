using GraphQL.Server.Models;
using GraphQL.Server.QraphQL.Mutations.DimAccount;

namespace GraphQL.Server.QraphQL.Mutations
{
    public class MutationRoot
    {
        public DimAccountMutation DimAccountMutation()
        {
            return new DimAccountMutation();
        }
    }
}
