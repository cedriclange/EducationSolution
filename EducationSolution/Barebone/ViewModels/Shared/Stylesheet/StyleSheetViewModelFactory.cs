using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barebone.ViewModels.Shared
{
    public class StyleSheetViewModelFactory
    {
        public StyleSheetViewModel Create(StyleSheet styleSheet)
        {
            return new StyleSheetViewModel()
            {
                Url = styleSheet.Url
            };
        }
    }
}
