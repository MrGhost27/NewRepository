using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreationandDevelopment.Lessons
{
	public partial class LessonLearningForm : Form
	{

		public LessonLearningForm(ILesson todaysLesson, World world, PlayerCharacter player)
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			RunLesson(todaysLesson, world, player);
		}

		private void RunLesson(ILesson todaysLesson, World world, PlayerCharacter player)
		{
			world.SetLesson(todaysLesson);
			this.Text = world.lesson.GetLessonName();
			txtReport.AppendText(world.GetDate() + ": " + world.lesson.LessonEffects() + Environment.NewLine);
			pBarLessonProgress.Value = todaysLesson.GetNewSkillValue();
		}
	}
}
