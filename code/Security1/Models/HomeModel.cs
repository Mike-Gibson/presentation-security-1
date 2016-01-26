using System.Collections.Generic;
namespace Security1.Models
{
    public class HomeModel
    {
        public IEnumerable<Review> Reviews { get; set; }

        public class Review
        {
            public string Author { get; private set; }
            public string Text { get; private set; }

            public static Review AnonymousReview(string text)
            {
                return new Review("Anonymous", text);
            }

            public Review(string author, string text)
            {
                Author = author;
                Text = text;
            }

            public void SetAuthor(string author)
            {
                Author = author;
            }
        }
    }
}