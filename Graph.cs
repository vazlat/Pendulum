using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Pendulum
{
    enum ZeroPointPosition { center, left, leftBottom, leftTop, right, rightBottom, rightTop, top, bottom }

    class Graph
    {
        public Graph(Graphics graphics)
        {
            m_graphics = graphics;
        }

        #region Privat variables
        List<PointF> m_points = new List<PointF>();

        Graphics m_graphics;
        PointF m_graphicsCenter = new PointF(0, 0);
        ZeroPointPosition m_zeroPointPosition = ZeroPointPosition.center;
        float m_stepX = 1;
        float m_stepXSize = 10;
        float m_stepY = 10;
        float m_stepYSize = 10;

        bool m_isSegmentation = true;
        bool m_isNumeration = true;
        bool m_isPoints = true;
        bool m_isConnectingLines = true;
        bool m_isConnectingSpline = true;

        float m_positiveXLen = 0;
        float m_positiveYLen = 0;
        float m_negativeXLen = 0;
        float m_negativeYLen = 0;
        float m_margin = 20;
        #endregion Privat variables

        #region Properties get/set
        public PointF GraphicsCenter { get => m_graphicsCenter; set => m_graphicsCenter = value; }
        public ZeroPointPosition ZeroPointPosition { get => m_zeroPointPosition; set => m_zeroPointPosition = value; }
        public float StepX { get => m_stepX; set => m_stepX = value; }
        public float StepXSize { get => m_stepXSize; set => m_stepXSize = value; }
        public float StepY { get => m_stepY; set => m_stepY = value; }
        public float StepYSize { get => m_stepYSize; set => m_stepYSize = value; }

        public bool IsSegmentation { get => m_isSegmentation; set => m_isSegmentation = value; }
        public bool IsNumeration { get => m_isNumeration; set => m_isNumeration = value; }
        public bool IsPoints { get => m_isPoints; set => m_isPoints = value; }
        public bool IsConnectingLines { get => m_isConnectingLines; set => m_isConnectingLines = value; }
        public bool IsConnectingSpline { get => m_isConnectingSpline; set => m_isConnectingSpline = value; }
        #endregion Properties get/set

        #region Fields get/set 
        public Graphics GetGraphics()
        {
            return m_graphics;
        }
        public void SetGraphics(Graphics graphics)
        {
            m_graphics = graphics;
        }

        public void SetPoints(List<PointF> points)
        {
            m_points = points;
        }

        public void AddPoint(PointF point)
        {
            m_points.Add(point);
        }
        #endregion Fields get/set         

        public void Draw()
        {
            if (m_points.Count == 0) return;
            m_graphics.Clear(Color.White);
            SetZeroPointPosition();
            DrawDecoration();
            DrawGraph();
        }

        private void SetZeroPointPosition()
        {
            float offsetX = m_margin, offsetY = m_margin;
            m_positiveXLen = m_margin;
            m_positiveYLen = m_margin;
            m_negativeXLen = m_margin;
            m_negativeYLen = m_margin;

            switch (m_zeroPointPosition)
            {
                case ZeroPointPosition.center:
                    offsetX = GraphicsCenter.X;
                    offsetY = GraphicsCenter.Y;
                    m_positiveXLen = m_negativeXLen = GraphicsCenter.X;
                    m_positiveYLen = m_negativeYLen = GraphicsCenter.Y;
                    break;
                case ZeroPointPosition.left:
                    offsetY = GraphicsCenter.Y;
                    m_positiveXLen = -m_margin + GraphicsCenter.X * 2;
                    m_positiveYLen = m_negativeYLen = GraphicsCenter.Y;
                    break;
                case ZeroPointPosition.leftBottom:
                    offsetY = -m_margin + GraphicsCenter.Y * 2;
                    m_positiveXLen = -m_margin + GraphicsCenter.X * 2;
                    m_positiveYLen = -m_margin + GraphicsCenter.Y * 2;
                    break;
                case ZeroPointPosition.leftTop:
                    m_positiveXLen = -m_margin + GraphicsCenter.X * 2;
                    m_negativeYLen = -m_margin + GraphicsCenter.Y * 2;
                    break;
                case ZeroPointPosition.right:
                    offsetX = -m_margin + GraphicsCenter.X * 2;
                    offsetY = GraphicsCenter.Y;
                    m_negativeXLen = -m_margin + GraphicsCenter.X * 2;
                    m_positiveYLen = m_negativeYLen = GraphicsCenter.Y;
                    break;
                case ZeroPointPosition.rightBottom:
                    offsetX = -m_margin + GraphicsCenter.X * 2;
                    offsetY = -m_margin + GraphicsCenter.Y * 2;
                    m_negativeXLen = -m_margin + GraphicsCenter.X * 2;
                    m_positiveYLen = -m_margin + GraphicsCenter.Y * 2;
                    break;
                case ZeroPointPosition.rightTop:
                    offsetX = -m_margin + GraphicsCenter.X * 2;
                    m_negativeXLen = -m_margin + GraphicsCenter.X * 2;
                    m_negativeYLen = -m_margin + GraphicsCenter.Y * 2;
                    break;
                case ZeroPointPosition.top:
                    offsetX = GraphicsCenter.X;
                    m_positiveXLen = m_negativeXLen = GraphicsCenter.X;
                    m_negativeYLen = GraphicsCenter.Y * 2;
                    break;
                case ZeroPointPosition.bottom:
                    offsetX = GraphicsCenter.X;
                    offsetY = -m_margin + GraphicsCenter.Y * 2;
                    m_positiveXLen = m_negativeXLen = GraphicsCenter.X;
                    m_positiveYLen = -m_margin + GraphicsCenter.Y * 2;
                    break;
            }

            m_graphics.Transform = new System.Drawing.Drawing2D.Matrix(1, 0, 0, 1, offsetX, offsetY);
            m_graphics.ScaleTransform(1, -1);
        }

        #region Оформление (Оси, деления, нумерация)
        private void DrawDecoration()
        {
            DrawAxis();
            if (m_isSegmentation) DrawSegmentation();
            if (m_isNumeration) DrawNumeration();
        }

        private void DrawAxis()
        {
            Pen pen = new Pen(Color.Black);
            m_graphics.DrawLine(pen, -m_negativeXLen, 0, m_positiveXLen, 0);
            m_graphics.DrawLine(pen, 0, -m_negativeYLen, 0, m_positiveYLen);
        }

        private void DrawSegmentation()
        {
            Pen pen = new Pen(Color.Black);
            float segmentHalfHeigth = 2;

            for (int i = 0; i < (m_positiveXLen - m_margin) / m_stepX * m_stepXSize; ++i)
            {
                m_graphics.DrawLine(pen, i * m_stepXSize, segmentHalfHeigth, i * m_stepXSize, -segmentHalfHeigth);
            }

            for (int i = 0; i < (m_negativeXLen - m_margin) / m_stepX * m_stepXSize; ++i)
            {
                m_graphics.DrawLine(pen, -i * m_stepXSize, segmentHalfHeigth, -i * m_stepXSize, -segmentHalfHeigth);
            }

            for (int i = 0; i < (m_positiveYLen - m_margin) / m_stepY * m_stepYSize; ++i)
            {
                m_graphics.DrawLine(pen, segmentHalfHeigth, i * m_stepYSize, -segmentHalfHeigth, i * m_stepYSize);
            }

            for (int i = 0; i < (m_negativeYLen - m_margin) / m_stepY * m_stepYSize; ++i)
            {
                m_graphics.DrawLine(pen, segmentHalfHeigth, -i * m_stepYSize, -segmentHalfHeigth, -i * m_stepYSize);
            }
        }

        private void DrawNumeration()
        {
            m_graphics.ScaleTransform(1, -1);
            Font font = new Font(FontFamily.GenericSansSerif, 8);

            SolidBrush brush = new SolidBrush(Color.Black);

            for (int i = 1; i < (m_positiveXLen - m_margin) / m_stepX * m_stepXSize; ++i)
            {
                m_graphics.DrawString((i * m_stepX).ToString(), font, brush, i * m_stepXSize, 0);
            }

            for (int i = 1; i < (m_negativeXLen - m_margin) / m_stepX * m_stepXSize; ++i)
            {
                m_graphics.DrawString((-i * m_stepX).ToString(), font, brush, -i * m_stepXSize, 0);
            }

            for (int i = 1; i < (m_positiveYLen - m_margin) / m_stepY * m_stepYSize; ++i)
            {
                m_graphics.DrawString((i * m_stepY).ToString(), font, brush, -30, -i * m_stepYSize);
            }

            for (int i = 1; i < (m_negativeYLen - m_margin) / m_stepY * m_stepYSize; ++i)
            {
                m_graphics.DrawString((-i * m_stepY).ToString(), font, brush, -30, i * m_stepYSize);
            }
            m_graphics.ScaleTransform(1, -1);
        }
        #endregion Оформление (Оси, деления, нумерация)

        #region График (Точки, соединительные линии)
        private void DrawGraph()
        {
            PointF[] points = m_points.ToArray();
            points = points.Select(x => new PointF(x.X / StepX * StepXSize, x.Y / StepY * StepYSize)).ToArray();


            if (m_isConnectingLines) DrawConnectingLines(points);
            DrawPoints(points);
        }

        private void DrawPoints(PointF[] points)
        {
            float pointSize = 7;
            SolidBrush brush = new SolidBrush(Color.Black);
            foreach (PointF point in points)
            {
                m_graphics.FillEllipse(brush, point.X - pointSize / 2, point.Y - pointSize / 2, pointSize, pointSize);
            }
        }

        private void DrawConnectingLines(PointF[] points)
        {
            Pen pen = new Pen(Color.Gray);
            pen.Width = 2;
            m_graphics.DrawLines(pen, points);
            m_graphics.DrawCurve(pen, points);
        }
        #endregion График (Точки, соединительные линии)
    }

}
