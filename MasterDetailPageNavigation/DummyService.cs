using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
