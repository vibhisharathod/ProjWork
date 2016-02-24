using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;


namespace Veritas.Web.API
{
    public class CityMasterApiController : ApiController
    {
        private readonly ICityMasterDA CityMasterDA;

        public CityMasterApiController()
        {

        }

        public CityMasterApiController(ICityMasterDA CityMaster)
        {
            CityMasterDA = CityMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(CityMaster prodData)
        {
            if (prodData != null)
            {
                await CityMasterDA.AddCityMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
