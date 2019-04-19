using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public interface IExtensionMetadata
    {
        IEnumerable<StyleSheet> StyleSheets { get; }
        IEnumerable<Script> Scripts { get; }
        IEnumerable<MenuItem> MenuItems { get; }
    }
}
