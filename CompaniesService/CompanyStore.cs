using CompaniesService.Dto;

namespace CompaniesService;

public static class CompanyStore
{
  public static readonly List<CompanyDto> List = new()
  {
      new CompanyDto
      {
          Id = 1,
          Name = "A Corp",
          Secret = "You won't believe it",
          FullAddress = new AddressDto(Street: "Some Street", Number: "123", IsHeadquarters: true)
      },
      new CompanyDto
      {
          Id = 2,
          Name = "B Corp",
          Secret = "Don't let it get out",
          FullAddress = new AddressDto(Street: "Another Drive", Number: "456", IsHeadquarters: false)
      },
  };
}