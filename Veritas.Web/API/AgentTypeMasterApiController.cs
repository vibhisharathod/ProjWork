using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;

namespace Veritas.Web.API
{
    public class AgentTypeMasterApiController : ApiController
    {
        // GET: CountryMasterApi
        private readonly IAgentTypeMasterDA AgentTypeMasterDA;

        public AgentTypeMasterApiController()
        {

        }

        public AgentTypeMasterApiController(IAgentTypeMasterDA AgentTypeMaster)
        {
            AgentTypeMasterDA = AgentTypeMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(AgentTypeMaster prodData)
        {
            if (prodData != null)
            {
                await AgentTypeMasterDA.AddAgentTypeMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
