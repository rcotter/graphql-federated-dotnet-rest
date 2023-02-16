using ProductsService;

var builder = WebApplication.CreateBuilder(args);

// Add REST services to the container.
builder.Services.AddControllers();

// GraphQL
builder
   .Services
   .AddGraphQLServer() 
   .AddQueryType<Query>()
   .InitializeOnStartup()
   .PublishSchemaDefinition(
                            schema => schema
                                     .SetName("products")
                                     .IgnoreRootTypes()
                                     .AddTypeExtensionsFromFile("stitching.graphql"));

var baseUrl = "http://localhost:4002";
var app = builder.Build();
app.MapControllers();
app.Logger.LogInformation($"REST: {baseUrl}/api/products");
app.MapGraphQL();
app.Logger.LogInformation($"GraphQL: {baseUrl}/graphql");
app.Run(baseUrl);