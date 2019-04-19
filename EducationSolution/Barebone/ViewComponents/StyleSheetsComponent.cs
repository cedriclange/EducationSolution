using Barebone.ViewModels.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Barebone.ViewComponents
{
    public class StyleSheetsComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return this.View(new StyleSheetsViewModelFactory().Create());
        }
    }
}
