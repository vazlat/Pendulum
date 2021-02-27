using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendulum
{
    public partial class Form1 : Form
    {
        Graph m_graphFlip;
        Graph m_graphStabilization;

        public Form1()
        {
            InitializeComponent();

            m_graphFlip = new Graph(panelFlip.CreateGraphics());
            m_graphFlip.GraphicsCenter = new Point(panelFlip.Width / 2, panelFlip.Height / 2);
            m_graphFlip.ZeroPointPosition = ZeroPointPosition.left;
            m_graphFlip.StepXSize = 60;
            m_graphFlip.StepY = 15;
            m_graphFlip.StepYSize = 15;

            m_graphStabilization = new Graph(panelStabilization.CreateGraphics());
            m_graphStabilization.GraphicsCenter = new Point(panelStabilization.Width / 2, panelStabilization.Height / 2);
            m_graphStabilization.ZeroPointPosition = ZeroPointPosition.left;
            m_graphStabilization.StepXSize = 30;
            m_graphStabilization.StepY = 0.5f;
            m_graphStabilization.StepYSize = 20;

            comboBoxFlipZerPoint.SelectedIndex = 1;
            comboBoxStabilizationZerPoint.SelectedIndex = 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RulesFlip rulesFlip = new RulesFlip();
            Start(rulesFlip, rTxtFlip);
            m_graphFlip.SetPoints(CoordYToPointF(rulesFlip.GetCoordY()));

            RulesStabilization rulesStabilization = new RulesStabilization(rulesFlip.GetAngle(), rulesFlip.GetAngleIncrease());
            Start(rulesStabilization, rTxtStabilization);
            m_graphStabilization.SetPoints(CoordYToPointF(rulesStabilization.GetCoordY()));

            m_graphFlip.Draw();
            m_graphStabilization.Draw();
        }

        private void Start(RulesBase rulesBase, RichTextBox rTxtOutput)
        {
            rulesBase.Start();
            foreach (double y in rulesBase.GetCoordY())
            {
                rTxtOutput.Text += "y = " + y + ";| ";
            }

            rTxtTest.Clear();
            rTxtTest.Text += rulesBase.GetOutTest();
        }

        private List<PointF> CoordYToPointF(List<double> coordsY)
        {
            List<PointF> points = new List<PointF>();

            for (int i = 0; i < coordsY.Count; ++i)
            {
                points.Add(new PointF(i, (float)coordsY[i]));
            }

            return points;
        }

        private void comboBoxFlipZerPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_graphFlip.ZeroPointPosition = (ZeroPointPosition)comboBoxFlipZerPoint.SelectedIndex;
            m_graphFlip.Draw();
        }

        private void comboBoxStabilizationZerPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_graphStabilization.ZeroPointPosition = (ZeroPointPosition)comboBoxStabilizationZerPoint.SelectedIndex;
            m_graphStabilization.Draw();
        }

        private void checkBoxFlipPoints_CheckedChanged(object sender, EventArgs e)
        {
            m_graphFlip.IsPoints = checkBoxFlipPoints.Checked;
            m_graphFlip.Draw();
        }

        private void checkBoxFlipSplain_CheckedChanged(object sender, EventArgs e)
        {
            m_graphFlip.IsConnectingSpline = checkBoxFlipSplain.Checked;
            m_graphFlip.Draw();
        }

        private void checkBoxFlipLines_CheckedChanged(object sender, EventArgs e)
        {
            m_graphFlip.IsConnectingLines = checkBoxFlipLines.Checked;
            m_graphFlip.Draw();
        }

        private void checkBoxStabilizationPoints_CheckedChanged(object sender, EventArgs e)
        {
            m_graphStabilization.IsPoints = checkBoxStabilizationPoints.Checked;
            m_graphStabilization.Draw();
        }

        private void checkBoxStabilizationSplain_CheckedChanged(object sender, EventArgs e)
        {
            m_graphStabilization.IsConnectingSpline = checkBoxStabilizationSplain.Checked;
            m_graphStabilization.Draw();
        }

        private void checkBoxStabilizationLines_CheckedChanged(object sender, EventArgs e)
        {
            m_graphStabilization.IsConnectingLines = checkBoxStabilizationLines.Checked;
            m_graphStabilization.Draw();
        }
    }
}
