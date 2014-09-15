using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
    class ClimbingLesson : ILesson
    {
        private PlayerCharacter _player;
        private string _lessonName;

        public ClimbingLesson(PlayerCharacter player)
        {
            this._player = player;
            this._lessonName = "Climbing";
        }

        public string GetLessonName()
        {
            return _lessonName;
        }

        public int GetNewSkillValue()
        {
            int newSkillValue = _player.climbing;
            return newSkillValue;
        }

        public string GetToolTip()
        {
            return "Skill Bonus: Constitution. Makes you Happy";
        }

        public string LessonEffects()
        {
            int previousvalue = _player.climbing;
            _player.climbing += (_player.constitution / 2);
            _player.SetHappyDepressed(20);
            HelperClass.GetRelationshipFromList("Sister").ChangeOpinion(20);
            HelperClass.GetRelationshipFromList("Mother").ChangeOpinion(-20);

            if (_player.climbing > 100)
            {
                _player.climbing = 100;
            }

            if (_player.climbing.IsBetween(0, 15, previousvalue))
            {
                return _player.name + " learns to climb stairs";
            }
            else if (_player.climbing.IsBetween(15, 30, previousvalue))
            {
                return _player.name + " learns to hang off trees and walls.";
            }
            else if (_player.climbing.IsBetween(30, 45, previousvalue))
            {
                return "you can lift your own body weight";
            }
            else if (_player.climbing.IsBetween(45, 60, previousvalue))
            {
                return _player.name + " you learn which branches will hold your weight";
            }
            else if (_player.climbing.IsBetween(60, 75, previousvalue))
            {
                return _player.name + " you learn where to put your hands to climb higher";
            }
            else if (_player.climbing.IsBetween(75, 90, previousvalue))
            {
                return _player.name + " can climb vertical surfaces";
            }
            else if (_player.climbing.IsBetween(90, 99, previousvalue))
            {
                return _player.name + " scales walls and trees like spiderman";
            }
            else if (_player.climbing == 100)
            {
                return _player.name + " cannot learn anything new in " + _lessonName;
            }
            return _player.name + " is practicing " + this._lessonName;
        }
    }
}
