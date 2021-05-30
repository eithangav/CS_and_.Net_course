using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ValueOutOfRangeException: Exception
    {
        private float m_MinValue;
        private float m_MaxValue;

        public ValueOutOfRangeException(
            float i_MinValue,
            float i_MaxValue)
            : base(string.Format("Error: The provided value is out of range. A proper value should be between {0} - {1} (inclusive)", 
                i_MinValue, i_MaxValue))
        {
            m_MaxValue = i_MaxValue;
            m_MinValue = i_MinValue;
        }

        public float MinValue
        {
            get
            {
                return m_MinValue;
            }
        }

        public float MaxValue
        {
            get
            {
                return m_MaxValue;
            }
        }
    }
}
