using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statesv1.states
{
	public abstract class IState
	{
		public virtual string lockDoor(Door door)
		{
			return "";
		}

		public virtual string unlock(Door door)
		{
			return "";
		}

		public virtual string openDoor(Door door)
		{
			return "";
		}

		public virtual string close(Door door)
		{
			return "";
		}
	}
}
