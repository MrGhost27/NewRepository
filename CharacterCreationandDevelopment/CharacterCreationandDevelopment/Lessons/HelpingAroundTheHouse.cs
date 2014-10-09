using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
    public class HelpingAroundTheHouse : ILesson
    {
        private PlayerCharacter _player;
        private string _lessonName;

        public HelpingAroundTheHouse(PlayerCharacter player)
        {
            this._player = player;
            _lessonName = "Helping Around The House";
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
			return "No Skill Bonus. Makes your Mum Happy. Makes you bored";
		}

        public string LessonEffects()
        {
            _player.SetExcitedBored(-20);
            Relationship relationship = HelperClass.GetRelationshipFromList("Mother");
            relationship.ChangeOpinion(20);
            return "You help your mum around the house, for which she is greatful";
        }
    }
}
