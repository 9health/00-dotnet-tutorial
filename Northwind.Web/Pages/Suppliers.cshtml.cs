using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc; // [BindProperty], IActionResult
using Packt.Shared;
namespace Northwind.Web.Pages;

public class SuppliersModel: PageModel
{
    public IEnumerable<Supplier> Suppliers { get; set; }

    //store database
    private NorthwindContext db; 
    // set db by constructor
    public SuppliersModel(NorthwindContext injectedContext) 
    {
        db = injectedContext;
    }
    public void OnGet()
    {
        ViewData["Title"] = "9Health - Suppliers";
        Suppliers = db.Suppliers
            .OrderBy(c => c.Country).ThenBy(c => c.CompanyName);
    }
    [BindProperty] //easily connect HTML elements on the web page to properties in the Supplier class.
    public Supplier? Supplier { get; set; }
    public IActionResult OnPost()
    {
        if ((Supplier is not null) && ModelState.IsValid)
        {
            db.Suppliers.Add(Supplier);
            db.SaveChanges();
            return RedirectToPage("/suppliers");
        }
        else
        {
            return Page(); // return to original page
        }
    }
}