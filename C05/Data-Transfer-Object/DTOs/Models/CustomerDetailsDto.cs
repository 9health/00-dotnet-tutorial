using System.Text.Json.Serialization;

namespace DTOs.Models;

public record class CustomerDetailsDto(
    [property: JsonPropertyName("id")]
    int Id,
    [property: JsonPropertyName("name")]
    string Name,
    [property: JsonPropertyName("contracts")]
    IEnumerable<ContractDetailsDto> Contracts
);
