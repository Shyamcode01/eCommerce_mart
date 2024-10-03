using e_commerInventry.Models.DbConnect;
using e_commerInventry.Models.product_model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace e_commerInventry.Models.Repository
{
    public class DbInitializer : IDbinitializer
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _Context;

        public DbInitializer( RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager,ApplicationDbContext dbContext)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _Context = dbContext;

        }
        public void Initialize()
        {
            try
            {
                if(_Context.Database.GetPendingMigrations().Count() > 0)
                {
                    _Context.Database.Migrate();
                }

            }catch(Exception ex)
            {
                throw;
            }

            if (_Context.Roles.Any(x => x.Name == "Admin")) return;
            _roleManager.CreateAsync(new IdentityRole("Manager")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Custormer")).GetAwaiter().GetResult();

            var user = new Application_user()
            {
                UserName="admin@gmail.com",
                Email="admin@gmail.com",
                Name="Admin",
                City="ghazipur",
                Address="dullahapur",
                PostalCode="275202"

            };
            _userManager.CreateAsync(user,"admin@gmail.com").GetAwaiter().GetResult();
            _userManager.AddToRoleAsync(user, "Admin");
        }
    }
}
