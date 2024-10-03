using System.ComponentModel.DataAnnotations;

namespace e_commerInventry.Models.product_model
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Type { get; set; }
        public double Discount { get; set; }
        public double MinimumAmount { get; set; }
        public byte[]? CouponPic { get; set; }
        public bool IsActive { get; set; }
         
    }

    public enum CouponType
    {
        Percent=0,
        Currency=1
    }
}
