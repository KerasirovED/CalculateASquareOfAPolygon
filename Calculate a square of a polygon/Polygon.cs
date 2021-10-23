using System;
using System.Collections.Generic;
using System.Drawing;

namespace CalculateASquareOfAPolygon
{
    public class Polygon
    {
        private List<PointF> _poligonPoints = new List<PointF>();

        /// <summary>
        /// Amount points of the polygon
        /// </summary>
        public int CountPoints
        {
            get
            {
                return _poligonPoints.Count;
            }
        }

        /// <summary>
        /// Calculate the polygon square by pixels according to Shoelace formula: 
        /// https://en.wikipedia.org/wiki/Shoelace_formula
        /// </summary>
        public double Square
        {
            get
            {
                if (_poligonPoints.Count < 3) return Double.NaN;

                var square = 0D;

                for (int i = 0; i < _poligonPoints.Count - 1; i++)
                {
                    square += _poligonPoints[i].X * _poligonPoints[i + 1].Y;
                    square -= _poligonPoints[i + 1].X * _poligonPoints[i].Y;
                }

                square += _poligonPoints[_poligonPoints.Count - 1].X * _poligonPoints[0].Y;
                square -= _poligonPoints[0].X * _poligonPoints[_poligonPoints.Count - 1].Y;

                return 0.5 * Math.Abs(square);
            }
        }

        /// <summary>
        /// Adds new point of the polygon
        /// </summary>
        /// <param name="point">New point of the polygon</param>
        public void AddPoint(PointF point) => _poligonPoints.Add(point);

        /// <summary>
        /// Clears all points of the polygon
        /// </summary>
        public void ClearPoints() => _poligonPoints.Clear();

        /// <summary>
        /// Draws the polygon in the GDI+ drawing surface
        /// </summary>
        /// <param name="graphics">Drawing surface</param>
        public void DrawPoligon(Graphics graphics)
        {
            // If no points, do not draw anything
            if (_poligonPoints.Count == 0) return;

            // If the point is the first, draw only it
            if (_poligonPoints.Count == 1)
            {
                DrawDot(_poligonPoints[0], graphics);
                return;
            }

            // Draw all points and connect them
            for (int i = 0; i < _poligonPoints.Count - 1; i++)
            {
                DrawDot(_poligonPoints[i], graphics);
                graphics.DrawLine(new Pen(Color.Black, 2), _poligonPoints[i], _poligonPoints[i + 1]);
            }

            // Draw the last point
            var lastPoligonPoint = _poligonPoints[_poligonPoints.Count - 1];
            DrawDot(lastPoligonPoint, graphics);

            // If only two points, return 
            if (_poligonPoints.Count == 2) return;

            // If points more then two connect two last points by the blue line
            graphics.DrawLine(new Pen(Color.Blue, 2), _poligonPoints[0], lastPoligonPoint);
        }

        /// <summary>
        /// Draws the point in the GDI+ drawing surface
        /// </summary>
        /// <param name="point">Drawing point</param>
        /// <param name="graphics">GDI+ drawing surface where the point has to be drawn</param>
        private void DrawDot(PointF point, Graphics graphics)
        {
            var brush = new SolidBrush(Color.Black);

            float dotSize = 8F;
            var dotPoint = new PointF(
                    point.X - dotSize / 2,
                    point.Y - dotSize / 2);

            var dotRectangle = new RectangleF(dotPoint, new SizeF(dotSize, dotSize));

            graphics.FillEllipse(brush, dotRectangle);
        }
    }
}
