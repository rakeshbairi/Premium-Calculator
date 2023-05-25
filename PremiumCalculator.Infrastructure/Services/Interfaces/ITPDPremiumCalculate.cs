using PremiumCalculator.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Infrastructure.Services.Interfaces
{
    public interface ITPDPremiumCalculate
    {
        public  float PremiumCalculate(InsuredPerson insuredPerson);
    }
}
