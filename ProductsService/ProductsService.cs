namespace ProductsService;

public class ProductsService
{
  public IEnumerable<ProductDto> GetAll() => ProductStore.List;

  public ProductDto? GetById(int id) => ProductStore.List.FirstOrDefault(v => v.Id == id);
}