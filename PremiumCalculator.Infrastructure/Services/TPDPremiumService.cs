using Microsoft.EntityFrameworkCore;
using PremiumCalculator.Infrastructure.Data;
using PremiumCalculator.Infrastructure.Models;
using PremiumCalculator.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Infrastructure.Services
{
    public class TPDPremiumService : ITPDPremiumCalculate
    {
        public float PremiumCalculate(InsuredPerson insuredPerson)
        {
            var ratingFactor =  (from o in DataService.Occupations()
                                join ocrating in DataService.OccupationRating() on o.RatingID equals ocrating.RatingID
                                where o.OccupationID == insuredPerson.OccupationID
                                select ocrating.Factor).AsQueryable().FirstOrDefault();

            return (insuredPerson.SumInsured * insuredPerson.Age * ratingFactor) / 1234;
        }
    }
}
