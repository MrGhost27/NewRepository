using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statesv1.states
{
	public class locked : IState
	{
		public override string lockDoor(Door door)
		{
			return "door is already locked";
		}

		public override string unlock(Door door)
		{
			door.state = new unlocked();
			return "door  becomes unlocked";
		}

		public override string openDoor(Door door)
		{
			return "cannot open, door is locked";
		}

		public override string close(Door door)
		{
			return "cannot close, door is locked";
		}
	}
}
