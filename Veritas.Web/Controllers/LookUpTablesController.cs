using System.Web.Mvc;
using Veritas.DataAccess;
using System.Linq;
using System.Threading.Tasks;

namespace Veritas.Web.Controllers
{
    public class LookUpTablesController : Controller
    {
        private readonly ILookUpTables lookUpsDA;

        public LookUpTablesController(ILookUpTables lookUp)
        {
            lookUpsDA = lookUp;
        }
        
        public JsonResult PolicyStatus()
        {
            return Json(lookUpsDA.GetPolicyStatus(), JsonRequestBehavior.AllowGet);
        }
        
        public JsonResult BusinessStatus()
        {
            return Json(lookUpsDA.GetBusinessStatus(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ProductSubTypes()
        {
            return Json(lookUpsDA.GetProductSubTypes(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult PaymentTypes()
        {
            return Json(lookUpsDA.GetPaymentTypes(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ClaimProcessTypes()
        {
            return Json(lookUpsDA.ClaimProcessTypes(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Client()
        {
            return Json(lookUpsDA.GetClientLookUp(), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> Companies()
        {
            return Json( await lookUpsDA.GetCompanyLookUp(), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> ProductType()
        {
            return Json(await lookUpsDA.GetTypeLookUp(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Vertical()
        {
            return Json(lookUpsDA.GetVerticalTypes(), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> Area()
        {
            return Json(await lookUpsDA.GetAreaLookUp(), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> City()
        {
            return Json(await lookUpsDA.GetCityLookUp(), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> State()
        {
            return Json(await lookUpsDA.GetStateLookUp(), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> Country()
        {
            return Json(await lookUpsDA.GetCountryLookUp(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ACTypes()
        {
            return Json(lookUpsDA.GetACTypes(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult BranchTypes()
        {
            return Json(lookUpsDA.GetBranchTypes(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult ASMTypes()
        {
            return Json(lookUpsDA.GetASMTypes(), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> SE()
        {
            return Json(await lookUpsDA.GetSELookUp(), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> Branch()
        {
            return Json(await lookUpsDA.GetBranchLookUp(), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> ASM()
        {
            return Json(await lookUpsDA.GetASMLookUp(), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> TM()
        {
            return Json(await lookUpsDA.GetTMLookUp(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Gender()
        {
            return Json(lookUpsDA.GetGenderTypes(), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> Division()
        {
            return Json(await lookUpsDA.GetDivisionLookUp(), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> AgentType()
        {
            return Json(await lookUpsDA.GetAgentTypeLookUp(), JsonRequestBehavior.AllowGet);
        }
        public async Task<JsonResult> MA()
        {
            return Json(await lookUpsDA.GetMALookUp(), JsonRequestBehavior.AllowGet);
        }
    }
}