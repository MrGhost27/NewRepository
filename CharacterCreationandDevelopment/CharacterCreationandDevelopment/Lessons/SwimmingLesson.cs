using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
	class SwimmingLesson : ILesson
	{
		private PlayerCharacter _player;
		private string _lessonName;

		public SwimmingLesson(PlayerCharacter player)
		{
			this._player = player;
			this._lessonName = "Swimming Training";
		}

		public string GetLessonName()
		{
			return _lessonName;
		}

		public int GetNewSkillValue()
		{
			int newSkillValue = _player.swimming;
			return newSkillValue;
		}

        public string GetAttributeUsed()
        {
            return "Swimming";
        }

		public string LessonEffects()
		{
			int previousvalue = _player.swimming;
			_player.swimming += _player.strength / 2;

			if (_player.swimming > 100)
			{
				_player.swimming = 100;
			}

			if (_player.swimming.IsBetween(0, 15, previousvalue))
			{
				return _player.name + " learns how to hold a breath";
			}
			else if (_player.swimming.IsBetween(15, 30, previousvalue))
			{
				return _player.name + " learns how to float on the surface without drowning";
			}
			else if (_player.swimming.IsBetween(30, 45, previousvalue))
			{
				return _player.name + " can now swim for about 10 metres in the doggy paddle style";
			}
			else if (_player.swimming.IsBetween(45, 60, previousvalue))
			{
				return _player.name + " can swim 50 metre lengths";
			}
			else if (_player.swimming.IsBetween(60, 75, previousvalue))
			{
				return _player.name + " can dive to the bottom, gather stones and make it back to the surface.";
			}
			else if (_player.swimming.IsBetween(75, 90, previousvalue))
			{
				return _player.name + " can swim against a current in clothes";
			}
			else if (_player.swimming.IsBetween(90, 99, previousvalue))
			{
				return _player.name + " can basically breathe underwater";
			}
			else if (_player.weapons == 100)
			{
				return _player.name + " cannot learn anything new in " + _lessonName;
			}
			return _player.name + " is in " + this._lessonName + " and practicing existing skills";
		}
	}
}
