using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
    class NoLesson : ILesson
    {
        private PlayerCharacter _player;
        private string _lessonName;

        public NoLesson(PlayerCharacter player)
        {
            this._player = player;
            _lessonName = "Not Learning Anything...";
        }

        public string GetLessonName()
        {
            return _lessonName;
        }

		public int GetNewSkillValue()
		{
			return 0;
		}

		public string GetToolTip()
		{
			return "Skill Bonus: What Skill?. Makes you Bored. Very Bored.";

		}

        public string LessonEffects()
        {
            _player.SetExcitedBored(-50);
            HelperClass.GetRelationshipFromList("Mother").ChangeOpinion(-20);
            HelperClass.GetRelationshipFromList("Sister").ChangeOpinion(-20);
            return _player.name + " does nothing all month";

        }
    }
}
