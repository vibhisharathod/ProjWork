using System;
using System.Net;
using System.Net.Http;
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

        [HttpPost]
        public async Task<IHttpActionResult> Edit(BranchMaster prodData)
        {
            if (prodData != null)
            {
                await BranchDA.EditBranchMaster(prodData);
               
                return Ok("ok");
            }
            return BadRequest("Request cannot be NULL");
        }
        [HttpPost]
        public async Task<IHttpActionResult> Delete(BranchMaster prodData)
        {
            if (prodData != null)
            {
                await BranchDA.DeleteBranchMaster(prodData);
                return Ok("Index");
            }
            return BadRequest("Request cannot be NULL");


        }
    }
}
