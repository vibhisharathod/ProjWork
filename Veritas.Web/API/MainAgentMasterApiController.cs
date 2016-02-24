using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;
using Veritas.Entities;

namespace Veritas.Web.API
{
    public class MainAgentMasterApiController : ApiController
    {
        private readonly IMainAgentMasterDA MainAgentMasterDA;

        public MainAgentMasterApiController()
        {

        }

        public MainAgentMasterApiController(IMainAgentMasterDA MainAgentMaster)
        {
            MainAgentMasterDA = MainAgentMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(MainAgentMaster prodData)
        {
            if (prodData != null)
            {
                await MainAgentMasterDA.AddMainAgentMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
