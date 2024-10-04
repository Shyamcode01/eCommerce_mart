using e_commerInventry.Models.product_model;

namespace e_commerInventry.Models.ViewModel
{
    public class ItemViewModel
    {

        public int itemId { get; set; }
      
        public string? Title { get; set; }
     
        public string? Description { get; set; }

        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }
        
        public int SubCategoryId { get; set; }
    }
}
