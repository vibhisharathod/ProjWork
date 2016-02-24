using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;


namespace Veritas.Web.API
{
    public class StateMasterApiController : ApiController
    {
        private readonly IStateMasterDA StateMasterDA;

        public StateMasterApiController()
        {

        }

        public StateMasterApiController(IStateMasterDA StateMaster)
        {
            StateMasterDA = StateMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(StateMaster prodData)
        {
            if (prodData != null)
            {
                await StateMasterDA.AddStateMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
