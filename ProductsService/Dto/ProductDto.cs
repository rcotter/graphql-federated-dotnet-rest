namespace ProductsService;

[GraphQLName("Product")]
[GraphQLDescription("A product produced by a company")]
public class ProductDto
{
  [GraphQLType(typeof(IdType))] public int Id { get; set; }

  [GraphQLDescription("The product's full name")]
  public string Name { get; set; }

  [GraphQLType(typeof(IdType))]
  [GraphQLDescription("Go find this in the Company Service and connect it yourself")]
  public int CompanyId { get; set; }
}