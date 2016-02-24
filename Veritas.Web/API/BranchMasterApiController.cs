using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;


namespace Veritas.Web.API
{
    public class BranchMasterApiController : ApiController
    {
        private readonly IBranchMasterDA BranchDA;

        public BranchMasterApiController()
        {

        }

        public BranchMasterApiController(IBranchMasterDA BranchMaster)
        {
            BranchDA = BranchMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(BranchMaster prodData)
        {
            if (prodData != null)
            {
                await BranchDA.AddBranchMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
