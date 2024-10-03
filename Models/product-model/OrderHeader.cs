namespace e_commerInventry.Models.product_model
{
    public class OrderHeader
    {
        public int Id { get; set; }
        public string? ApplicationUserId { get; set; }
        public Application_user? Application_User { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime TimeOfPick { get; set; }
        public DateTime DateOfPic { get; set; }
        
        public double SubTotal { get; set; }

        public double OrderTotal { get; set; }
        public string? CouponCode { get; set; }
        public string? CouponDis { get; set; }
        public string? TransactionId { get; set; }
        public string? OrderStatus { get; set; }
        public string? PaymentStatus { get; set; }
        public string? Name { get; set;}
        public string? Phone { get; set; }
    }
}
