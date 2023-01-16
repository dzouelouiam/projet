using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VaderSharp;
namespace projet.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }

        public string isPositive()
        {
            SentimentIntensityAnalyzer analyzer = new SentimentIntensityAnalyzer();

            var results = analyzer.PolarityScores(Comment);

            if(results.Positive > 0 && results.Negative == 0)
            {
                return "Positive";
            }

            if(results.Negative > 0 && results.Positive == 0)
            {
                return "Negative";
            }

            return "Neutral";

        }

    }

}
