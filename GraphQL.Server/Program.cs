using GraphQL.Server.Models;
using GraphQL.Server.QraphQL;
using GraphQL.Server.QraphQL.Mutations;
using GraphQL.Server.QraphQL.Queries;
using GraphQL.Server.QraphQL.Types;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// By default the DBContext pool will keep 128 DBContext instances in its pool.
builder.Services.AddPooledDbContextFactory<AdventureWorksDw2019Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString")));



builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<AdventureWorksDw2019Context>(DbContextKind.Pooled)
    .AddQueryType<QueryRoot>()
    .AddMutationType<MutationRoot>()
    .AddType<DimProductType>()
    .AddTransactionScopeHandler<TransactionScopeHandler>();




builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseRouting();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseEndpoints(endpoints =>
{
    // "/graphql"
    endpoints.MapGraphQL();

    // "ui/voyager"
    endpoints.MapGraphQLVoyager();
});

app.Run();
