namespace ProductsService;

public static class ProductStore
{
  public static readonly List<ProductDto> List = new()
  {
      new ProductDto(Id: 1, Name: "Wine (A Corp)", CompanyId: 1),
      new ProductDto(Id: 2, Name: "Beer (A Corp)", CompanyId: 1),
      new ProductDto(Id: 3, Name: "Rum (A Corp)", CompanyId: 1),
      new ProductDto(Id: 4, Name: "Wine (B Corp)", CompanyId: 2),
      new ProductDto(Id: 5, Name: "Beer (B Corp)", CompanyId: 2),
      new ProductDto(Id: 6, Name: "Rum (B Corp)", CompanyId: 2),
  };
}