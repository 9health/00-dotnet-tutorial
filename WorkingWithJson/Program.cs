Book csharp10 = new(title:
  "C# 10 and .NET 6 - Modern Cross-platform Development")
{
    Author = "Mark J Price",
    PublishDate = new(year: 2021, month: 11, day: 9),
    Pages = 823,
    Created = DateTimeOffset.UtcNow,
};

JsonSerializerOptions options = new()
{
    //IncludeFields = true, // includes all fields
    //PropertyNameCaseInsensitive = true,
    //WriteIndented = true,
    //PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};
options.Converters.Add(new DateOnlyConverter());

string filePath = Combine(CurrentDirectory, "book.json");
using (Stream fileStream = File.Create(filePath))
{
    JsonSerializer.Serialize<Book>(
      utf8Json: fileStream, value: csharp10, options);
}
WriteLine("Written {0:N0} bytes of JSON to {1}",
  arg0: new FileInfo(filePath).Length,  
  arg1: filePath);
WriteLine();
// Display the serialized object graph 
WriteLine(File.ReadAllText(filePath));

public class Book
{
    // constructor to set non-nullable property
    public Book(string title)
    {
        Title = title;
    }
    // properties
    public string Title { get; set; }
    public string? Author { get; set; }
    // fields
    [JsonInclude] // include this field
    public DateOnly PublishDate;
    [JsonInclude] // include this field
    public DateTimeOffset Created;
    public ushort Pages;
}

public class DateOnlyConverter : JsonConverter<DateOnly>
{
    private readonly string serializationFormat;

    public DateOnlyConverter() : this(null)
    {
    }

    public DateOnlyConverter(string? serializationFormat)
    {
        this.serializationFormat = serializationFormat ?? "yyyy-MM-dd";
    }

    public override DateOnly Read(ref Utf8JsonReader reader,
                            Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return DateOnly.Parse(value!);
    }

    public override void Write(Utf8JsonWriter writer, DateOnly value,
                                        JsonSerializerOptions options)
        => writer.WriteStringValue(value.ToString(serializationFormat));
}