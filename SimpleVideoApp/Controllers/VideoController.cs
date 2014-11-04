using System.Web.Mvc;
using SimpleVideoApp.Models;

namespace SimpleVideoApp.Controllers
{
    public class VideoController : Controller
    {
        public ActionResult Index(string id)
        {
            return View();
        }

        public ActionResult Post(string id)
        {
            var normalizedId = id != null ? id.Trim('/', ' ') : "";

            var model = new VideoListViewModel
            {
                Selected = normalizedId
            };

            return View(model);
        }

        public ActionResult Single()
        {
            return View(new VideoListViewModel());
        }
    }
}