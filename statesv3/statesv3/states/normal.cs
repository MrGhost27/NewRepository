using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statesv3.states
{
	class normal : IState
	{
		public override string applyNormal(feet feet1)
		{
			return "Sorry but you only have enough feet for one pair of shoes at a time";
		}
		public override int run()
		{
			int speed = 5;
			return speed;
		}
	}
}
