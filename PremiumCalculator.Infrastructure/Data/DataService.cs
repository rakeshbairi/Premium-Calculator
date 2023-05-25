using PremiumCalculator.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Infrastructure.Data
{
    public class DataService
    {
        public static IEnumerable<Rating> Ratings()
        {
            List<Rating> rating = new List<Rating>();
            rating.Add(new Rating() { RatingID=1, RatingName="Light Manual" });
            rating.Add(new Rating() { RatingID = 2, RatingName = "Florist" });
            rating.Add(new Rating() { RatingID = 3 ,RatingName = "White Collar" });
            rating.Add(new Rating() { RatingID = 4, RatingName = "Heavy Manual" });
            rating.Add(new Rating() { RatingID = 5, RatingName = "Professional" });
            
            return rating;
        }

        public static IEnumerable<Occupation> Occupations()
        {
            List<Occupation> occupation = new List<Occupation>();
            occupation.Add(new Occupation() { OccupationID = 1, OccupationName = "Cleaner", RatingID= 1});
            occupation.Add(new Occupation() { OccupationID = 2, OccupationName = "Doctor", RatingID = 5 });
            occupation.Add(new Occupation() { OccupationID = 3, OccupationName = "Author", RatingID = 3 });
            occupation.Add(new Occupation() { OccupationID = 4, OccupationName = "Farmer", RatingID = 4 });
            occupation.Add(new Occupation() { OccupationID = 5, OccupationName = "Mechanic", RatingID = 4 });
            occupation.Add(new Occupation() { OccupationID = 5, OccupationName = "Florist", RatingID = 1 });
            return occupation;
        }

        public static IEnumerable<OccupationRating> OccupationRating()
        {
            List<OccupationRating> occupationRatings = new List<OccupationRating>();
            occupationRatings.Add(new OccupationRating() { OccupationRatingID = 1, RatingID = 5,Factor=1.0f });
            occupationRatings.Add(new OccupationRating() { OccupationRatingID = 3, RatingID = 3, Factor =1.25f});
            occupationRatings.Add(new OccupationRating() { OccupationRatingID = 4, RatingID = 4, Factor =1.75f});
            occupationRatings.Add(new OccupationRating() { OccupationRatingID = 5, RatingID = 1, Factor =1.50f});            
            return occupationRatings;
        }
    }
}
