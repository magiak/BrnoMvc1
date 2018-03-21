using BrnoMvc1.Business.Services;
using BrnoMvc1.Web.Models;
using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrnoMvc1.Web.App_Start
{
    public class DefaultNinjectModule : NinjectModule
    {
        public override void Load()
        {
            if (HttpContext.Current.IsDebuggingEnabled)
            {
                this.Bind<IEmailService>().To<Business.Services.EmptyEmailService>();
            }
            else
            {
                this.Bind<IEmailService>().To<Business.Services.EmailService>();
            }

            this.Bind<IMovieService>().To<MovieService>();
            this.Bind<ApplicationDbContext>().ToSelf().InRequestScope();

        }
    }
}