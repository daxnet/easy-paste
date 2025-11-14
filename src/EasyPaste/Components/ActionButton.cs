using System.ComponentModel;

namespace EasyPaste.Components
{
    internal sealed class ActionButton : Component
    {
        private readonly List<ToolStripItem> _managedItems = [];

        private readonly EventHandler _onClick;

        public ActionButton(IEnumerable<ToolStripItem> items, EventHandler onClick)
        {
            _onClick = onClick ?? throw new ArgumentNullException(nameof(onClick));
            foreach (var item in items)
            {
                Attach(item);
            }

            Enabled = true;
        }

        public void Attach(ToolStripItem item)
        {
            ArgumentNullException.ThrowIfNull(item);

            item.Click += _onClick;
            _managedItems.Add(item);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Enabled
        {
            get => _managedItems.Count > 0 && _managedItems[0].Enabled;
            set
            {
                foreach (var item in _managedItems)
                {
                    item.Enabled = value;
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                foreach (var item in _managedItems)
                {
                    item.Click -= _onClick;
                }
                _managedItems.Clear();
            }

            base.Dispose(disposing);
        }
    }
}
