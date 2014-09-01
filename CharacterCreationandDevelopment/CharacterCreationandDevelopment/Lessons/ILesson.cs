using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment.Lessons
{
    public interface ILesson
    {
        string GetLessonName();
        string LessonEffects();
		int GetNewSkillValue();
        string GetAttributeUsed();
    }
}
