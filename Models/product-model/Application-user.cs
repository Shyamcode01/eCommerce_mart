using Microsoft.AspNetCore.Identity;

namespace e_commerInventry.Models.product_model
{
    public class Application_user:IdentityUser
    {

        
        public  string? Name { get; set; }
        public string? City { get; set;}
        public string? Address { get; set;}
        public string? PostalCode { get; set;}

    }
}
