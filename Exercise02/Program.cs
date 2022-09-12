using Packt.Shared;
using System.IO;

//QueryCategoriesProducts();

using (Northwind db = new())
{
    IQueryable<Category>? categories = db.Categories?.Include(c => c.Products);
    GenerateCsvFile(categories);
    GenerateJsonFile(categories);
}

static void GenerateCsvFile(IQueryable<Category> categories)
{
    string csvFile = "categories-and-products.csv";
    using (FileStream csvStream = File.Create(Combine(CurrentDirectory, csvFile)))
    {
        using (StreamWriter csv = new StreamWriter(csvStream))
        {
            csv.WriteLine("CategoryId,CategoryName,Description,ProductId,ProductName,Cost,Stock,Discontinued");
            foreach (Category c in categories)
            {
                foreach (Product p in c.Products)
                {
                    csv.Write("{0},\"{1}\",\"{2}\",",
                      arg0: c.CategoryId,
                      arg1: c.CategoryName,
                      arg2: c.Description);

                    csv.Write("{0},\"{1}\",{2},",
                      arg0: p.ProductId,
                      arg1: p.ProductName,
                      arg2: p.Cost is null ? 0 : p.Cost.Value);

                    csv.WriteLine("{0},{1}",
                      arg0: p.Stock,
                      arg1: p.Discontinued);
                }
            }
        }
    }
    WriteLine("{0} contains {1:N0} bytes.",
    arg0: csvFile,
    arg1: new FileInfo(csvFile).Length);
}

static void GenerateJsonFile(IQueryable<Category> categories)
{
    string jsonFile = "categories-and-products.json";
    using (FileStream jsonStream = File.Create(Combine(CurrentDirectory, jsonFile)))
    {
        using (Utf8JsonWriter json = new Utf8JsonWriter(jsonStream, new JsonWriterOptions { Indented = true }))
        {
            json.WriteStartObject();
            json.WriteStartArray("categories");

            foreach (Category c in categories)
            {
                json.WriteStartObject(); //category

                json.WriteNumber("id", c.CategoryId);
                json.WriteString("name", c.CategoryName);
                json.WriteString("desc", c.Description);
                json.WriteNumber("products_count", c.Products.Count);

                json.WriteStartArray("products"); //Array products

                foreach(Product p in c.Products)
                {
                    json.WriteStartObject(); //product

                    json.WriteNumber("id", p.ProductId);
                    json.WriteString("name", p.ProductName);
                    json.WriteNumber("cost", p.Cost is null ? 0 : p.Cost.Value);
                    json.WriteNumber("stock", p.Stock is null ? 0 : p.Stock.Value);
                    json.WriteBoolean("discontinued?", p.Discontinued);

                    json.WriteEndObject(); //product
                }
                json.WriteEndArray(); //Array products
                json.WriteEndObject(); //category
            }
            json.WriteEndArray(); 
            json.WriteEndObject(); //categories
        }
    }
    WriteLine("{0} contains {1:N0} bytes.",
        arg0: jsonFile,
        arg1: new FileInfo(jsonFile).Length);
}