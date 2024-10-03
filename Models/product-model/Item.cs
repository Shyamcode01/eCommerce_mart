using System.ComponentModel.DataAnnotations;

namespace e_commerInventry.Models.product_model
{
    public class Item
    {

        [Key]
        public int itemId { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
            
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }


    }
}
