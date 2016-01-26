using System.Collections.Generic;
using System.Web.Mvc;
using Security1.Models;

namespace Security1.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<HomeModel.Review> Reviews = new List<HomeModel.Review>();

        private static void ResetReviews()
        {
            Reviews.Clear();

            Reviews.AddRange(new []
            {
                new HomeModel.Review("Bobby", "I really enjoyed this book"),
                new HomeModel.Review("Jane", "A worthy addition to my book collection")
            });
        }

        static HomeController()
        {
            ResetReviews();
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
        public ActionResult Review(string review)
        {
            if (!string.IsNullOrEmpty(review))
            {
                var newReview = HomeModel.Review.AnonymousReview(review);

                if (User.Identity.IsAuthenticated)
                {
                    newReview.SetAuthor(User.Identity.Name);
                }

                Reviews.Insert(0, newReview);
            }

            return RedirectToAction("Index");
        }


        public ActionResult Reset()
        {
            ResetReviews();

            return RedirectToAction("Index");
        }
    }
}