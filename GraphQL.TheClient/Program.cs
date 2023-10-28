



/*
install packages: 

GraphQL.client
GraphQL.Client.Serializer.Newtonsoft

*/

// server initialization

using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

await Task.Delay(5000);



var serverUri = new Uri("https://localhost:7126/graphql");


var graphQLOptions = new GraphQLHttpClientOptions
{
    EndPoint = serverUri,
};

var graphQLHttpClient = new GraphQLHttpClient(graphQLOptions, new NewtonsoftJsonSerializer());



var request = new GraphQLRequest
{
    Query = @"query {
  dimAccountEntity {
    dimAccountQuery {
      accountKey
    }
  }
}
"
};

var response = await graphQLHttpClient.SendQueryAsync<object>(request);

Console.WriteLine(response.Data);


// JsonConvert.DeserializeObject<List<T>>(stringResult);


Console.WriteLine("Press any key to exit...");

Console.ReadKey();

