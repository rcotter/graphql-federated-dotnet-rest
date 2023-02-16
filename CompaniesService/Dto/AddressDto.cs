namespace CompaniesService;

[GraphQLName("address")]
public class AddressDto
{
  public string Street { get; set; }

  public string Number { get; set; }
  
  public bool IsHeadquarters { get; set; }
}