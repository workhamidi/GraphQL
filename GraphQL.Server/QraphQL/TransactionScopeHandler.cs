using System.Transactions;
using HotChocolate.Execution;
using HotChocolate.Execution.Processing;
namespace GraphQL.Server.QraphQL
{
    public class TransactionScopeHandler : ITransactionScopeHandler
    {

        public virtual ITransactionScope Create(IRequestContext context)
        {
            return new DefaultTransactionScope(
                context,
                new TransactionScope(
                    TransactionScopeOption.Required,
                    new TransactionOptions
                    {
                        IsolationLevel = IsolationLevel.ReadCommitted
                    }));
        }
    }
}
