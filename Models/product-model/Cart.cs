using System.ComponentModel.DataAnnotations;

namespace e_commerInventry.Models.product_model
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int? ItemId { get; set; }
        public Item? Item { get; set; }
            
        public string? ApplicationUserId { get; set;}
        public Application_user? Application_User { get; set;}
        [Required,MinLength(1)]
        public int? Quntity { get; set; }
    }
}
