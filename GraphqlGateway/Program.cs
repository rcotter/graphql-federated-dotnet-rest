var builder = WebApplication.CreateBuilder(args);

// Federated schemas
const string companiesSchema = "companies";
const string productsSchema = "products";

builder
   .Services
   .AddHttpClient(
                  companiesSchema,
                  c => c.BaseAddress = new Uri("http://localhost:4001/graphql"));

builder
   .Services
   .AddHttpClient(
                  productsSchema,
                  c => c.BaseAddress = new Uri("http://localhost:4002/graphql"));

builder
   .Services
   .AddGraphQLServer()
   .AddQueryType(d => d.Name("Query"))
   .AddRemoteSchema(companiesSchema)
   .AddRemoteSchema(productsSchema);

var baseUrl = "http://localhost:4000";
var app = builder.Build();
app.MapGraphQL();
app.Logger.LogInformation($"GraphQL Gateway: {baseUrl}/graphql");
app.Run(baseUrl);