using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Units
{
	interface IStats
	{
		int MovementSpeed { get; }
		int CurrentHealth { get; }
		int MaxHealth { get; }
	}
}
