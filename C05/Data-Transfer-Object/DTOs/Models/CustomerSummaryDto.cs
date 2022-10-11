using System.Text.Json.Serialization;

namespace DTOs.Models;
public record class CustomerSummaryDto(
    [property: JsonPropertyName("id")]
    int Id,
    [property: JsonPropertyName("name")]
    string Name,
    [property: JsonPropertyName("totalNumberOfContracts")]
    int TotalNumberOfContracts,
    [property: JsonPropertyName("numberOfOpenContracts")]
    int NumberOfOpenContracts
    );