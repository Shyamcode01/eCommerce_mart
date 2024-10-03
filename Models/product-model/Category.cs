using System.ComponentModel.DataAnnotations;

namespace e_commerInventry.Models.product_model
{
    public class Category

    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }

    }
}
