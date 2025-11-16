using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPaste.Models
{
    internal static class Utils
    {
        public static Image GetColorImage(Color color)
        {
            var bitmap = new Bitmap(16, 16);
            using (var g = Graphics.FromImage(bitmap))
            {
                using var brush = new SolidBrush(color);
                g.FillRectangle(brush, 0, 0, bitmap.Width, bitmap.Height);
            }

            return bitmap;
        }

        public static IEnumerable<Color> GetKnownColorsWithoutSystemColors()
        {
            var knownColorValues = Enum.GetValues<KnownColor>();
            foreach (KnownColor colorValue in knownColorValues)
            {
                var color = Color.FromKnownColor(colorValue);
                if (color.IsSystemColor)
                {
                    continue;
                }

                yield return color;
            }
        }

        public static IEnumerable<(string, Image)> EnumerateKnownColorImages()
        {
            foreach (var color in GetKnownColorsWithoutSystemColors())
            {
                var bitmap = GetColorImage(color);
                yield return (color.Name, bitmap);
            }
        }
    }
}
