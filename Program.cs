using e_commerInventry.Models.DbConnect;
using e_commerInventry.Models.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
 

namespace e_commerInventry
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // add db connection 
            builder.Services.AddDbContext<ApplicationDbContext>(option=>
            option.UseSqlServer(builder.Configuration.GetConnectionString("dbcs")));

            // identity connection
            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddDefaultTokenProviders().AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddScoped<IDbinitializer, DbInitializer>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{area=Admin}/{controller=Category}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
