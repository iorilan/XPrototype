using Common.Enum;

namespace XPrototype.Models
{
    public class Order
    {
        public Order(string shopName, string range, OrderStatus status)
        {
            ShopName = shopName;
            TimeRange = range;
            Status = status;
        }

        public string ShopName { get; set; }
        public string TimeRange { get; set; }
        public OrderStatus Status { get; set; }
    }
}
