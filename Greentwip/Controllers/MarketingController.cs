using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Greentwip.Models;
using Greentwip.Logic;

namespace Greentwip.Controllers
{
    [Authorize]
    public class MarketingController : Controller
    {
        // GET: Marketing
        public ActionResult UrlGenerator()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public PartialViewResult _GenerateUrl(UrlGeneratorViewModel model)
        {
            ShortUrlContainer oShortUrl = new ShortUrlContainer();
            ShortUrlUtils utils = new ShortUrlUtils();

            oShortUrl.Title = model.Title;
            oShortUrl.Description = model.Description;
            oShortUrl.RealUrl = model.Link;
            oShortUrl.Image = model.Image;

            
            oShortUrl.ShortenedUrl = utils.UniqueShortUrl();
            oShortUrl.CreateDate = DateTime.Now;
            oShortUrl.CreatedBy = Request.UserHostAddress;

            //utils.AddUrlToDatabase(oShortUrl);

            oShortUrl.ShortenedUrl = utils.PublicShortUrl(oShortUrl.ShortenedUrl);

            var generatedUrl = new GeneratedUrlViewModel();
            generatedUrl.Link = oShortUrl.ShortenedUrl;

            return PartialView("_GeneratedUrlResult", generatedUrl);
        }
    }
}