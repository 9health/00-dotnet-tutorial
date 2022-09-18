using Microsoft.AspNetCore.Identity; // RoleManager, UserManager
using Microsoft.AspNetCore.Mvc; // controller, IActionResult
using System.Data;
using static System.Console;
namespace Northwind.Mvc.Controllers;
public class RolesController : Controller
{
    private string AdminRole = "Administrators";
    private string UserEmail = "9health@9life.com";
    private readonly RoleManager<IdentityRole> roleManager;
    private readonly UserManager<IdentityUser> userManager;
    public RolesController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
    {
        //the constructor gets and stores the registered user and role manager dependency services.
        this.roleManager = roleManager;
        this.userManager = userManager;
    }
    public async Task<IActionResult> Index()
    {
        // If the Administrators role does not exist, we use the role manager to create it.
        if (!(await roleManager.RoleExistsAsync(AdminRole)))
        {
            await roleManager.CreateAsync(new IdentityRole(AdminRole));
        }
        //We try to find a test user by its email,  
        IdentityUser user = await userManager.FindByEmailAsync(UserEmail);
        //create it if it does not exist
        if (user == null)
        {
            user = new();
            user.UserName = UserEmail;
            user.Email = UserEmail;
            IdentityResult result = await userManager.CreateAsync(user, "Pa$$w0rd");
            if (result.Succeeded)
            {
                WriteLine($"User {user.UserName} created successfully.");
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    WriteLine(error.Description);
                }
            }
        }
        if (! await userManager.IsInRoleAsync(user, AdminRole))
        {
            // then assign the user to the Administrators role.
            IdentityResult result = await userManager.AddToRoleAsync(user, AdminRole);
            if (result.Succeeded)
            {
                WriteLine($"User {user.UserName} added to {AdminRole} successfully.");
            }
            else
            {
                foreach(IdentityError error in result.Errors)
                {
                    WriteLine(error.Description);
                }
            }
        }
        //automatically redirected to the home page.
        return Redirect("/");
    }
}