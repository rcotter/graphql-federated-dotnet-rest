using Microsoft.AspNetCore.Mvc;

namespace ProductsService.Controllers
{
  [Route("api/products")]
  [ApiController]
  public class ProductsController : ControllerBase
  {
    private readonly ProductsService products = new();

    [HttpGet]
    public ActionResult<IEnumerable<ProductDto>> GetAll() => Ok(products.GetAll());

    [HttpGet("{id}")]
    public ActionResult<ProductDto> GetById(int id)
    {
      var product = products.GetById(id);
      if (product == null) { return NotFound(); }
      return Ok(product);
    }
  }
}