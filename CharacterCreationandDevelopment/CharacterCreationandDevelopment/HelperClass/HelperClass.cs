using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    static class HelperClass
    {
        private static Random random = new Random();
        private static List<Image> imageList = new List<Image>();

        public static List<Image> Images()
        {
            string[] images = System.IO.Directory.GetFiles(@"Images");
            foreach (string Img in images)
            {
                Bitmap bmp = new Bitmap(Img);
                imageList.Add(bmp);
            }
            return imageList;
        }

        public static string RandomName()
        {
            /*Ensure you map this correctly in filepath. Also Ensure File properties has "embedded resource"
             * as the build action. Copy to Output directory if newer
             */

            string filepath = @"HelperClass\ListOfNames.txt";
            string[] names = System.IO.File.ReadAllLines(filepath);

            return names[GenerateRandomNumber(1, names.Count())];

        }

        public static int GenerateRandomNumber(int min, int max)
        {
            int randomNumber = random.Next(min, max);
            return randomNumber;
        }

        public static string RandomCityName()
        {
            string filepath = @"HelperClass\ListOfCities.txt";
            string[] cityNames = System.IO.File.ReadAllLines(filepath);

            return cityNames[GenerateRandomNumber(1, cityNames.Count())];
        }
    }
}