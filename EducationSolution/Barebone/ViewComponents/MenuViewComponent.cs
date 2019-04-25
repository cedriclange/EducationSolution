using Barebone.ViewModels.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Barebone.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync()
        {
           
            return Task.FromResult<IViewComponentResult>(View (new MenuViewModelFactory().Create()));
        }
    }
}
