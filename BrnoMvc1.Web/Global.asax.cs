using BrnoMvc1.Web.App_Start;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BrnoMvc1.Web.Mapper;

namespace BrnoMvc1.Web
{
    public class MvcApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapper.Mapper.Initialize(cfg => cfg.AddProfile(new MovieProfile()));
        }

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            //kernel.Load(new DefaultNinjectModule());
            // kernel.Load(new INinjectModule[] { new DefaultNinjectModule() });
            return kernel;
        }
    }
}
