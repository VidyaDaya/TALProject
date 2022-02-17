using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularNETCoreProject.Controllers
{
    
    [ApiController]
    [Produces("application/json")]
    public class InsurancePremiumController : ControllerBase
    {
       
        //Post: api/insurancepremium
        [HttpPost]
        [Route("api/insurancepremium/calculate")]
        public double CalculateInsurancePremium([FromBody] DeathInsurerDetails deathInsurerDetails)
        {
            double factor = OccupationRating.OccupationRatingDict[deathInsurerDetails.Occupation].Factor;
            double premium = (deathInsurerDetails.DeathSumInsured * factor * deathInsurerDetails.Age) / (1000 * 12);
            return premium;
        }
    }
}
