using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
	class CraftingLesson : ILesson
	{
		private PlayerCharacter _player;
		private string _lessonName;

		public CraftingLesson(PlayerCharacter player)
        {
            this._player = player;
            _lessonName = "Craft Training";
        }

		public string GetLessonName()
		{
			return _lessonName;
		}

		public int GetNewSkillValue()
		{
			int newSkillValue = _player.crafting;
			return newSkillValue;
		}

		public string GetToolTip()
		{
			return "Skill Bonus: Dexterity. Makes you Excited";
		}

		public string LessonEffects()
		{
			int previousValue = _player.crafting;
			_player.crafting += (_player.dexterity / 2);
            _player.SetExcitedBored(20);

			if (_player.crafting > 100)
			{
				_player.crafting = 100;
			}

			if (_player.crafting.IsBetween(0, 15, previousValue))
			{
				return _player.name + " learns how to glue two items together if one of the items is their hand";
			}
			else if (_player.crafting.IsBetween(15, 30, previousValue))
			{
				return _player.name + " learns how to create a pointed metal stick";
			}
			else if (_player.crafting.IsBetween(30, 45, previousValue))
			{
				return _player.name + " learns how to create a dagger";
			}
			else if (_player.crafting.IsBetween(45, 60, previousValue))
			{
				return _player.name + " learns how to create a longsword";
			}
			else if (_player.crafting.IsBetween(60, 75, previousValue))
			{
				return _player.name + " learns how to create a double-bladed sword";
			}
			else if (_player.crafting.IsBetween(75, 90, previousValue))
			{
				return _player.name + " learns how to create a katana";
			}
			else if (_player.crafting.IsBetween(90, 99, previousValue))
			{
				return _player.name + " learns how to make a masterwork katana";
			}
			else if (_player.crafting == 100)
			{
				return _player.name + " cannot learn anything new in " + _lessonName;
			}
			return _player.name + " is in " + this._lessonName + " and practicing existing skills";
		}
	}


}
