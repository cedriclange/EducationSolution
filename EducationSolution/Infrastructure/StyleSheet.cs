using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class StyleSheet
    {
        public string Url { get; set; }
        public int Position { get; }

        public StyleSheet(string url, int position)
        {
            this.Url = url;
            this.Position = position;
        }
    }
}
