using EasyPaste.Models;

namespace EasyPaste.Components
{
    public partial class ColorSelector : ComboBox
    {
        public ColorSelector()
        {
            InitializeComponent();

            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;

            // Populate the ComboBox with colors
            foreach (var color in Utils.GetKnownColorsWithoutSystemColors().Except([Color.Transparent]))
            {
                Items.Add(color);
            }
        }

        // Property to get the selected color instance
        public Color SelectedObject
        {
            get
            {
                if (SelectedItem != null)
                {
                    return (Color)SelectedItem;
                }

                return Color.Empty;
            }
        }

        // Override OnDrawItem to customize item rendering
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            if (e.Index < 0 || e.Index >= Items.Count)
                return;

            // Get the KnownColor for the current item
            if (Items[e.Index] is Color color)
            {
                // Draw the background
                e.DrawBackground();

                // Calculate the position to center the color swatch
                var swatchSize = 16;
                var swatchX = e.Bounds.Left + 2;
                var swatchY = e.Bounds.Top + (e.Bounds.Height - swatchSize) / 2;

                // Draw the color swatch (16x16 rectangle)
                using (var brush = new SolidBrush(color))
                {
                    e.Graphics.FillRectangle(brush, swatchX, swatchY, swatchSize, swatchSize);
                    e.Graphics.DrawRectangle(Pens.Black, swatchX, swatchY, swatchSize, swatchSize);
                }

                // Draw the color name
                using (var textBrush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(color.Name, e.Font, textBrush, swatchX + swatchSize + 6, e.Bounds.Top + (e.Bounds.Height - e.Font.Height) / 2);
                }

                e.DrawFocusRectangle();
            }
        }

        // Override OnSelectedIndexChanged to update SelectedText
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);

            if (SelectedItem != null)
            {
                SelectedText = SelectedItem.ToString();
            }
        }
    }
}
