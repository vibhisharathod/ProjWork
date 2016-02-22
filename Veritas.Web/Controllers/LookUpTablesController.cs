using System.Web.Mvc;
using Veritas.DataAccess;
using System.Linq;

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
        public JsonResult Agency()
        {
            return Json(lookUpsDA.GetAgencyLookUp(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult SE()
        {
            return Json(lookUpsDA.GetSELookUp(), JsonRequestBehavior.AllowGet);
        }
    }
}