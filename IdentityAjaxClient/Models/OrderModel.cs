using System.Collections.Generic;

namespace IdentityAjaxClient.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string? UserEmail { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public List<OrderDetailModel> OrderDetails { get; set; } = new List<OrderDetailModel>();
    }

    public class OrderDetailModel
    {
        public int Id { get; set; }
        public int OrchidId { get; set; }
        public string? OrchidName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
    }

    public class OrderCreateModel
    {
        public List<OrderDetailCreateModel> OrderDetails { get; set; } = new List<OrderDetailCreateModel>();
    }

    public class OrderDetailCreateModel
    {
        public int OrchidId { get; set; }
        public int Quantity { get; set; }
    }
}