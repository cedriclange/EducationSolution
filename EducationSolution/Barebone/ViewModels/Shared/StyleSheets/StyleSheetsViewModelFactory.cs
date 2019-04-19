using ExtCore.Infrastructure;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barebone.ViewModels.Shared
{
    public class StyleSheetsViewModelFactory
    {
        public StyleSheetsViewModel Create()
        {
            List<StyleSheet> styleSheets = new List<StyleSheet>();

            foreach (IExtensionMetadata extensionMetadata in ExtensionManager.GetInstances<IExtensionMetadata>())
                styleSheets.AddRange(extensionMetadata.StyleSheets);

            return new StyleSheetsViewModel()
            {
                StyleSheets = styleSheets.OrderBy(ss => ss.Position).Select(
                ss => new StyleSheetViewModelFactory().Create(ss)
              )
            };
        }
    }
}
