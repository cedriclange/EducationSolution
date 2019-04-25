
using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Builder;
using System;

namespace Barebone.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(name: "Default", template: "{controller}/{action}", defaults: new {controller = "Barebone", action="Index" });
        }
    }
}
