using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
	class SurvivalLesson : ILesson
	{
		private PlayerCharacter _player;
		private string _lessonName;

		public SurvivalLesson(PlayerCharacter player)
        {
            this._player = player;
            _lessonName = "Survival Training";
        }

		public string GetLessonName()
		{
			return _lessonName;
		}

		public int GetNewSkillValue()
		{
			int newSkillValue = _player.survival;
			return newSkillValue;
		}

		public string GetToolTip()
		{
			return "Skill Bonus: Wisdom. Makes you Depressed";
		}

		public string LessonEffects()
		{
			int previousValue = _player.survival;
			_player.survival += 5 + (_player.wisdom / 2);
            _player.SetHappyDepressed(-20);

			if (_player.survival > 100)
			{
				_player.survival = 100;
			}

			if (_player.survival.IsBetween(0, 15, previousValue))
			{
				return _player.name + " learns which way is North";
			}
			else if (_player.survival.IsBetween(15, 30, previousValue))
			{
				return _player.name + " learns to make a rudimetary fire";
			}
			else if (_player.survival.IsBetween(30, 45, previousValue))
			{
				return _player.name + " learns to create a shelter from items around them";
			}
			else if (_player.survival.IsBetween(45, 60, previousValue))
			{
				return _player.name + " learns which berries and mushrooms are poisonous";
			}
			else if (_player.survival.IsBetween(60, 75, previousValue))
			{
				return _player.name + " learns how to set traps and hunt prey";
			}
			else if (_player.survival.IsBetween(75, 90, previousValue))
			{
				return _player.name + " can fashion weapons from materials available";
			}
			else if (_player.survival.IsBetween(90, 99, previousValue))
			{
				return _player.name + " could survive without any aid for months at a time";
			}
			else if (_player.survival == 100)
			{
				return _player.name + " cannot learn anything new in " + _lessonName;
			}
			return _player.name + " is in " + this._lessonName + " and practicing existing skills";
		}
	}
}
