using System.Drawing;

namespace Blocos
{
    internal static class Screen
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static Size Size
        {
            get { return new Size(Width, Height); }
            set { Width = value.Width; Height = value.Height; }
        }
    }
}