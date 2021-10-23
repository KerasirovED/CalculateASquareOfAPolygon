using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculateASquareOfAPolygon
{
    public partial class HandwritingForm : Form
    {
        private Polygon _polygon = new Polygon();

        public HandwritingForm() => InitializeComponent();

        private void Form2_Shown(object sender, EventArgs e) => DrawGrid();

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // After click on DrawPanel add new point into polygon class
            _polygon.AddPoint(e.Location);

            // Clear DrawPanel from old polygon
            ClearDrawPanel();

            // Draw the polygon with new point
            using (var g = DrawPanel.CreateGraphics()) _polygon.DrawPoligon(g);

            if (_polygon.CountPoints < 3) return;

            // Calcilate new square
            SquareLabel.Text = $"Square: {_polygon.Square:F} px^2";
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            ClearDrawPanel();
            using (var g = DrawPanel.CreateGraphics()) _polygon.DrawPoligon(g);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearDrawPanel();
            _polygon.ClearPoints();
            SquareLabel.Text = "Minimum three points needed";
        }

        private void DrawGrid()
        {
            var gridWidth = 50;

            using (var pen = new Pen(Color.Gray)
            {
                DashCap = System.Drawing.Drawing2D.DashCap.Round,
                DashPattern = new[] { 4F, 4F }
            })
            {
                using (var g = DrawPanel.CreateGraphics())
                {
                    // Vertical grid
                    var point1 = new PointF(gridWidth, 0);
                    var point2 = new PointF(gridWidth, DrawPanel.Height);

                    while (point1.X < DrawPanel.Width)
                    {
                        g.DrawLine(pen, point1, point2);

                        point1.X += gridWidth;
                        point2.X += gridWidth;
                    }

                    // Horizontal grid
                    point1.X = 0;
                    point2.X = DrawPanel.Width;
                    point1.Y = point2.Y = gridWidth;

                    while (point1.Y < DrawPanel.Height)
                    {
                        g.DrawLine(pen, point1, point2);

                        point1.Y += gridWidth;
                        point2.Y += gridWidth;
                    }
                }
            }
        }

        private void ClearDrawPanel()
        {
            DrawPanel.CreateGraphics().Clear(DrawPanel.BackColor);
            DrawGrid();
        }
    }
}
