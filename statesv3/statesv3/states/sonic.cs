using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statesv3.states
{
	class sonic : IState
	{
		public override string applySonic(feet feet1)
		{
			return "As you aren't even sure how you got this pair its best not to even think about a second pair of sonic's boots";
		}

		public override int run()
		{
			int speed = 11;
			return speed;
		}
	}
}
