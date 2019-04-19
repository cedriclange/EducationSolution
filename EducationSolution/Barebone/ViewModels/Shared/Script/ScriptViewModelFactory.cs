using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barebone.ViewModels.Shared
{
    public class ScriptViewModelFactory
    {
        public ScriptViewModel Create(Script script)
        {
            return new ScriptViewModel()
            {
                Url = script.Url
            };
        }
    }
}
