using CompaniesService.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CompaniesService.Controllers
{
  [Route("api/companies")]
  [ApiController]
  public class CompaniesController : ControllerBase
  {
    private readonly CompaniesService companies = new();

    [HttpGet]
    public ActionResult<IEnumerable<CompanyDto>> GetAll() => Ok(companies.GetAll());

    [HttpGet("{id}")]
    public ActionResult<CompanyDto> GetById(int id)
    {
      var company = companies.GetById(id);
      if (company == null) { return NotFound(); }
      return Ok(company);
    }
  }
}