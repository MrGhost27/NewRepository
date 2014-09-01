using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
	class FaithLesson : ILesson
	{
		private PlayerCharacter _player;
        private string _lessonName;
		private int newSkillValue;

        public FaithLesson(PlayerCharacter player)
        {
            this._player = player;
            _lessonName = "Faith Training";
        }

        public string GetLessonName()
        {
            return _lessonName;
        }

		public int GetNewSkillValue()
		{
			int newSkillValue = _player.faith;
			return newSkillValue;
		}

        public string GetAttributeUsed()
        {
            return "Charisma";
        }

        public string LessonEffects()
        {
			int previousValue = _player.faith;
			_player.faith += _player.charisma / 2;

			if (_player.faith > 100)
            {
				_player.faith = 100;
            }

			if (_player.faith.IsBetween(0, 15, previousValue))
            {
                return _player.name + " learns all about the creation story";
            }
			else if (_player.faith.IsBetween(15, 30, previousValue))
            {
                return _player.name + " learns to talk to the clouds with her hands together";
            }
			else if (_player.faith.IsBetween(30, 45, previousValue))
            {
                return _player.name + " learns to read star signs";
            }
			else if (_player.faith.IsBetween(45, 60, previousValue))
            {
                return _player.name + " learns to interpret dreams";
            }
			else if (_player.faith.IsBetween(60, 75, previousValue))
            {
                return _player.name + " learns to spot omens all around her";
            }
			else if (_player.faith.IsBetween(75, 90, previousValue))
            {
                return _player.name + " is starting to hear voices from the almighty";
            }
			else if (_player.faith.IsBetween(90, 99, previousValue))
            {
                return _player.name + " requests favours from the almighty that have an average chance to be answered";
            }
			else if (_player.faith == 100)
            {
                return _player.name + " cannot learn anything new in " + _lessonName;
            }
			return _player.name + " is in " + this._lessonName + " and practicing existing skills";
        }
	}
}
