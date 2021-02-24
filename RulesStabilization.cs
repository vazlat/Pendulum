using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendulum
{
    class RulesStabilization : RulesBase
    {
        public RulesStabilization(double angle, double angleIncrease)
        {
            m_outTest = "Стабилизация:" + "\n";
            m_angle = angle >= 176 ? 180 - angle : -180 - angle;
            m_angleIncrease = -angleIncrease;
            m_coordY.Add(m_angle);

            m_rulesAngleValue = new Rule[5]
            {
                new Rule(-4, -4, -3),
                new Rule(-3, -2, -1),
                new Rule(-1,  0,  1),
                new Rule( 1,  2,  3),
                new Rule( 3,  4,  4)
            };

            m_rulesAngleIncrement = new Rule[5]
            {
                new Rule(-2  , -2  , -1  ),
                new Rule(-1  , -0.5, -0.2),
                new Rule(-0.2,  0  ,  0.2),
                new Rule( 0.2,  0.5,  1  ),
                new Rule( 1  ,  2  ,  2  )
            };

            m_rulesAngleControls = new Rule[5]
            {
                new Rule( 2.05,  2.05,  2.05),
                new Rule( 1.45,  1.45,  1.45),
                new Rule( 0   ,  0   ,  0   ),
                new Rule(-1.45, -1.45, -1.45),
                new Rule(-2.05, -2.05, -2.05)
            };

            m_rulesMatrix = new Object[5, 5]
            {
                { null                   , null                   , m_rulesAngleControls[0], null                   , null                    },
                { null                   , m_rulesAngleControls[1], m_rulesAngleControls[1], m_rulesAngleControls[2], null                    },
                { m_rulesAngleControls[0], m_rulesAngleControls[1], m_rulesAngleControls[2], m_rulesAngleControls[3], m_rulesAngleControls[4] },
                { null                   , m_rulesAngleControls[2], m_rulesAngleControls[3], m_rulesAngleControls[3], null                    },
                { null                   , null                   , m_rulesAngleControls[4], null                   , null                    }
            };
        }

        double m_graviti = 0.15;

        public override void Start()
        {
            int i = 50;
            while (i != 0)
            {
                m_outTest += "Angle: " + m_angle + "\n";
                Move();

                m_angleIncrease += m_angle >= 0 ? +m_graviti : -m_graviti;
                m_angle += m_angleIncrease;
                m_angleIncrease = 0;
                --i;
            }
        }

        protected override void MoveLogic(Rule rule, int indexAngleValue, int indexAngleIncrement)
        {
            m_angleIncrease += rule.med;
            if (rule.med != 0)
            {
                m_coordY.Add(m_angle);
                m_outTest += "Add " + rule.med + "   indexes: " + indexAngleValue + ", " + indexAngleIncrement + "\n-----------\n";
            }
        }
    }
}
