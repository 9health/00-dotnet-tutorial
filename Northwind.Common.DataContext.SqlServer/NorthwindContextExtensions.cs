using Microsoft.EntityFrameworkCore; // UseSqlServer
using Microsoft.Extensions.DependencyInjection; // IServiceCollection
namespace Packt.Shared;
public static class NorthwindContextExtensions
{
    /// <summary>
    /// Adds NorthwindContext to the specified IServiceCollection. Uses the SqlServer database provider.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="connectionString">Set to override the default.</param>
    /// <returns>An IServiceCollection that can be used to add more services.</returns>
    public static IServiceCollection AddNorthwindContext(
        this IServiceCollection services, string connectionString =
        "Data Source=tcp:192.168.1.5,1433;Initial Catalog=Northwind;User Id=sa;Password=1Lik39Health!;Integrated Security=false;MultipleActiveResultSets=true")
    {
        services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(connectionString));
        return services;
    }
}