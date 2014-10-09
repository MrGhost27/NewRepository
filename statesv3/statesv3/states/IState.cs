using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statesv3.states
{
	abstract class IState
	{
		public string name;

		public virtual string remove(feet feet1) 
		{
			feet1.state = new barefoot();
			return "You take off your footwear"; 
		}

		public virtual string applySocks(feet feet1) 
		{
			feet1.state = new socks();
			return "You are now wearing just socks"; ; 
		}

		public virtual string applySlippers(feet feet1) 
		{
			feet1.state = new slippers();
			return "You are now wearing slippers"; 
		}

		public virtual string applyNormal(feet feet1) 
		{
			feet1.state = new normal();
			return "You are now wearing your normal shoes";  
		}

		public virtual string applyRunning(feet feet1) 
		{
			feet1.state = new running();
			return "You are now wearing your running shoes"; 
		}

		public virtual string applySonic(feet feet1) 
		{
			feet1.state = new sonic();
			return "You put on Sonic's amazing running boots"; 
		}

		public virtual int run()
		{
			int speed = 0;
			return speed;
		}

	}
}
