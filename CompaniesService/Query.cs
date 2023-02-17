using CompaniesService.Dto;

namespace CompaniesService;

public class Query
{
  private readonly CompaniesService companies = new();

  [GraphQLName("companies")]
  public IEnumerable<CompanyDto> GetAll() => companies.GetAll();
  
  [GraphQLName("companyById")]
  [GraphQLDescription("Get a single company by its ID")]
  public CompanyDto? GetById([GraphQLType(typeof(IdType))] int id)
  {
    // TODO remove
    Console.WriteLine($"Getting company by id {id}");
    return companies.GetById(id);
  }
}