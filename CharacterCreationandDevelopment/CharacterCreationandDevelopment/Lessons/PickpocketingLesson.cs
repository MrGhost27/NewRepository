using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
	class PickpocketingLesson : ILesson
	{
		private PlayerCharacter _player;
        private string _lessonName;

        public PickpocketingLesson(PlayerCharacter player)
        {
            this._player = player;
            _lessonName = "Pickpocket Training";
        }

        public string GetLessonName()
        {
            return _lessonName;
        }

        public string LessonEffects()
        {
			int previousValue = _player.pickpocketing;
			_player.pickpocketing += _player.dexterity / 2;

			if (_player.pickpocketing > 100)
            {
				_player.pickpocketing = 100;
            }

			if (_player.pickpocketing.IsBetween(0, 15, previousValue))
            {
                return _player.name + " can loot items from a corpse";
            }
			else if (_player.pickpocketing.IsBetween(15, 30, previousValue))
            {
                return _player.name + " can steal from a bag in the same room if the target isn't present";
            }
			else if (_player.pickpocketing.IsBetween(30, 45, previousValue))
            {
                return _player.name + " can use the 'what's that behind you?' distraction technique";
            }
			else if (_player.pickpocketing.IsBetween(45, 60, previousValue))
            {
                return _player.name + " can bump into people to take a random item from the target";
            }
			else if (_player.pickpocketing.IsBetween(60, 75, previousValue))
            {
                return _player.name + " can now take a specific valuable item from the target.";
            }
			else if (_player.pickpocketing.IsBetween(75, 90, previousValue))
            {
                return _player.name + " can subtley place items on their target";
            }
			else if (_player.pickpocketing.IsBetween(90, 99, previousValue))
            {
                return _player.name + " can take all valuable items on the target";
            }
			else if (_player.pickpocketing == 100)
            {
                return _player.name + " cannot learn anything new in " + _lessonName;
            }
			return _player.name + " is in " + this._lessonName + " and practicing existing skills";
        }
	}
}
