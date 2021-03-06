using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Veritas.DataAccess;
using Veritas.DataAccess.Sql;
using System;

namespace Veritas.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<ISeMasterDA, SeMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<ITmMasterDA, TmMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IClientMasterDA, ClientMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IInsureMasterDA, InsureMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IProductMasterDA, GiProductMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IGiProductTypeMasterDA, GiProductTypeMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<ICompanyMasterDA, CompanyMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IGiAgencyMasterDA, GiAgencyMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IAreaMasterDA, AreaMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<ICityMasterDA, CityMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IStateMasterDA, StateMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<ICountryMasterDA, CountryMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IDivisionMasterDA, DivisionMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IAgentTypeMasterDA, AgentTypeMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<ILookUpTables, LookUpTables>((new HierarchicalLifetimeManager()));
            container.RegisterType<IBranchMasterDA, BranchMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IAsmMasterDA, AsmMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IMainAgentMasterDA, MainAgentMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<ISubAgentMasterDA, SubAgentMasterDA>((new HierarchicalLifetimeManager()));
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        #region Unity Container

        private static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        ///     Registers the types.
        /// </summary>
        /// <param name="container">The container.</param>
        private static void RegisterTypes(UnityContainer container)
        {
            container.RegisterType<ISeMasterDA, SeMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<ITmMasterDA, TmMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IClientMasterDA, ClientMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IInsureMasterDA, InsureMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IProductMasterDA, GiProductMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IGiAgencyMasterDA, GiAgencyMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IGiProductTypeMasterDA, GiProductTypeMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<ICompanyMasterDA, CompanyMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IAreaMasterDA, AreaMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<ICityMasterDA, CityMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IStateMasterDA, StateMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<ICountryMasterDA, CountryMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IDivisionMasterDA, DivisionMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IAgentTypeMasterDA, AgentTypeMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<ILookUpTables, LookUpTables>((new HierarchicalLifetimeManager()));
            container.RegisterType<IBranchMasterDA, BranchMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IAsmMasterDA, AsmMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<IMainAgentMasterDA, MainAgentMasterDA>((new HierarchicalLifetimeManager()));
            container.RegisterType<ISubAgentMasterDA, SubAgentMasterDA>((new HierarchicalLifetimeManager()));
        }

        /// <summary>
        ///     Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return Container.Value;
        }

        #endregion
    }
}