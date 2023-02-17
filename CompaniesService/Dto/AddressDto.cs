namespace CompaniesService.Dto;

[GraphQLName("Address")]
public record AddressDto(string Street, string Number, bool IsHeadquarters);