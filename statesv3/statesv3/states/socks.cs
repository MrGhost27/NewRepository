using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statesv3.states
{
	class socks : IState
	{
		public socks()
		{
			name = "socks";
		}

		public override string applySocks(feet feet1)
		{
			return "As you are already wearing socks, you just stand there";
		}

	}
}
