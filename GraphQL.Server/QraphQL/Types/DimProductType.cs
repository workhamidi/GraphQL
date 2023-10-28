using GraphQL.Server.Models;

namespace GraphQL.Server.QraphQL.Types
{
    public class DimProductType : ObjectType<DimProduct>
    {
        protected override void Configure(IObjectTypeDescriptor<DimProduct> descriptor)
        {

            descriptor.Field(dp => dp.Color)
                .Ignore();

            base.Configure(descriptor);
        }
    }
}
