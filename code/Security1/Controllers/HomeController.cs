using System.Collections.Generic;
using System.Web.Mvc;
using Security1.Models;

namespace Security1.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<string> Reviews;

        static HomeController()
        {
            Reviews = new List<string>
            {
                "I really enjoyed this book",
                "A worthy addition to my book collection"
            };
        }

        public ActionResult Index()
        {
            var model = new HomeModel
            {
                Reviews = Reviews
            };

            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(string review)
        {
            if (!string.IsNullOrEmpty(review))
                Reviews.Insert(0, review);

            return RedirectToAction("Index");
        }


        public ActionResult Reset()
        {
            Reviews.Clear();
            return Content("ok");
        }
    }
}