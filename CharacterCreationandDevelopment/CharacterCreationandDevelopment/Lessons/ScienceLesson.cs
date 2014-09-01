using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
    class ScienceLesson : ILesson
    {
        private PlayerCharacter _player;
        private string _lessonName;

        public ScienceLesson(PlayerCharacter player)
        {
            this._player = player;
            _lessonName = "Scientific Training";
        }

        public string GetLessonName()
        {
            return _lessonName;
        }

		public int GetNewSkillValue()
		{
			int newSkillValue = _player.science;
			return newSkillValue;
		}

        public string LessonEffects()
        {
			int previousValue = _player.science;
            _player.science += _player.intelligence / 2;

            if (_player.science > 100)
            {
                _player.science = 100;
            }

            if (_player.science.IsBetween(0, 15, previousValue))
            {
                return _player.name + " has a basic grasp that forces are at work in the universe";
            }
            else if (_player.science.IsBetween(15, 30, previousValue))
            {
                return _player.name + " understands the concepts of mass and gravity";
            }
            else if (_player.science.IsBetween(30, 45, previousValue))
            {
                return _player.name + "  understands how electricity and magetism works";
            }
            else if (_player.science.IsBetween(45, 60, previousValue))
            {
                return _player.name + " understands how to generate and transfer heat";
            }
            else if (_player.science.IsBetween(60, 75, previousValue))
            {
                return _player.name + " understands how light is both a wave and a particle";
            }
            else if (_player.science.IsBetween(75, 90, previousValue))
            {
                return _player.name + " understands the concept of spacetime";
            }
            else if (_player.science.IsBetween(90, 99, previousValue))
            {
                return _player.name + " has a very firm grasp on the physical properties of the universe";
            }
            else if (_player.science == 100)
            {
                return _player.name + " cannot learn anything new in " + _lessonName;
            }
			return _player.name + " is in " + this._lessonName + " and practicing existing skills";
        }
    }
}
