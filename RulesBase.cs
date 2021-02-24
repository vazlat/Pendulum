using System;
using System.Collections.Generic;

namespace Pendulum
{
    abstract class RulesBase
    {
        protected struct Rule
        {
            public Rule(double min, double med, double max)
            {
                this.min = min;
                this.med = med;
                this.max = max;
            }

            public double min;
            public double med;
            public double max;

        }

        protected Rule[] m_rulesAngleValue;
        protected Rule[] m_rulesAngleIncrement;
        protected Rule[] m_rulesAngleControls;
        protected Object[,] m_rulesMatrix;

        protected List<double> m_coordY = new List<double>();
        public List<double> GetCoordY()
        {
            return m_coordY;
        }

        protected string m_outTest = "";
        public string GetOutTest()
        {
            return m_outTest;
        }

        protected double m_angle = 0;
        public double GetAngle()
        {
            return m_angle;
        }

        protected double m_angleIncrease = 0;
        public double GetAngleIncrease()
        {
            return m_angleIncrease;
        }

        abstract public void Start();

        protected void Move()
        {
            int indexAngleValue = IsRangeIndex(m_rulesAngleValue, m_angle);
            int indexAngleIncrement = IsRangeIndex(m_rulesAngleIncrement, m_angleIncrease);
            if (indexAngleValue != -1 && indexAngleIncrement != -1)
            {
                object rule = m_rulesMatrix[indexAngleValue, indexAngleIncrement];
                if (rule != null)
                {
                    MoveLogic((Rule)rule, indexAngleValue, indexAngleIncrement);
                }
            }
        }

        abstract protected void MoveLogic(Rule rule, int indexAngleValue, int indexAngleIncrement);

        protected int IsRangeIndex(Rule[] rules, double angle)
        {
            for (int i = 0; i < rules.Length; i++)
            {
                if (angle >= rules[i].min && angle <= rules[i].max)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
