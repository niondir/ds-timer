using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Timer.AttackPlaner
{
	public class NullAttackOrder : AttackOrder
	{
		public NullAttackOrder()
		{
			Comment = "Kein Befehl";
		}
	}
}
