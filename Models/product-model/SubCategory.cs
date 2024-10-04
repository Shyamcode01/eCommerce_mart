using System.ComponentModel.DataAnnotations;

namespace e_commerInventry.Models.product_model
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
