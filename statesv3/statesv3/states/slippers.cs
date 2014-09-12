using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statesv3.states
{
	class slippers : IState
	{
		public override string applySlippers(feet feet1)
		{
			return "You suddenly realise what a bad idea this would be and stick with one pair of slippers";
		}

		public override int run()
		{
			int speed = 1;
			return speed;
		}
	}
}
