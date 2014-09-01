using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
	class AnimalEmpathyLesson : ILesson
	{
		private PlayerCharacter _player;
        private string _lessonName;

        public AnimalEmpathyLesson(PlayerCharacter player)
        {
            this._player = player;
            _lessonName = "Animal Empathy Training";
        }

        public string GetLessonName()
        {
            return _lessonName;
        }

		public int GetNewSkillValue()
		{
			int newSkillValue = _player.animalEmpathy;
			return newSkillValue;
		}

        public string LessonEffects()
        {
			int previousValue = _player.animalEmpathy;
			_player.animalEmpathy += _player.charisma / 2;

			if (_player.animalEmpathy > 100)
            {
				_player.animalEmpathy = 100;
            }

			if (_player.animalEmpathy.IsBetween(0, 15, previousValue))
            {
                return _player.name + " understands the difference between friendly and hostile animals";
            }
			else if (_player.animalEmpathy.IsBetween(15, 30, previousValue))
            {
                return _player.name + " can track the animals in the area";
            }
			else if (_player.animalEmpathy.IsBetween(30, 45, previousValue))
            {
                return _player.name + " can call a pet cat";
            }
			else if (_player.animalEmpathy.IsBetween(45, 60, previousValue))
            {
                return _player.name + " can befriend most hostile animals";
            }
			else if (_player.animalEmpathy.IsBetween(60, 75, previousValue))
            {
                return _player.name + " can call a pet dog";
            }
			else if (_player.animalEmpathy.IsBetween(75, 90, previousValue))
            {
                return _player.name + " can communicate with most animals";
            }
			else if (_player.animalEmpathy.IsBetween(90, 99, previousValue))
            {
                return _player.name + " can call a pet monkey";
            }
			else if (_player.animalEmpathy == 100)
            {
                return _player.name + " cannot learn anything new in " + _lessonName;
            }
			return _player.name + " is in " + this._lessonName + " and practicing existing skills";
        }
	}
}
