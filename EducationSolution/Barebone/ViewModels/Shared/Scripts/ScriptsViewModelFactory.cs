using ExtCore.Infrastructure;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barebone.ViewModels.Shared
{
    public class ScriptsViewModelFactory
    {
        public ScriptsViewModel Create()
        {
            List<Script> scripts = new List<Script>();

            foreach (IExtensionMetadata extensionMetadata in ExtensionManager.GetInstances<IExtensionMetadata>())
                scripts.AddRange(extensionMetadata.Scripts);

            return new ScriptsViewModel()
            {
                Scripts = scripts.OrderBy(s => s.Position).Select(
                s => new ScriptViewModelFactory().Create(s)
              )
            };
        }
    }
}
