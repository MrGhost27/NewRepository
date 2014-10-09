using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statesv1.states
{
	public class unlocked : IState
	{
		public override string lockDoor(Door door)
		{
			door.state = new locked();
			return "door becomes locked";
		}

		public override string unlock(Door door)
		{
			return "door is already unlocked";
		}

		public override string openDoor(Door door)
		{
			door.state = new open();
			return "door is opened";
		}

		public override string close(Door door)
		{
			return "cannot close, door is already closed";
		}
	}
}
