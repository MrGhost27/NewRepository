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
			_player.athletics += 5 + (_player.constitution / 2);
            _player.SetExcitedBored(-20);

			if (_player.athletics > 100)
			{
				_player.athletics = 100;
			}

			if (_player.athletics.IsBetween(0, 15, previousvalue))
			{
				return _player.name + " learns to look with eyes, not with hands";
			}
			else if (_player.athletics.IsBetween(15, 30, previousvalue))
			{
				return _player.name + " learns to stick 'em with the pointy end";
			}
			else if (_player.athletics.IsBetween(30, 45, previousvalue))
			{
				return _player.name + " learns to make the weapon an extension of their body";
			}
			else if (_player.athletics.IsBetween(45, 60, previousvalue))
			{
				return _player.name + " learns that a man cannot push a button, if you disable his hand";
			}
			else if (_player.athletics.IsBetween(60, 75, previousvalue))
			{
				return _player.name + " learns that the sword really IS mighter than the quill.";
			}
			else if (_player.athletics.IsBetween(75, 90, previousvalue))
			{
				return _player.name + " is going to have to be registered AS a lethal weapon";
			}
			else if (_player.athletics.IsBetween(90, 99, previousvalue))
			{
				return _player.name + " could take on just about anyone, with a spoon";
			}
			else if (_player.athletics == 100)
			{
				return _player.name + " cannot learn anything new in " + _lessonName;
			}
			return _player.name + " is in " + this._lessonName + " and practicing existing skills";
		}
	}
}
