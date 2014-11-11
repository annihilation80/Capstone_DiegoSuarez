using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dsuarez_SyncView.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            if (Session["nickname"] == null)
            {
                Session["nickname"] = Request.Form["nickname"];
            }

            return View();
        }
        
        public ActionResult VideoBrowser()
        {        
            return View();
        }

        public ActionResult AboutPage()
        {
            return View();
        }

    }
}
