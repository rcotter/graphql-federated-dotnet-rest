using CompaniesService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// GraphQL
builder
   .Services
   .AddGraphQLServer()
   .AddQueryType<Query>()
   .InitializeOnStartup()
   .PublishSchemaDefinition(
                            schema => schema
                                     .SetName("companies")
                                     .IgnoreRootTypes()
                                     .AddTypeExtensionsFromFile("stitching.graphql"));

var baseUrl = "http://localhost:4001";
var app = builder.Build();
app.MapControllers();
app.Logger.LogInformation($"REST: {baseUrl}/api/companies");
app.MapGraphQL();
app.Logger.LogInformation($"GraphQL: {baseUrl}/graphql");
app.Run(baseUrl);