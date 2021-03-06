﻿using Common.Enum;

namespace XMock.Models
{
    public class AOrder
    {
        public AOrder(string shopId, string shopName, string range)
        {
            ShopId = shopId;
            ShopName = shopName;
            TimeRange = range;
            Status = OrderStatus.PendingConfirmation;
        }

        public string ShopId { get; set; }
        public string ShopName { get; set; }
        public string TimeRange { get; set; }
        public OrderStatus Status { get; set; }
    }
}