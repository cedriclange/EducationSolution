using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barebone.ViewModels.Shared
{
    public class MenuItemViewModelFactory
    {
        public MenuItemViewModel Create(MenuItem menuItem)
        {
            return new MenuItemViewModel()
            {
                Url = menuItem.Url,
                Name = menuItem.Name
            };
        }
    }
}
