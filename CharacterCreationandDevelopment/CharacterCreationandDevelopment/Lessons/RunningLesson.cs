using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
	class RunningLesson : ILesson
	{
		private PlayerCharacter _player;
		private string _lessonName;

		public RunningLesson(PlayerCharacter player)
		{
			this._player = player;
			this._lessonName = "Running";
		}
		
		public string GetLessonName()
		{
			return _lessonName;
		}

		public int GetNewSkillValue()
		{
			int newSkillValue = _player.running;
			return newSkillValue;
		}

		public string GetToolTip()
		{
			return "Skill Bonus: Constitution. Makes you Bored";
		}

		public string LessonEffects()
		{
            int previousvalue = _player.running;
            _player.running += (_player.constitution / 2);
            _player.SetExcitedBored(-20);

            if (_player.running > 100)
			{
                _player.running = 100;
			}

            if (_player.running.IsBetween(0, 15, previousvalue))
			{
				return _player.name + " learns to get a stitch going up a hill";
			}
            else if (_player.running.IsBetween(15, 30, previousvalue))
			{
				return _player.name + " learns to put one foot in front of the other in quick succession";
			}
            else if (_player.running.IsBetween(30, 45, previousvalue))
			{
				return _player.name + " learns to breathe effectively and maintain a steady pace";
			}
            else if (_player.running.IsBetween(45, 60, previousvalue))
			{
				return _player.name + " learns to sprint in short bursts where necessary";
			}
            else if (_player.running.IsBetween(60, 75, previousvalue))
			{
				return _player.name + " can run cross country adaquately";
			}
            else if (_player.running.IsBetween(75, 90, previousvalue))
			{
				return _player.name + " pities the fool that tries to race him";
			}
            else if (_player.running.IsBetween(90, 99, previousvalue))
			{
				return _player.name + " can effectively run indefinitely";
			}
            else if (_player.running == 100)
			{
				return _player.name + " cannot learn anything new in " + _lessonName;
			}
			return _player.name + " is practicing" + this._lessonName;
		}
	}
}
