using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage; // IDbContextTransaction

namespace Packt.Shared;
// this manages the connection to the database
public class Northwind: DbContext
{
    // these properties map to tables in the database
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies(); //enable lazy loading

        if (ProjectConstants.DatabaseProvider == "SQLite")
        {
            string path = Combine(CurrentDirectory, "Northwind.db");
            WriteLine($"Using {path} database file.");
            optionsBuilder.UseSqlServer($"Filename={path}");
        }
        else
        {
            string connection = "Data Source=tcp:***.***.*.*,1433;" +
                        "Initial Catalog=Northwind;" +
                        "User Id=sa;" +
                        "Password=********!;" +
                        "Integrated Security = false;" +
                        "MultipleActiveResultSets = true;";
            optionsBuilder.UseSqlServer(connection);
        }
    }
    protected override void OnModelCreating(
      ModelBuilder modelBuilder)
    {
        // example of using Fluent API instead of attributes
        // to limit the length of a category name to 15
        modelBuilder.Entity<Category>()
          .Property(category => category.CategoryName)
          .IsRequired() // NOT NULL
          .HasMaxLength(15);
        if (ProjectConstants.DatabaseProvider == "SQLite")
        {
            // added to "fix" the lack of decimal support in SQLite
            modelBuilder.Entity<Product>()
              .Property(product => product.Cost)
              .HasConversion<double>();
        }
        modelBuilder.Entity<Product>()
            .HasQueryFilter(p => !p.Discontinued);
    }
}
