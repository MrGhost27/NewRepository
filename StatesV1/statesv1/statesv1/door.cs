using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statesv1
{
	public abstract class IState
	{
		public virtual string lockDoor(Context context)
		{
			return "";
		}

		public virtual string unlock(Context context)
		{
			return "";
		}

		public virtual string openDoor(Context context)
		{
			return "";
		}

		public virtual string close(Context context)
		{
			return "";
		}
	}

	public class locked : IState
	{
		public override string lockDoor(Context context)
		{
			return "door is already locked";
		}

		public override string unlock(Context context)
		{
			context.state = new unlocked();
			return "door  becomes unlocked";
		}

		public override string openDoor(Context context)
		{
			return "cannot open, door is locked";
		}

		public override string close(Context context)
		{
			return "cannot close, door is locked";
		}
	}

	public class unlocked : IState
	{
		public override string lockDoor(Context context)
		{
			context.state = new locked();
			return "door becomes locked";
		}

		public override string unlock(Context context)
		{
			return "door is already unlocked";
		}

		public override string openDoor(Context context)
		{
			context.state = new open();
			return "door is opened";
		}

		public override string close(Context context)
		{
			return "cannot close, door is already closed";
		}
	}

	public class open : IState
	{
		public override string lockDoor(Context context)
		{
			return "door cannot be locked while open";
		}

		public override string unlock(Context context)
		{
			return "door is already unlocked because it is open";
		}

		public override string openDoor(Context context)
		{
			return "door is already open";
		}

		public override string close(Context context)
		{
			context.state = new unlocked();
			return "door is closed";
		}

	}

	public class Context
	{
		public IState state {get;set;}

		public string performLock()
		{
			string result = state.lockDoor(this);
			return result;
		}

		public string performUnlock()
		{
			string result = state.unlock(this);
			return result;
		}

		public string performOpen()
		{
			string result = state.openDoor(this);
			return result;
		}

		public string performClose()
		{
			string result = state.close(this);
			return result;
		}
	}

}
