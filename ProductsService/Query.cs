namespace ProductsService;

public class Query
{
  private readonly ProductsService products = new();

  [GraphQLName("productById")]
  public ProductDto? GetById([GraphQLType(typeof(IdType))] int id) => products.GetById(id);

  [GraphQLName("products")]
  public IEnumerable<ProductDto> GetAll() => products.GetAll();

  [GraphQLName("productsByCompanyId")]
  public IEnumerable<ProductDto> GetProductsByCompanyId([GraphQLType(typeof(IdType))] int id)
  {
    Console.WriteLine($"Getting products for company {id}");
    var p =  products.GetAll().Where(p => p.CompanyId == id);
    Console.WriteLine(p);
    return p;
  }
}