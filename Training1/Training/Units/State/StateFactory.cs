using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Units.State
{
	static class StateFactory
	{
		internal static IState State(StateType type)
		{
			IState state = null;
			switch (type)
			{
				case StateType.Active:
					state = new Active();
					break;
				case StateType.Idle:
					state = new Idle();
					break;
				case StateType.Moving:
					state = new Moving();
					break;
				default:
					break;
			}
			return state;
		}
	}
}
