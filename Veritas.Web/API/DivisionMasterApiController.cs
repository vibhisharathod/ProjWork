using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;


namespace Veritas.Web.API
{
    public class DivisionMasterApiController : ApiController
    {
        // GET: DivisionMasterApi
        private readonly IDivisionMasterDA DivisionMasterDA;

        public DivisionMasterApiController()
        {

        }

        public DivisionMasterApiController(IDivisionMasterDA DivisionMaster)
        {
            DivisionMasterDA = DivisionMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(DivisionMaster prodData)
        {
            if (prodData != null)
            {
                await DivisionMasterDA.AddDivisionMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
