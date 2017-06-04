using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkromaCentral.Models;
using AkromaCentral.DAL;

namespace AkromaCentral.Controllers
{
    public class CommController : Controller
    {
        // GET: Comm
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult deadmanswitch()
        {
            bool status = false;
            string message = "None";
            using (AkromaContext db = new AkromaContext())
            {
                var d = db.deadman.FirstOrDefault();
                if (null == d)
                {
                    try
                    {
                        var nd = new deadman() { date = DateTime.Now };
                        db.deadman.Add(nd);
                        db.SaveChanges();
                        status = true;
                        message = "New deadman switch created";
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        message = "Exception during saving deadman object to database";
                    }
                }
                else
                {
                    try
                    {
                        d.date = DateTime.Now;
                        db.SaveChanges();
                        status = true;
                        message = "deadman swithc averted OK";
                    }
                    catch (Exception ex)
                    {
                        status = false;
                        message = "Exception during saving deadman object to database";
                    }
                }
                var r = new { status = status, message = message };

                return Json(r, JsonRequestBehavior.AllowGet);

            }

        }
    }
}