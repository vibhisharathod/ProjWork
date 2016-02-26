using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;

namespace Veritas.Web.API
{
    public class ClientMasterApiController : ApiController
    {
        private readonly IClientMasterDA ClientMasterDA;

        public ClientMasterApiController()
        {

        }

        public ClientMasterApiController(IClientMasterDA ClientMaster)
        {
            ClientMasterDA = ClientMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(InClientleMaster prodData)
        {
            if (prodData != null)
            {
                await ClientMasterDA.AddClientMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
