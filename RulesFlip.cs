using System;
using System.Collections.Generic;

namespace Pendulum
{
    class RulesFlip : RulesBase
    {
        public RulesFlip()
        {
            m_outTest = "Переворот маятника:\n";
            m_angle = 0;
            m_coordY.Add(0);

            m_rulesAngleValue = new Rule[5]
            {
                new Rule(-360, -175, -170),
                new Rule(-90,  -85,  -80),
                new Rule(-5,    0,    5),
                new Rule( 80,   85,   90),
                new Rule( 170,  175,  360)
            };

            m_rulesAngleIncrement = new Rule[5]
            {
                new Rule(-360, -10,  -9),
                new Rule(-7,   -6,   -5),
                new Rule(-5,    0,    5),
                new Rule( 5,    6,    7),
                new Rule( 9,    10,   360)
            };

            m_rulesAngleControls = new Rule[5]
            {
                new Rule(-4,   -4,   -4),
                new Rule(-2,   -2,   -2),
                new Rule( 0,    0,    0),
                new Rule( 2,    2,    2),
                new Rule( 4,    4,    4)
            };

            m_rulesMatrix = new Object[5, 5]
            {
                { m_rulesAngleControls[2], null                   , null                   , null                   , null                    },
                { m_rulesAngleControls[1], null                   , null                   , null                   , null                    },
                { m_rulesAngleControls[0], m_rulesAngleControls[1], m_rulesAngleControls[4], m_rulesAngleControls[3], m_rulesAngleControls[4] },
                { null                   , null                   , null                   , null                   , m_rulesAngleControls[3] },
                { null                   , null                   , null                   , null                   , m_rulesAngleControls[2] }
            };
        }

        int m_angleStep = 1;
        double m_localAddAngle = 0; //telezhka

        public override void Start()
        {
            while (true)
            {
                if (Math.Abs(m_angle + m_angleIncrease) >= 176)
                {
                    if (Math.Abs(m_angle) >= 176)
                    {
                        m_coordY.Add(m_angle);
                        break;
                    }
                }
                else
                {
                    Move();
                }

                TryGoBackOrForward();
                m_angle += m_angleStep;
                m_angleIncrease -= m_angleStep;
                m_outTest += "Угол = " + m_angle + ", Прирост = " + m_angleIncrease + "\n";
            }
        }

        private void TryGoBackOrForward()
        {
            if (m_angleIncrease != 0) return;

            m_angleIncrease += -2 * m_angle;
            m_coordY.Add(m_angle);

            if (m_angle > 0)
            {
                m_angleStep = -1;
                m_outTest += "Разворот max: " + m_angle + "\n-----------\n";
            }
            if (m_angle < 0)
            {
                m_angleStep = 1;
                m_outTest += "Разворот min: " + m_angle + "\n-----------\n";
            }
        }

        protected override void MoveLogic(Rule rule, int indexAngleValue, int indexAngleIncrement)
        {
            double maxAddAngle = 10000;
            if (m_localAddAngle + rule.med <= maxAddAngle && m_localAddAngle + rule.med >= -maxAddAngle)
            {
                m_localAddAngle += rule.med;
                m_angleIncrease += rule.med;
                m_outTest += " Add " + rule.med + "\n";
            }
        }
    }
}
