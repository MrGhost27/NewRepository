using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
	class LockpickingLesson : ILesson
	{
		private PlayerCharacter _player;
        private string _lessonName;

        public LockpickingLesson(PlayerCharacter player)
        {
            this._player = player;
            _lessonName = "Lockpick Training";
        }

        public string GetLessonName()
        {
            return _lessonName;
        }

        public string GetAttributeUsed()
        {
            return "Dexterity";
        }

		public int GetNewSkillValue()
		{
			int newSkillValue = _player.lockpicking;
			return newSkillValue;
		}

        public string LessonEffects()
        {
			int previousValue = _player.lockpicking;
			_player.lockpicking += _player.dexterity / 2;

			if (_player.lockpicking > 100)
            {
				_player.lockpicking = 100;
            }

			if (_player.lockpicking.IsBetween(0, 15, previousValue))
            {
                return _player.name + " learns to open doors that aren't locked";
            }
			else if (_player.lockpicking.IsBetween(15, 30, previousValue))
            {
                return _player.name + " learns to break into combination locks - with a hammer";
            }
			else if (_player.lockpicking.IsBetween(30, 45, previousValue))
            {
                return _player.name + " learns to unlock doors after several attempts";
            }
			else if (_player.lockpicking.IsBetween(45, 60, previousValue))
            {
                return _player.name + " learns to unlock chests after several attempts";
            }
			else if (_player.lockpicking.IsBetween(60, 75, previousValue))
            {
                return _player.name + " can unlock chests and doors in half the time";
            }
			else if (_player.lockpicking.IsBetween(75, 90, previousValue))
            {
                return _player.name + " can unlock chests and doors on the first attempt";
            }
			else if (_player.lockpicking.IsBetween(90, 99, previousValue))
            {
                return _player.name + " could break into a bank, empty a safe and lock the safe afterwards";
            }
			else if (_player.lockpicking == 100)
            {
                return _player.name + " cannot learn anything new in " + _lessonName;
            }
			return _player.name + " is in " + this._lessonName + " and practicing existing skills";
        }
	}
}
