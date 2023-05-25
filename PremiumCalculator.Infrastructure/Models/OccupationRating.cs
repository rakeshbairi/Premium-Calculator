using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Infrastructure.Models
{
    public class OccupationRating
    {
        public int OccupationRatingID { get; set; }
        public float Factor { get; set; }

        //Foreign Key from Rating
        public int RatingID { get; set; }


    }
}
