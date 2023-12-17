using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDSystemGUI
{
    public class ArtanPanel : Panel
    {
        //fields
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;

        //Constructor
        public ArtanPanel()
        {
            BackColor = Color.White;
            ForeColor = Color.Black;
            Size = new Size(350, 200);

            //DoubleBuffered = true;

        }
        //properties
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }
        public float GradientAngle
        {
            get => gradientAngle;
            set { gradientAngle = value; Invalidate(); }
        }
        public Color GradientTopColor
        {
            get => gradientTopColor;
            set { gradientTopColor = value; Invalidate(); }
        }
        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set { gradientBottomColor = value; Invalidate(); }
        }

        //Methods

        private GraphicsPath GetArtanPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }
        /*protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // Add WS_EX_CONTROLPARENT to allow controls inside the panel to receive keyboard input
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }*/
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brushArtan = new LinearGradientBrush(ClientRectangle, GradientTopColor, gradientBottomColor, gradientAngle);
            Graphics graphicsArtan = e.Graphics;
            graphicsArtan.FillRectangle(brushArtan,
            ClientRectangle);

            //BorderRadius
            RectangleF rectangleF = new RectangleF(0, 0, Width, Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetArtanPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(Parent.BackColor, 2))
                {

                    Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }

            }
            else Region = new Region(rectangleF);
            /*
            // Draw drop shadow effect
            int shadowSize = 5; // Adjust the size of the shadow
            Color shadowColor = Color.Gray; // Adjust the color of the shadow
            Rectangle shadowRect = new Rectangle(0, 0, Width, Height);
            ControlPaint.DrawBorder(e.Graphics, shadowRect,
                                     shadowColor, shadowSize, ButtonBorderStyle.Solid,
                                     shadowColor, shadowSize, ButtonBorderStyle.Solid,
                                     shadowColor, shadowSize, ButtonBorderStyle.Solid,
                                     shadowColor, shadowSize, ButtonBorderStyle.Solid);
            */
        }
    }
}
