using System.ComponentModel.DataAnnotations;

namespace e_commerInventry.Models.product_model
{
    public class OrderDetial
    {

        [Key]
        public int Id { get; set; }
        public int OrderHeaderId { get; set; }
        public OrderHeader? OrderHeader { get; set; }
        public int ItemId { get; set; }
        public Item? Item { get; set; }
        public int Quntity { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set;}


    }
}
