using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statesv1.states
{
	public class open : IState
	{
		public override string lockDoor(Door door)
		{
			return "door cannot be locked while open";
		}

		public override string unlock(Door door)
		{
			return "door is already unlocked because it is open";
		}

		public override string openDoor(Door door)
		{
			return "door is already open";
		}

		public override string close(Door door)
		{
			door.state = new unlocked();
			return "door is closed";
		}

	}
}
