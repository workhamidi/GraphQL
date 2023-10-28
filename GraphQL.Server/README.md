

1. install package packages 

HotChocolate.AspNetCore
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
graphql.server.ui.voyager

2. register HotChocolate to di 

3. add to pipeline

'''
app.UseRouting();
.....
app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL("/graphql");
    endpoints.MapGraphQLVoyager("ui/voyager");
});
'''


4. create graphql folder and add 
query, mutation and so on to it 



-- for multi thread operation with context use
-> AddPooledDbContextFactory


-- use "AsNoTracking" for increase ef query speed



-- for ignore field of model use
-> create "DimProductType"
-> AddType<DimProductType>()








