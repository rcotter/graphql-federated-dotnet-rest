namespace ProductsService;

[GraphQLName("Product")]
[GraphQLDescription("A product produced by a company")]
public record ProductDto(
    [GraphQLType(typeof(IdType))] int Id,
    
    [GraphQLDescription("The product's full name")]
    string Name,
    
    [GraphQLType(typeof(IdType))]
    [GraphQLDescription("Go find this in the Company Service and connect it yourself")]
    int CompanyId);