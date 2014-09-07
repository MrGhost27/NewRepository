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
            imageList.Clear();
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

		public static string GetSaveFileName(PlayerCharacter player)
		{
			return @".\Saves\" + player.name + @"\" + player.name + " " + player.ageYears + "Y-" + player.ageMonths + "M.xml";
		}
        
        //Required for ComboBox - no idea who player is yet.
        public static string GetSaveFileName(string saveFileString)
        {
            return saveFileString + ".xml";
        }

		public static string GetWorldFileName(PlayerCharacter player)
		{
            return @".\Worlds\" + player.name + @"\" + player.name + " " + player.ageYears + "Y-" + player.ageMonths + "M.xml";
		}

        public static void SaveWorldDetailsToFile(PlayerCharacter player, World world)
        {
            var doc = new XDocument(
            new XElement("World",
            new XAttribute("ID", "001"),
            new XElement("Month", world.monthNumber),
            new XElement("Year", world.year),
            new XElement("Name", player.name),
			new XAttribute("Journal", "001"),
			new XElement("Entry", world.GetJournal())));

            string directory = @".\Worlds\" + player.name + @"\";
            Directory.CreateDirectory(directory);

            //Stolen Linq. Read how this works later :)
            var files = new DirectoryInfo(directory).EnumerateFiles()
            .OrderByDescending(f => f.CreationTime)
            .Skip(5)
            .ToList();
            files.ForEach(f => f.Delete());

            File.WriteAllText(GetWorldFileName(player), doc.ToString());
        }

        public static List<String> LoadWorldDetailsFromFile(PlayerCharacter player)
        {
            List<String> worldDetails = new List<String>();
            worldDetails.Clear();
            var doc = XDocument.Load(GetWorldFileName(player));
            string PlayerName = doc.Descendants("Name").Single().Value;
            worldDetails.Add(PlayerName);
            string Month = doc.Descendants("Month").Single().Value;
            worldDetails.Add(Month);
            string Year = doc.Descendants("Year").Single().Value;
            worldDetails.Add(Year);
			string Journal = doc.Descendants("Entry").Single().Value;
			worldDetails.Add(Journal);

            return worldDetails;
        }

        public static void SavePlayerDetailsToFile(PlayerCharacter player)
        {
            var doc = new XDocument(
            new XElement("Player",
            new XAttribute("ID", "001"),
            new XElement("Name", player.name),
            new XElement("Strength", player.strength),
            new XElement("Dexterity", player.dexterity),
            new XElement("Constitution", player.constitution),
            new XElement("Intelligence", player.intelligence),
            new XElement("Wisdom", player.wisdom),
            new XElement("Charisma", player.charisma),
            new XElement("Portrait", player.portraitNumber),
            new XElement("Weapons", player.weapons),
			new XElement("Unarmed", player.unarmed),
			new XElement("Swimming",player.swimming),
			new XElement("Athletics", player.athletics),
			new XElement("Diplomacy", player.diplomacy),
			new XElement("Survival", player.survival),
			new XElement("Crafting", player.crafting),
			new XElement("Faith", player.faith),
			new XElement("Lockpicking", player.lockpicking),
			new XElement("Pickpocketing", player.pickpocketing),
			new XElement("AnimalEmpathy", player.animalEmpathy),
			new XElement("Medicine", player.medicine),
            new XElement("Science", player.science),
			new XElement("AgeYears", player.ageYears),
			new XElement("AgeMonths", player.ageMonths)));

            string directory = @".\Saves\" + player.name + @"\";
            Directory.CreateDirectory(directory);

            //Stolen Linq. Read how this works later :)
            var files = new DirectoryInfo(directory).EnumerateFiles()
            .OrderByDescending(f => f.CreationTime)
            .Skip(9)
            .ToList();
            files.ForEach(f => f.Delete());
			File.WriteAllText(GetSaveFileName(player), doc.ToString());
        }
        

     
        public static PlayerCharacter LoadPlayerDetailsFromFile(string filename)
        {
            var doc = XDocument.Load(HelperClass.GetSaveFileName(filename));
            string PlayerName = doc.Descendants("Name").Single().Value;
            int strength = Int32.Parse(doc.Descendants("Strength").Single().Value);
            int dexterity = Int32.Parse(doc.Descendants("Dexterity").Single().Value);
            int constitution = Int32.Parse(doc.Descendants("Constitution").Single().Value);
            int intelligence = Int32.Parse(doc.Descendants("Intelligence").Single().Value);
            int wisdom = Int32.Parse(doc.Descendants("Wisdom").Single().Value);
            int charisma = Int32.Parse(doc.Descendants("Charisma").Single().Value);
            int portrait = Int32.Parse(doc.Descendants("Portrait").Single().Value);
            int weapons = Int32.Parse(doc.Descendants("Weapons").Single().Value);
			int unarmed = Int32.Parse(doc.Descendants("Unarmed").Single().Value);
			int swimming = Int32.Parse(doc.Descendants("Swimming").Single().Value);
			int athletics = Int32.Parse(doc.Descendants("Athletics").Single().Value);
			int diplomacy = Int32.Parse(doc.Descendants("Diplomacy").Single().Value);
			int survival = Int32.Parse(doc.Descendants("Survival").Single().Value);
			int crafting = Int32.Parse(doc.Descendants("Crafting").Single().Value);
			int faith = Int32.Parse(doc.Descendants("Faith").Single().Value);
			int lockpicking = Int32.Parse(doc.Descendants("Lockpicking").Single().Value);
			int pickpocketing = Int32.Parse(doc.Descendants("Pickpocketing").Single().Value);
			int animalEmpathy = Int32.Parse(doc.Descendants("AnimalEmpathy").Single().Value);
			int medicine = Int32.Parse(doc.Descendants("Medicine").Single().Value);
            int science = Int32.Parse(doc.Descendants("Science").Single().Value);
			int ageYears = Int32.Parse(doc.Descendants("AgeYears").Single().Value);
			int ageMonths = Int32.Parse(doc.Descendants("AgeMonths").Single().Value);
            //etc

            return new PlayerCharacter(PlayerName, strength, dexterity, constitution, intelligence, wisdom, charisma, portrait,
				weapons, unarmed, swimming, athletics, diplomacy, survival, crafting, faith, lockpicking, pickpocketing, 
				animalEmpathy, medicine, science, ageYears, ageMonths);
        }



        public static bool IsBetween(this int val, int low, int high, int previousval)
        {
			if (previousval > low && previousval < high)
			{
				return false;
			}

			return val > low && val < high;
        }
        
    }
}