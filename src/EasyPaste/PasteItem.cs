using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPaste
{
    internal sealed class PasteItem
    {
        public string Name { get; set; }
        public string Content { get; set; }

        public PasteItem(string name, string content)
        {
            Name = name;
            Content = content;

        }

        public override string ToString() => Name;
    }
}
