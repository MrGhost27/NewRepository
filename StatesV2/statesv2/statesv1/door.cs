using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using statesv1.states;

namespace statesv1
{
	public class Door
	{
		public IState state { get; set; }

		public Door()
		{
			state = new locked();
		}

		

		public string action(int i)
		{
			string result;

			switch (i)
			{
				case 1: result = state.openDoor(this);
					break;
				case 2: result = state.unlock(this);
					break;
				case 3: result = state.lockDoor(this);
					break;
				case 4: result = state.close(this);
					break;
				default: result = "secrets!";
					break;
			}

			return result;
		}

	}

}
