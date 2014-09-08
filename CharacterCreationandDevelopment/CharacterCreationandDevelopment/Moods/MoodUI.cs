using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CharacterCreationandDevelopment.Moods
{
    public partial class MoodUI : Form
    {
        private PlayerCharacter player;

        public MoodUI(PlayerCharacter player)
        {
            InitializeComponent();
            this.player = player;
            this.StartPosition = FormStartPosition.CenterScreen;
            MakeChartWork();
        }

        private void MakeChartWork()
        {
            string[] seriesArray = { "Happy/Depressed", "Bored/Angry", "Fearless/Scared", "Sane/Insane" };
            chart1.Titles[0].Text = ("Your Current Mood: " + player.CurrentMood.GetName());
            this.BackgroundImage = player.CurrentMood.GetMoodImage();

           
            Series series = new Series();

            for (int i = 0; i < seriesArray.Length; i++)
            {
                series = this.chart1.Series.Add(seriesArray[i]);
                series.Color = chart1.PaletteCustomColors[i];
                series.Points.Add(player.moodValues[i]);
                series.IsValueShownAsLabel = true;
                series.CustomProperties = "DrawingStyle=Wedge, LabelStyle=Bottom";
                series.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
    }
}
