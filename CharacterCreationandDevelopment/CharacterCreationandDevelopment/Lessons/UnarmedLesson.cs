using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
	class UnarmedLesson : ILesson
	{
		private PlayerCharacter _player;
		private string _lessonName;

		public UnarmedLesson(PlayerCharacter player)
        {
            this._player = player;
            _lessonName = "Unarmed Combat Training";
        }

		public string GetLessonName()
		{
			return _lessonName;
		}

		public int GetNewSkillValue()
		{
			int newSkillValue = _player.unarmed;
			return newSkillValue;
		}

		public string GetToolTip()
		{
			return "Skill Bonus: Strength and Dexterity. Makes you Angry";
		}

		public string LessonEffects()
		{
			int previousValue = _player.unarmed;
			_player.unarmed += (_player.strength / 4) + (_player.dexterity / 4);
            _player.SetAngryAfraid(20);

			if (_player.unarmed > 100)
			{
				_player.unarmed = 100;
			}

			if (_player.unarmed.IsBetween(0, 15, previousValue))
			{
				return _player.name + " learns how to wax cars, sand floors and paint fences";
			}
			else if (_player.unarmed.IsBetween(15, 30, previousValue))
			{
				return _player.name + " changes belt from white to another colour. Trousers still stay up.";
			}
			else if (_player.unarmed.IsBetween(30, 45, previousValue))
			{
				return _player.name + " has done enough training to do a montage";
			}
			else if (_player.unarmed.IsBetween(45, 60, previousValue))
			{
				return _player.name + " knows Kung Fu....";
			}
			else if (_player.unarmed.IsBetween(60, 75, previousValue))
			{
				return _player.name + " has stopped trying to hit people and hits people";
			}
			else if (_player.unarmed.IsBetween(75, 90, previousValue))
			{
				return _player.name + " learns 'crane' technique that no can defense";
			}
			else if (_player.unarmed.IsBetween(90, 99, previousValue))
			{
				return _player.name + " is trained in the ancient art of sharusahk";
			}
			else if (_player.unarmed == 100)
			{
				return _player.name + " cannot learn anything new in " + _lessonName;
			}
			return _player.name + " is in " + this._lessonName + " and practicing existing skills";
		}
	}
}
