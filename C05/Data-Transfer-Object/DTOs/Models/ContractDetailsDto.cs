using System.Text.Json.Serialization;

namespace DTOs.Models;

public record class ContractDetailsDto(
    [property: JsonPropertyName("id")]
    int Id,
    [property: JsonPropertyName("name")]
    string Name,
    [property: JsonPropertyName("description")]
    string Description,
    [property: JsonPropertyName("workTotal")]
    int WorkTotal,
    [property: JsonPropertyName("workDone")]
    int WorkDone,
    [property: JsonPropertyName("workState")]
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    WorkState WorkState,
    [property: JsonPropertyName("primaryContactFirstname")]
    string PrimaryContactFirstname,
    [property: JsonPropertyName("primaryContactLastname")]
    string PrimaryContactLastname,
    [property: JsonPropertyName("primaryContactEmail")]
    string PrimaryContactEmail
);
