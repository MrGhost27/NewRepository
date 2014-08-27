using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

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

        public static void SavePlayerDetailsToFile(string filename, Character_Creation CreationScreen)
        {
            var doc = new XDocument(
            new XElement("Player",
            new XAttribute("ID", "001"),
            new XElement("Name", CreationScreen._name),
            new XElement("Strength", CreationScreen._strength),
            new XElement("Dexterity", CreationScreen._dexterity),
            new XElement("Constitution", CreationScreen._consitution),
            new XElement("Intelligence", CreationScreen._intelligence),
            new XElement("Wisdom", CreationScreen._wisdom),
            new XElement("Charisma", CreationScreen._charisma),
            new XElement("Image", CreationScreen.imageNumber)));

            File.WriteAllText(filename + ".xml", doc.ToString());
        }
        

     
        public static void LoadPlayerDetailsFromFile(string filename)
        {
            var doc = XDocument.Load(filename + ".xml");
            string PlayerName = doc.Descendants("Name").Single().Value;
            string Strength = doc.Descendants("Strength").Single().Value;
            //etc
            Console.WriteLine("Player Name = " + PlayerName);
        }
        

        
    }
}