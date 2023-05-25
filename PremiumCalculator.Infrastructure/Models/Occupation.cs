using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Infrastructure.Models
{
    public class Occupation
    {
        public int OccupationID { get; set; }
        public string OccupationName { get; set; }
        //Foreign Key from Rating
        public int RatingID { get; set; }

    }
}
