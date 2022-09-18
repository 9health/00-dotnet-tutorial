using Packt.Shared;
namespace Northwind.Mvc.Models;
public record HomeIndexViewModel //immutable class
(
    int VisitorCount,
    IList<Category> Categories,
    IList<Product>  Products
);