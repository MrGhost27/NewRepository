using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class World
    {
        private string Year;
        private string Month;
        private int monthNumber;
        private Months currentMonth { get; private set; }

        private PlayerCharacter player;
        
        public World(PlayerCharacter playerInWorld)
        {
            monthNumber = 0;
            this.player = playerInWorld;
            WorldForm WorldUI = new WorldForm();
            WorldUI.Show();
        }

        public void EndTurn()
        {
            if (monthNumber == 11)
            {
                monthNumber = 0;
            }
            else
            {
                monthNumber++;
            }

            label1.text = currentMonth.GetMonth(monthNumber);
        }
    }
}
