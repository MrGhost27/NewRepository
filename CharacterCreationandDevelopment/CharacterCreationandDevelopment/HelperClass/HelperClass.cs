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

        public static void SavePlayerDetailsToFile(PlayerCharacter Player)
        {
            var doc = new XDocument(
            new XElement("Player",
            new XAttribute("ID", "001"),
            new XElement("Name", Player.name),
            new XElement("Strength", Player.strength),
            new XElement("Dexterity", Player.dexterity),
            new XElement("Constitution", Player.constitution),
            new XElement("Intelligence", Player.intelligence),
            new XElement("Wisdom", Player.wisdom),
            new XElement("Charisma", Player.charisma),
            new XElement("Portrait", Player.portraitNumber)));
            Directory.CreateDirectory(@".\Saves\");
            File.WriteAllText(@".\Saves\" + Player.name + ".xml", doc.ToString());
        }
        

     
        public static PlayerCharacter LoadPlayerDetailsFromFile(string filename)
        {
            var doc = XDocument.Load(@".\Saves\" + filename + ".xml");
            string PlayerName = doc.Descendants("Name").Single().Value;
            int strength = Int32.Parse(doc.Descendants("Strength").Single().Value);
            int dexterity = Int32.Parse(doc.Descendants("Dexterity").Single().Value);
            int constitution = Int32.Parse(doc.Descendants("Constitution").Single().Value);
            int intelligence = Int32.Parse(doc.Descendants("Intelligence").Single().Value);
            int wisdom = Int32.Parse(doc.Descendants("Wisdom").Single().Value);
            int charisma = Int32.Parse(doc.Descendants("Charisma").Single().Value);
            int portrait = Int32.Parse(doc.Descendants("Portrait").Single().Value);

            //etc

            return new PlayerCharacter(PlayerName, strength, dexterity, constitution, intelligence, wisdom, charisma, portrait);
        }
        

        
    }
}