using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.Controllers;
using webapi;
using PremiumCalculator.Infrastructure.Models;
using PremiumCalculator.Infrastructure.Services;
using PremiumCalculator.Infrastructure.Services.Interfaces;
using PremiumCalculator.Infrastructure.Common;
using PremiumCalculator.Infrastructure.Data;

namespace PremiumCalculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PremiumController : ControllerBase
    {
        private readonly ILogger<PremiumController> _logger;

        private readonly IDeathPremiumCalculate _deathPremiumService;
        private readonly ITPDPremiumCalculate _tpdPremiumService;
        

        public PremiumController(ILogger<PremiumController> logger,
            IDeathPremiumCalculate deathPremiumCalculate,ITPDPremiumCalculate tPDPremiumCalculate)
        {
            _logger = logger;
            _deathPremiumService = deathPremiumCalculate;
            _tpdPremiumService = tPDPremiumCalculate;

        }

        [HttpPost("calculate-death-premium")]
        public float CalculateDeathPremium(InsuredPerson insuredPerson)
        {
            return  _deathPremiumService.PremiumCalculate(insuredPerson);
        }
        [HttpGet("occupations")]
        public IEnumerable<Occupation> occupations()
        {
            return DataService.Occupations();
        }
        [HttpPost("calculate-tpd-premium")]
        public double CalculateTPDPremium(InsuredPerson insuredPerson)
        {
            return  Math.Round(_tpdPremiumService.PremiumCalculate(insuredPerson),2);
        }
    }
}
