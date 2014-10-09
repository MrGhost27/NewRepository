using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statesv3.states
{
	class running : IState
	{
		public override string applyRunning(feet feet1)
		{
			return "You try to fit another pair of running shoes over your current shoes but fail miserably";
		}

		public override int run()
		{
			int speed = 10;
			return speed;
		}
	}
}
