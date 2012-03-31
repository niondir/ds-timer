using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.UnitCalc.Buildings
{
	public class Barracks : BaseBuilding
	{
		public Barracks() : base(25)
		{
			m_TimeFactor[0] = 0.63;
			m_TimeFactor[1] = 0.59;
			m_TimeFactor[2] = 0.56;
			m_TimeFactor[3] = 0.53;
			m_TimeFactor[4] = 0.50;
			m_TimeFactor[5] = 0.47;
			m_TimeFactor[6] = 0.44;
			m_TimeFactor[7] = 0.42;
			m_TimeFactor[8] = 0.39;
			m_TimeFactor[9] = 0.37;
			m_TimeFactor[10] = 0.35;
			m_TimeFactor[11] = 0.33;
			m_TimeFactor[12] = 0.31;
			m_TimeFactor[13] = 0.29;
			m_TimeFactor[14] = 0.28;
			m_TimeFactor[15] = 0.26;
			m_TimeFactor[16] = 0.25;
			m_TimeFactor[17] = 0.23;
			m_TimeFactor[18] = 0.22;
			m_TimeFactor[19] = 0.21;
			m_TimeFactor[20] = 0.20;
			m_TimeFactor[21] = 0.19;
			m_TimeFactor[22] = 0.17;
			m_TimeFactor[23] = 0.16;
			m_TimeFactor[24] = 0.16;
		}
	}
}
