using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enum;
using XPrototype.Models;

namespace XPrototype
{
    public static class DummyService
    {
        public static IList<Shop> GetShops()
        {
            IList<Shop> shops = new List<Shop>()
            {
                new Shop()
                {
                    ShopName = "Shop A",
                    Desc = "sample",
                    ImageUrl = "home1.png"
                },
                new Shop()
                {
                    ShopName = "Shop B",
                    Desc = "sample",
                    ImageUrl = "home2.png"
                },
                new Shop()
                {
                    ShopName = "Shop C",
                    Desc = "sample",
                    ImageUrl = "home3.png"
                },
                new Shop()
                {
                    ShopName = "Shop D",
                    Desc = "sample",
                    ImageUrl = "home4.png"
                }
            };

            return shops;
        }
        
        public static List<string> GetTimeSlots()
        {
            var list = new List<string>();
            for (var i = 9; i < 21; i++)
            {
                list.Add(string.Format("{0}:00 - {1}:00", i, i + 1));
            }

            return list;
        }

        public static List<Order> GetOrders()
        {
            var list = new List<Order>();

            list.Add(new Order("SPA", "11:00 - 12:00", OrderStatus.PendingConfirmation));
            list.Add(new Order("Masage", "14:00 - 17:00", OrderStatus.Completed));
            list.Add(new Order("SPA", "9:00 - 13:00", OrderStatus.Completed));
            return list;
        } 
    }
}
