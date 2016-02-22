using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;

namespace Veritas.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IInsureMasterDA, InsureMasterDA>();
            container.RegisterType<IProductMasterDA, GiProductMasterDA>();
            container.RegisterType<ILookUpTables, LookUpTables>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}