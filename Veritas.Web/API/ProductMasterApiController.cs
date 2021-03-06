﻿using System.Threading.Tasks;
using System.Web.Http;
using Veritas.DataAccess;
using Veritas.Entities;

namespace Veritas.Web.API
{
    public class ProductMasterApiController : ApiController
    {   
        private readonly IProductMasterDA giProductMasterDA;

        public ProductMasterApiController()
        {

        }

        public ProductMasterApiController(IProductMasterDA GiProductMaster)
        {
            giProductMasterDA = GiProductMaster;
        }

        [HttpGet]
        public string GiveMessage()
        {
            return "Me";
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create(GiProductMaster prodData)
        {
            if (prodData != null)
            {
                await giProductMasterDA.AddProductMaster(prodData);
                return Ok();
            }
            return BadRequest("Request cannot be NULL");
        }
    }
}
