using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.World
{
	public class WorldInfo
	{
		public String Name { get; private set; }
		public String Server { get; private set; }
		public Decimal WorldSpeed { get; private set; }
		public Decimal UnitSpeed { get; private set; }

		public WorldInfo(string name, string server)
			: this(name, server, 0, 0)
		{
		}

		public WorldInfo(string name, string server, decimal worldSpeed, decimal unitSpeed)
		{
			Name = name;
			Server = server;
			WorldSpeed = worldSpeed;
			UnitSpeed = unitSpeed;
		}
	}
}
