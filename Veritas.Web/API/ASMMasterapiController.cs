using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;

namespace Veritas.Web.API
{
    public class ASMMasterapiController : ApiController
    {
        private readonly IAsmMasterDA AsmMasterDA;

        public ASMMasterapiController()
        {

        }

        public ASMMasterapiController(IAsmMasterDA AgentTypeMaster)
        {
            AsmMasterDA = AgentTypeMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(AsmMaster prodData)
        {
            if (prodData != null)
            {
                await AsmMasterDA.AddASMMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
