using MyEcommerce.Domain.Abstract;
using MyEcommerce.Domain.Concrete;
using Ninject;
using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Linq;
using System.Collections.Generic;
using System.Configuration;

namespace MyEcommerceSite.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernal;
        public NinjectControllerFactory()
        {
            ninjectKernal = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernal.Get(controllerType);
        }
        private void AddBindings()
        {
            ninjectKernal.Bind<IProductRepository>().To<EFProductRepository>();
            EmailSettings emailSettings = new EmailSettings()
            {
                WriteAsFile = bool.Parse(ConfigurationManager.AppSettings["Email.WriteAsFile"] ?? "false")
            };
            ninjectKernal.Bind<IOrderProcessor>().To<EmailOrderProcessor>()
                .WithConstructorArgument("settings", emailSettings);
        }


        
    }
}