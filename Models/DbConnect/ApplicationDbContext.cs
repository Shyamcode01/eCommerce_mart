using e_commerInventry.Models.product_model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace e_commerInventry.Models.DbConnect
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            


        }

        public DbSet<Application_user> application_Users { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Coupon> coupons { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<OrderDetial> orderDetials { get; set; }
        public DbSet<OrderHeader> orderHeaders { get; set; }
        public DbSet<SubCategory> subCategories { get; set; }


    }
}
