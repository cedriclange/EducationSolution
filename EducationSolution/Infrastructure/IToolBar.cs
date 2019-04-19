using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public interface IToolBar
    {
        IEnumerable<Button> Buttons { get; }
        int Position { get; }
    }
}
