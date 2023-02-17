namespace CompaniesService.Dto;

[GraphQLName("Company")]
[GraphQLDescription("A company that produces products")]
public class CompanyDto
{
  [GraphQLType(typeof(IdType))] public int Id { get; set; }

  [GraphQLDescription("The company's full name")]
  public string Name { get; set; }

  [GraphQLName("address")]
  [GraphQLDescription("Where to find the company headquarters")]
  public AddressDto FullAddress { get; set; }

  [GraphQLIgnore] public string Secret { get; set; }
}