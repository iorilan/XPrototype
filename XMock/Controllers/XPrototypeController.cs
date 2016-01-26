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
                    ImageUrl = "http://www.hanselman.com/images/photo-scott-tall.jpg"
                },
                new AShop()
                {
                    ShopName = "Shop B",
                    Desc = "sample",
                    ImageUrl = "http://www.hanselman.com/images/photo-scott-tall.jpg"
                },
                new AShop()
                {
                    ShopName = "Shop C",
                    Desc = "sample",
                    ImageUrl = "http://www.hanselman.com/images/photo-scott-tall.jpg"
                },
                new AShop()
                {
                    ShopName = "Shop D",
                    Desc = "sample",
                    ImageUrl = "http://www.hanselman.com/images/photo-scott-tall.jpg"
                }
            };

            return Json(shops, JsonRequestBehavior.AllowGet);
        }
    }

    public class AShop
    {
        public string ShopName { get; set; }
        public string Desc { get; set; }
        public string ImageUrl { get; set; }
    }
}