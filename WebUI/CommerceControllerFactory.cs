using Domain;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using WebUI.Controllers;

namespace WebUI
{
    public class CommerceControllerFactory : DefaultControllerFactory
    {
        private readonly Dictionary<string, Func<RequestContext, IController>> controllerMap;

        public CommerceControllerFactory(ProductRepository productRepository)
        {
            if (productRepository == null)
            {
                throw new ArgumentNullException(nameof(productRepository));
            }

            this.controllerMap = new Dictionary<string, Func<RequestContext, IController>>
            {
                ["Home"] = ctx => new HomeController(productRepository)
            };
        }

        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            return this.controllerMap[controllerName](requestContext);
        }

        public override void ReleaseController(IController controller)
        {
        }
    }
}