using NUnit.Framework;

namespace Pendulum
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void GraphGraphicsEquals()
        {
            System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel();
            System.Drawing.Graphics graphics = panel.CreateGraphics();
            Graph graph = new Graph(graphics);
            Assert.AreEqual(graphics, graph.GetGraphics());
        }

        [Test]
        public void GraphDrawEmpty()
        {
            System.Windows.Forms.Panel panel = new System.Windows.Forms.Panel();
            System.Drawing.Graphics graphics = panel.CreateGraphics();
            Graph graph = new Graph(graphics);
            graph.Draw();
        }

        [Test]
        public void RuleFlipWorking()
        {
            RulesFlip rulesFlip = new RulesFlip();
            rulesFlip.Start();
            Assert.IsTrue(rulesFlip.GetCoordY().Count != 0);
        }

        [Test]
        public void RuleStabilizationWorking()
        {
            RulesFlip rulesFlip = new RulesFlip();
            rulesFlip.Start();

            RulesStabilization rulesStabilization = new RulesStabilization(rulesFlip.GetAngle(), rulesFlip.GetAngleIncrease());
            rulesStabilization.Start();
            Assert.IsTrue(rulesStabilization.GetCoordY().Count != 0);
        }
    }
}
