using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPaste.Models
{
    internal sealed class EditContext<T>(IEnumerable<T> existingValues, T? value = null)
        where T : class, IEditContextObject
    {
        public T? Value { get; } = value;

        public IEnumerable<T> ExistingValues { get; } = existingValues;
    }
}
