using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using statesv3.states;

namespace statesv3
{
	class feet
	{
		public IState state { get; set; }

		public string changeFootwear(int i)
		{
			string result;
			switch (i)
			{
				case 1: result = state.remove(this);
					break;
				case 2: result = state.applySocks(this);
					break;
				case 3: result = state.applySlippers(this);
					break;
				case 4: result = state.applyNormal(this);
					break;
				case 5: result = state.applyRunning(this);
					break;
				case 6: result = state.applySonic(this);
					break;
				default: result = "this shouldnt be a possible outcome";
					break;
			}
			return result;
		}
	}
}
