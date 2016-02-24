using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;

namespace Veritas.Web.API
{
    public class GiAgencyMasterApiController : ApiController
    {
        // GET: GiAgencyMasterApiController
        private readonly IGiAgencyMasterDA GiAgencyMasterDA;

        public GiAgencyMasterApiController()
        {

        }

        public GiAgencyMasterApiController(IGiAgencyMasterDA AgentTypeMaster)
        {
            GiAgencyMasterDA = AgentTypeMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(GiAgencyMaster prodData)
        {
            if (prodData != null)
            {
                await GiAgencyMasterDA.AddGiAgencyMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
