using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;

namespace Veritas.Web.API
{
    public class ProductTypeMasterApiController : ApiController
    {
        private readonly IGiProductTypeMasterDA giProductTypeMasterDA;

        public ProductTypeMasterApiController()
        {

        }

        public ProductTypeMasterApiController(IGiProductTypeMasterDA GiProductMaster)
        {
            giProductTypeMasterDA = GiProductMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(GiProductTypeMaster prodData)
        {
            if (prodData != null)
            {
                await giProductTypeMasterDA.AddProductTypeMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
