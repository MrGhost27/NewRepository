using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    class Months
    {
        private List<String> listOfMonths;
        public Months()
        {
            listOfMonths = new List<String>();
            listOfMonths.Add("January");
            listOfMonths.Add("February");
            listOfMonths.Add("March");
            listOfMonths.Add("April");
            listOfMonths.Add("May");
            listOfMonths.Add("June");
            listOfMonths.Add("July");
            listOfMonths.Add("August");
            listOfMonths.Add("September");
            listOfMonths.Add("October");
            listOfMonths.Add("November");
            listOfMonths.Add("December");
        }

        public string GetMonth(int monthNumber)
        {
            return listOfMonths[monthNumber];
        }
    }
}
