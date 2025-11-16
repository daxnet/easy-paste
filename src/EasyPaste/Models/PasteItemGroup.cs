using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPaste.Models
{
    internal class PasteItemGroup(Guid id, string name, string colorName) : IEditContextObject
    {
        public static readonly Guid DefaultGroupId = new("28DD42EC-5CCF-42C9-AE85-926D80C0293F");
        public const string DefaultGroupName = "(Default)";
        public const string DefaultGroupColorName = "Black";

        public Guid Id { get; set; } = id;

        public string ColorName { get; set; } = colorName;

        public string Name { get; set; } = name;

        public bool IsDefaultGroup => Id == DefaultGroupId;

        public override string ToString() => Name;
    }
}
