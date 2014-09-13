using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
	class DiplomacyLesson : ILesson
	{
		private PlayerCharacter _player;
		private string _lessonName;

		public DiplomacyLesson(PlayerCharacter player)
        {
            this._player = player;
            _lessonName = "Diplomacy Training";
        }

		public string GetLessonName()
		{
			return _lessonName;
		}

		public int GetNewSkillValue()
		{
			int newSkillValue = _player.diplomacy;
			return newSkillValue;
		}

		public string GetToolTip()
		{
			return "Skill Bonus: Charisma. Makes you Logical";
		}

		public string LessonEffects()
		{
			int previousValue = _player.diplomacy;
			_player.diplomacy += (_player.charisma / 2);
            _player.SetLogicalCrazy(20);

            if (_player.diplomacy > 100)
			{
                _player.diplomacy = 100;
			}

			if (_player.diplomacy.IsBetween(0, 15, previousValue))
			{
				return _player.name + " learns the art of the handshake";
			}
			else if (_player.diplomacy.IsBetween(15, 30, previousValue))
			{
				return _player.name + " learns how to compliment a person";
			}
			else if (_player.diplomacy.IsBetween(30, 45, previousValue))
			{
				return _player.name + " learns how to give constructive critism";
			}
			else if (_player.diplomacy.IsBetween(45, 60, previousValue))
			{
				return _player.name + " learns to read a person's mood by their body language";
			}
			else if (_player.diplomacy.IsBetween(60, 75, previousValue))
			{
				return _player.name + " learns to manipulate a person's feelings";
			}
			else if (_player.diplomacy.IsBetween(75, 90, previousValue))
			{
				return _player.name + " learns to create fabricated stories that are considered true";
			}
			else if (_player.diplomacy.IsBetween(90, 99, previousValue))
			{
				return _player.name + " could convince anyone of anything";
			}
			else if (_player.diplomacy == 100)
			{
				return _player.name + " cannot learn anything new in " + _lessonName;
			}
			return _player.name + " is in " + this._lessonName + " and practicing existing skills";
		}
	}

}
