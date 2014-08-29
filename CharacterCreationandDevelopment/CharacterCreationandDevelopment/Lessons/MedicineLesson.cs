using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
	class MedicineLesson : ILesson
	{
		private PlayerCharacter _player;
        private string _lessonName;

        public MedicineLesson(PlayerCharacter player)
        {
            this._player = player;
            _lessonName = "Medic Training";
        }

        public string GetLessonName()
        {
            return _lessonName;
        }

        public string LessonEffects()
        {
			int previousValue = _player.medicine;
            _player.medicine += _player.intelligence /2;

			if (_player.medicine > 100)
            {
				_player.medicine = 100;
            }

			if (_player.medicine.IsBetween(0, 15, previousValue))
            {
                return _player.name + " learns that bleeding is bad";
            }
			else if (_player.medicine.IsBetween(15, 30, previousValue))
            {
                return _player.name + " can bandage minor cuts";
            }
			else if (_player.medicine.IsBetween(30, 45, previousValue))
            {
                return _player.name + " learns to make a splint for broken bones";
            }
			else if (_player.medicine.IsBetween(45, 60, previousValue))
            {
                return _player.name + " learns to stitch up ";
            }
			else if (_player.medicine.IsBetween(60, 75, previousValue))
            {
                return _player.name + " learns that the sword really IS mighter than the quill.";
            }
			else if (_player.medicine.IsBetween(75, 90, previousValue))
            {
                return _player.name + " is going to have to be registered AS a lethal weapon";
            }
			else if (_player.medicine.IsBetween(90, 99, previousValue))
            {
                return _player.name + " could take on just about anyone, with a spoon";
            }
			else if (_player.medicine == 100)
            {
                return _player.name + " cannot learn anything new in " + _lessonName;
            }
			return _player.name + " is in " + this._lessonName + " and practicing existing skills";
        }
	}
}
