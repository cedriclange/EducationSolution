using Barebone.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barebone.ViewModels.Shared
{
    public class MenuViewModel
    {
        public IEnumerable<MenuItemViewModel> MenuItems { get; set; }
    }
}
