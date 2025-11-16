using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPaste.Models
{
    internal sealed class PasteItem(string name, string content)
    {
        public Guid Id { get; set; } = new Guid();

        public string Name { get; set; } = name;
        
        public Guid? GroupdId { get; set; }

        public string Content { get; set; } = content;

        public override string ToString() => Name;
    }
}
