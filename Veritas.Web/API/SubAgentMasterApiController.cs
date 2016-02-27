using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;

namespace Veritas.Web.API
{
    public class SubAgentMasterApiController : ApiController
    {
        private readonly ISubAgentMasterDA SubAgentDA;

        public SubAgentMasterApiController()
        {

        }

        public SubAgentMasterApiController(ISubAgentMasterDA SubAgent)
        {
            SubAgentDA = SubAgent;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(SubAgentMaster prodData)
        {
            if (prodData != null)
            {
                await SubAgentDA.AddSubAgentMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
