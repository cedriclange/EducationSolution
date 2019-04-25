using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Core
{
    public class ExtensionMetadata : IExtensionMetadata
    {
        public IEnumerable<StyleSheet> StyleSheets => new StyleSheet[] { };

        public IEnumerable<Script> Scripts => new Script[] { };

        public IEnumerable<MenuItem> MenuItems
        {
            get
            {
                return new MenuItem[]
                {
                    new MenuItem("/core", "Configuration", 100)
                };

            }
        }
    }
}
