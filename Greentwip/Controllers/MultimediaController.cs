using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Greentwip.Controllers
{
    public class MultimediaController : Controller
    {
        // GET: Multimedia
        public ActionResult Images()
        {
            return View();
        }
        public ActionResult Videos()
        {
            return View();
        }
        public ActionResult Games()
        {
            return View();
        }
    }
}