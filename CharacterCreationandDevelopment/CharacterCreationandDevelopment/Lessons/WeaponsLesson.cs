using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
    class WeaponsLesson : ILesson
    {
        private PlayerCharacter _player;
        private string _lessonName;

        public WeaponsLesson(PlayerCharacter player)
        {
            this._player = player;
            _lessonName = "Weapons Class";
        }

        public string GetLessonName()
        {
            return _lessonName;
        }

        public string LessonEffects()
        {
            _player.weapons += 10;

            if (_player.weapons > 100)
            {
                _player.weapons = 100;
            }
            
            if (_player.weapons.IsBetween(0,15))
            {
                return _player.name + " learns to look with eyes, not with hands";
            }
            else if (_player.weapons.IsBetween(15,30))
            {
                return _player.name + " learns to stick 'em with the pointy end";
            }
            else if (_player.weapons.IsBetween(30, 45))
            {
                return _player.name + " learns to make the weapon an extension of their body";
            }
            else if (_player.weapons.IsBetween(45, 60))
            {
                return _player.name + " learns that a man cannot push a button, if you disable his hand";
            }
            else if (_player.weapons.IsBetween(60, 75))
            {
                return _player.name + " learns that the sword really IS mighter than the quill.";
            }
            else if (_player.weapons.IsBetween(75, 90))
            {
                return _player.name + " is going to have to be registered AS a lethal weapon";
            }
            else if (_player.weapons.IsBetween(90, 99))
            {
                return _player.name + " could take on just about anyone, with a spoon";
            }
            else if (_player.weapons == 100)
            {
                return _player.name + " cannot learn anything new in " + _lessonName;
            }
            return _player.name + " is in " + this._lessonName + " but didn't learn anything new";
        }
    }
}
