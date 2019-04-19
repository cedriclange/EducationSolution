using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public interface IMenu
    {
        IEnumerable<MenuItem> MenuItems { get; }
    }
}
