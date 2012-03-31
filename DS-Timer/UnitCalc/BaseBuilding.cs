using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.UnitCalc
{
	public class BaseBuilding
	{
		protected double[] m_TimeFactor;

		public BaseBuilding(int maxLevel)
		{
			m_TimeFactor = new double[maxLevel];
		}
	}
}
