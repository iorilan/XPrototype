using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace XMock.Controllers
{
    public class XPrototypeController : Controller
    {
        // GET: XPrototype
        public ActionResult GetShops()
        {
            IList<AShop> shops = new List<AShop>()
            {
                new AShop()
                {
                    ShopName = "Shop A",
                    Desc = "sample",
                    ImageUrl = "http://www.kissessweetspa.com/wp-content/uploads/2013/05/emerging-massage.jpg"
                },
                new AShop()
                {
                    ShopName = "Shop B",
                    Desc = "sample",
                    ImageUrl = "http://barcelonasalon-spa.com/wp-content/uploads/2012/12/spa5.jpg"
                },
                new AShop()
                {
                    ShopName = "Shop C",
                    Desc = "sample",
                    ImageUrl = "http://static1.squarespace.com/static/52291225e4b0af57b790b008/t/522b641fe4b04c838fabf7b1/1378575396909/spa-still-life.jpg"
                },
                new AShop()
                {
                    ShopName = "Shop D",
                    Desc = "sample",
                    ImageUrl = "http://static1.squarespace.com/static/52291225e4b0af57b790b008/t/522b641fe4b04c838fabf7b1/1378575396909/spa-still-life.jpg"
                }
            };

            return Json(shops, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetTimeSlots()
        {
            var list = new List<string>();
            for (var i = 9; i < 21; i++)
            {
                list.Add(string.Format("{0}:00 - {1}:00", i, i + 1));
            }

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }

    public class AShop
    {
        public string ShopName { get; set; }
        public string Desc { get; set; }
        public string ImageUrl { get; set; }
    }
}