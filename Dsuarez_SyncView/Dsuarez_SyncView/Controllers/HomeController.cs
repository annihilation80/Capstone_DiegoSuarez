using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dsuarez_SyncView.Models;
using System.IO;

namespace Dsuarez_SyncView.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        
        public ActionResult Index()
        {

            if (Request.Form["submit"] != null)
            {
                Session["nickname"] = Request.Form["nickname"];
                ViewBag.videoURL = Request.Form["videoURL"];
            }

            return View();
        }
        
        public ActionResult VideoBrowser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult VideoUpload(HttpPostedFileBase file)
        {
            if (file != null)
            {
                if (file.ContentType.Equals("video/webm"))
                {
                    var filename = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Videos"), filename);
                    file.SaveAs(path);

                    var newPath = Path.Combine(Server.MapPath("~/Videos"), "movie.webm");

                    System.IO.File.Delete(newPath);
                    System.IO.File.Copy(path, newPath);
                    System.IO.File.Delete(path);

                    Session["VideoPath"] = newPath;
                    Session["IsHost"] = true;
                }
            }

            return RedirectToAction("VideoBrowser");
        }

        public ActionResult VideoDelete(string path)
        {
            System.IO.File.Delete((string)Session["VideoPath"]);
            Session["IsHost"] = false;
            return RedirectToAction("VideoBrowser");
        }

        public ActionResult AboutPage()
        {
            return View();
        }

    }
}
