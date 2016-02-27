using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;


namespace Veritas.Web.API
{
    public class TMMasterApiController : ApiController
    {
        private readonly ITmMasterDA TMMasterDA;

        public TMMasterApiController()
        {

        }

        public TMMasterApiController(ITmMasterDA TMMaster)
        {
            TMMasterDA = TMMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(TmMaster prodData)
        {
            if (prodData != null)
            {
                await TMMasterDA.AddTMMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
