﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    static class HelperClass
    {
        private static Random random = new Random();
        private static List<Image> imageList = new List<Image>();

        public static List<Image> Images(int gender)
        {
			string imageDirectory = "";
			switch(gender)
			{
				case 0:
					imageDirectory = @"Images\Female";
					break;
				case 1: 
					imageDirectory = @"Images\Male";
					break;
				case 2:
					imageDirectory = @"Images\Other";
                    break;
                case 3:
                    imageDirectory = @"Images\Relationships";
					break;
			}

            string[] images = System.IO.Directory.GetFiles(imageDirectory);
            imageList.Clear();
            foreach (string Img in images)
            {
                Bitmap bmp = new Bitmap(Img);
                imageList.Add(bmp);
            }
            return imageList;
        }

        public static string RandomName(int gender)
        {
            /*Ensure you map this correctly in filepath. Also Ensure File properties has "embedded resource"
             * as the build action. Copy to Output directory if newer
             */
			string filepath = "";
			switch(gender)
			{
				case 0:
					filepath = @"HelperClass\ListOfFemaleNames.txt";
					break;
				case 1:
					filepath = @"HelperClass\ListOfMaleNames.txt";
					break;
			}
            string[] names = System.IO.File.ReadAllLines(filepath);
            return names[GenerateRandomNumber(1, names.Count())];
        }

        public static int GenerateRandomNumber(int min, int max)
        {
            int randomNumber = random.Next(min, max);
            return randomNumber;
        }

		public static bool IsBetween(this int val, int low, int high, int previousval)
        {
			if (previousval > low && previousval < high)
			{
				return false;
			}

			return val > low && val < high;
        }

		public static int SetMoodBoundaries(int mood)
		{
			if (mood > 100)
			{
				mood = 100;
			}
			if (mood < -100)
			{
				mood = -100;
			}
			return mood;
		}
    }
}