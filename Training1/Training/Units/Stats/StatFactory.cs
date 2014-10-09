using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Units.Stats
{
	internal static class StatFactory
	{
		internal static IStats GetStats(StatType type)
		{
			IStats stats = null;
			switch (type)
			{
				case StatType.BasicAgent:
					stats = new BasicAgentStats();
					break;
				case StatType.BasicSoldier:
					stats = new BasicSoldierStats();
					break;
				default:
					break;
			}
			return stats;
		}
	}
}
