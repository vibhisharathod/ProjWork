using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;
namespace Veritas.Web.API
{
    public class GiCompanyMasterApiController : ApiController
    {
        private readonly ICompanyMasterDA CompanyDA;

        public GiCompanyMasterApiController()
        {

        }

        public GiCompanyMasterApiController(ICompanyMasterDA AgentTypeMaster)
        {
            CompanyDA = AgentTypeMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(GiCompanyMaster prodData)
        {
            if (prodData != null)
            {
                await CompanyDA.AddCompanyMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
