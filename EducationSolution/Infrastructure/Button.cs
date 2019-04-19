using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class Button
    {
        public string Name { get; }
        public int Position { get; }

        public Button(string name, int position)
        {
            this.Name = name;
            this.Position = position;
        }
    }
}
