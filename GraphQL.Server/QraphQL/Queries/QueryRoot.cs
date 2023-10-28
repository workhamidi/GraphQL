namespace GraphQL.Server.QraphQL.Queries
{
    public class QueryRoot 
    {
        public DimAccountEntity DimAccountEntity()
        {
            return new DimAccountEntity();
        }
        public DimCustomerEntity DimCustomerEntity()
        {
            return new DimCustomerEntity();
        }

        public DimProductEntity DimProductEntity()
        {
            return new DimProductEntity();
        }
    }
}
