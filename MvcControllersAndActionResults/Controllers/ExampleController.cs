using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcControllersAndActionResults.Models;
using System.IO;
using MvcControllersAndActionResults.Infrastructure;
using System.Xml.Linq;

namespace MvcControllersAndActionResults.Controllers
{
    public class ExampleController : Controller
    {
        public /*ContentResult*/ object Index()
        {
            string message = "This is a plain text";

            return message;

            //System.Net.Mime.MediaTypeNames.Application.Soap
            //return Content(message);// "text/plain", Encoding.Default);
        }

        //public ContentResult XMLData()
        //{
        //    StoryLink[] stories = GetAllStories();
        //    XElement data = new XElement("StoryList", stories.Select(e =>
        //    {
        //        return new XElement("Story",
        //            new XAttribute("title", e.Title),
        //            new XAttribute("description", e.Description),
        //            new XAttribute("link", e.Url));
        //    }));
        //    return Content(data.ToString(), "text/xml");
        //}

        [HttpPost] // Dla Json tylko POST
        public JsonResult JsonData()
        {
            StoryLink[] stories = GetAllStories();
            return Json(stories);
        }

        private StoryLink[] GetAllStories()
        {
            return new StoryLink[]
            {
                new StoryLink() { Description = "ddd", Title = "a", Url="xxcskj"},
                new StoryLink() { Description = "eee", Title = "b", Url="gfdd"},
            };
        }

        public FileResult AnnualReport()
        {
            string filename = @"c:\AnnualReport.pdf";
            string contentType = "application/pdf";
            string downloadName = "AnnualReport2011.pdf";

            return File(filename, contentType, downloadName);
        }

        public FileContentResult DownloadReport() 
        {
            byte[] data = null; // Generate or fetch the file contents somehow
            return File(data, "application/pdf", "AnnualReport.pdf");
        }

        //public FileStreamResult DownloadReport()
        //{
        //    Stream stream = null; // open some kind of stream...
        //    return File(stream, "text/html");
        //}

        public RssActionResult RSS()
        {
            StoryLink[] stories = GetAllStories();
            return new RssActionResult<StoryLink>("My Stories", stories, e =>
            {
                return new XElement("item",
                    new XAttribute("title", e.Title),
                    new XAttribute("description", e.Description),
                    new XAttribute("link", e.Url));
            });
        }
    }
}
