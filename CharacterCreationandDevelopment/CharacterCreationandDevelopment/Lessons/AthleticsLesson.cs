using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
	class AthleticsLesson : ILesson
	{
		private PlayerCharacter _player;
		private string _lessonName;

		public AthleticsLesson(PlayerCharacter player)
		{
			this._player = player;
			this._lessonName = "Athletics Training";
		}
		
		public string GetLessonName()
		{
			return _lessonName;
		}

		public int GetNewSkillValue()
		{
			int newSkillValue = _player.athletics;
			return newSkillValue;
		}

		public string GetToolTip()
		{
			return "Skill Bonus: Constitution. Makes you Bored";
		}

		public string LessonEffects()
		{
			int previousvalue = _player.athletics;
			_player.athletics += (_player.constitution / 2);
            _player.SetExcitedBored(-20);

			if (_player.athletics > 100)
			{
				_player.athletics = 100;
			}

			if (_player.athletics.IsBetween(0, 15, previousvalue))
			{
				return _player.name + " learns to get a stitch going up a hill";
			}
			else if (_player.athletics.IsBetween(15, 30, previousvalue))
			{
				return _player.name + " learns to put one foot in front of the other in quick succession";
			}
			else if (_player.athletics.IsBetween(30, 45, previousvalue))
			{
				return _player.name + " learns to breathe effectively and maintain a steady pace";
			}
			else if (_player.athletics.IsBetween(45, 60, previousvalue))
			{
				return _player.name + " learns to sprint in short bursts where necessary";
			}
			else if (_player.athletics.IsBetween(60, 75, previousvalue))
			{
				return _player.name + " can run cross country adaquately";
			}
			else if (_player.athletics.IsBetween(75, 90, previousvalue))
			{
				return _player.name + " pities the fool that tries to race him";
			}
			else if (_player.athletics.IsBetween(90, 99, previousvalue))
			{
				return _player.name + " can effectively run indefinitely";
			}
			else if (_player.athletics == 100)
			{
				return _player.name + " cannot learn anything new in " + _lessonName;
			}
			return _player.name + " is in " + this._lessonName + " and practicing existing skills";
		}
	}
}
