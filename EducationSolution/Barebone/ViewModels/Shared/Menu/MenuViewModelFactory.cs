using Barebone.ViewModels.Shared;
using ExtCore.Infrastructure;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barebone.ViewModels.Shared
{
    public class MenuViewModelFactory
    {
        public MenuViewModel Create()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (IExtensionMetadata extensionMetadata in ExtensionManager.GetInstances<IExtensionMetadata>())
                menuItems.AddRange(extensionMetadata.MenuItems);

            return new MenuViewModel()
            {
                MenuItems = menuItems.OrderBy(mi => mi.Position).Select(
                mi => new MenuItemViewModelFactory().Create(mi)
              )
            };
        }
    }
}
