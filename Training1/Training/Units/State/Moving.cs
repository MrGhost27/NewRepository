﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Units.State
{
	class Moving : IState
	{
		public string State { get { return "Moving"; } }
	}
}
