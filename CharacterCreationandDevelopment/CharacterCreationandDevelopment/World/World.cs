using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    class World
    {
        public int monthNumber { get; private set; }
        public int year { get; private set; }

        public World()
        {
            monthNumber = 12;
            year = 1050;
        }

        public string NewTurn()
        {
            monthNumber++;
            if (monthNumber == 13)
            {
                monthNumber = 1;
                year++;
            }
            return GetMonth() + " " + year;
        }

        public string GetMonth()
        {
            switch(monthNumber)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
            }
            return "";
        }
    }
}
