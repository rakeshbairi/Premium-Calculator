using PremiumCalculator.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Infrastructure.Common
{
    public delegate ITPDPremiumCalculate ServiceResolver(PremiumType serviceType);
    public enum PremiumType
    {
        Death,
        TPD        
    }
}
