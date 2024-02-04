using System.Drawing.Drawing2D;

namespace RecipeRover.Util
{
    public class RoundedPictureBox : PictureBox
    {
        public int BorderRadius { get; set; } = 10;

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            using (GraphicsPath path = CreateRoundPath(ClientRectangle, BorderRadius))
            using (Pen pen = new Pen(Color.White, 2)) // You can customize the color and thickness of the border
            {
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pe.Graphics.DrawPath(pen, path);
            }

            SetClipRegion();

        }

        private GraphicsPath CreateRoundPath(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rectangle.Location, new Size(diameter, diameter));

            // Top left corner
            path.AddArc(arc, 180, 90);

            // Top right corner
            arc.X = rectangle.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Bottom right corner
            arc.Y = rectangle.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Bottom left corner
            arc.X = rectangle.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();

            return path;
        }

        private void SetClipRegion()
        {
            using (GraphicsPath path = CreateRoundPath(ClientRectangle, BorderRadius))
            {
                Region = new Region(path);
            }
        }
    }
}
