using CompaniesService.Dto;

namespace CompaniesService;

// Core retrieval logic re-usable by REST and GraphQL
// Excludes any transport specific details. E.g. No status codes.
public class CompaniesService
{
  public IEnumerable<CompanyDto> GetAll() => CompanyStore.List;

  public CompanyDto? GetById(int id) => CompanyStore.List.FirstOrDefault(v => v.Id == id);
}