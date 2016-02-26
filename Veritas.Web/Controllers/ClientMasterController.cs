using System.Threading.Tasks;
using System.Web.Mvc;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web.Controllers
{
    public class ClientMasterController : Controller
    {
        // GET: ClientMaster
        private readonly IClientMasterDA ClientDA;

        public ClientMasterController(IClientMasterDA ClientMasterDA)
        {
            ClientDA = ClientMasterDA;
        }

        public async Task<ActionResult> Index()
        {
            var result = await ClientDA.GetAllInClientleMasterForViews();

            return View(result);
        }

        public async Task<ActionResult> ViewDetails(int Id)
        {
            var selectProd = await ClientDA.Find(Id);
            return View(selectProd);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}