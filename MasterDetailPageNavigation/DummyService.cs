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
                    ImageUrl = "http://www.kissessweetspa.com/wp-content/uploads/2013/05/emerging-massage.jpg"
                },
                new Shop()
                {
                    ShopName = "Shop B",
                    Desc = "sample",
                    ImageUrl = "http://barcelonasalon-spa.com/wp-content/uploads/2012/12/spa5.jpg"
                },
                new Shop()
                {
                    ShopName = "Shop C",
                    Desc = "sample",
                    ImageUrl = "http://static1.squarespace.com/static/52291225e4b0af57b790b008/t/522b641fe4b04c838fabf7b1/1378575396909/spa-still-life.jpg"
                },
                new Shop()
                {
                    ShopName = "Shop D",
                    Desc = "sample",
                    ImageUrl = "http://static1.squarespace.com/static/52291225e4b0af57b790b008/t/522b641fe4b04c838fabf7b1/1378575396909/spa-still-life.jpg"
                }
            };

            return shops;
        }
    }
}
