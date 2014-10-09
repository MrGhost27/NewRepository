using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statesv3.states
{
	class barefoot : IState
	{
		public barefoot()
		{
			name = "barefoot";
		}

		public override string remove(feet feet1)
		{
			return "that makes no sense, you have no footwear to remove";
		}

	}
}
