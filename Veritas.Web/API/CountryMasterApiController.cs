using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;

namespace Veritas.Web.API
{
    public class CountryMasterApiController : ApiController
    {
        // GET: CountryMasterApi
        private readonly ICountryMasterDA CountryMasterDA;

        public CountryMasterApiController()
        {

        }

        public CountryMasterApiController(ICountryMasterDA CountryMaster)
        {
            CountryMasterDA = CountryMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(CountryMaster prodData)
        {
            if (prodData != null)
            {
                await CountryMasterDA.AddCountryMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}