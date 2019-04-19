using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Barebone
{
    public class ExtensionMetadata : IExtensionMetadata
    {
        public IEnumerable<StyleSheet> StyleSheets
        {
            get
            {
                return new StyleSheet[]
                {
                    new StyleSheet("/Styles/barebone.css", 200)
                };
            }
        }
        public IEnumerable<Script> Scripts
        {
            get
            {
                return new Script[]
                {
                     new Script("https://cdnjs.cloudflare.com/ajax/libs/feather-icons/4.9.0/feather.min.js",50),
                     new Script("//ajax.aspnetcdn.com/ajax/jquery/jquery-1.11.3.min.js", 100),
                     new Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.14.0/jquery.validate.min.js", 200),
                     new Script("//ajax.aspnetcdn.com/ajax/jquery.validation.unobtrusive/3.2.6/jquery.validate.unobtrusive.min.js", 300),
                     new Script("/Scripts/barebone.js", 400)
                };
            }
        }

        public IEnumerable<MenuItem> MenuItems => new MenuItem[] { };
    }
}
