using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;

namespace Veritas.Web.API
{
    public class SEMasterApiController : ApiController
    {
        private readonly ISeMasterDA SEMasterDA;

        public SEMasterApiController()
        {

        }

        public SEMasterApiController(ISeMasterDA SEMaster)
        {
            SEMasterDA = SEMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(SeMaster prodData)
        {
            if (prodData != null)
            {
                await SEMasterDA.AddSEMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
