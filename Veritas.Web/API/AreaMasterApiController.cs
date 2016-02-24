using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;

namespace Veritas.Web.API
{
    public class AreaMasterApiController : ApiController
    {
        private readonly IAreaMasterDA AreaMasterDA;

        public AreaMasterApiController()
        {

        }

        public AreaMasterApiController(IAreaMasterDA AreaMaster)
        {
            AreaMasterDA = AreaMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(AreaMaster prodData)
        {
            if (prodData != null)
            {
                await AreaMasterDA.AddAreaMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
