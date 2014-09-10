using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CharacterCreationandDevelopment
{
	public static class SaveLoad
	{

		#region Relationship

		public static void SaveRelationshipsToFile(PlayerCharacter player, List<Relationship> listOfRelationships)
		{
			var doc = new XDocument(
				new XElement("Root",
				from relationship in listOfRelationships
				select
					new XElement("Relationship",
					new XElement("name", relationship.name),
					new XElement("OpinionOfPlayer", relationship.opinionofPlayer)))
			);

			string directory = @".\Saves\" + player.name + @"\Relationships\";
			Directory.CreateDirectory(directory);
			CheckSetMaxSaves(directory);
			File.WriteAllText(GetRelationshipFileName(player), doc.ToString());
		}

		/*public static List<Relationship> LoadRelationshipsFromFile(PlayerCharacter player)
		{
			var doc = XDocument.Load(GetRelationshipFileName(player));
			List<Relationship> listOfRelationships = new List<Relationship>();
		}*/



		public static string GetRelationshipFileName(PlayerCharacter player)
		{
			return @".\Saves\" + player.name + @"\Relationships\" + player.name + " " + player.ageYears + "Y-" + player.ageMonths + "M.xml";
		}

		#endregion

		#region Story Progression

		public static void SaveStoryProgressionToFile(PlayerCharacter player, StoryProgression storyProgression)
		{
			var doc = new XDocument(
			new XElement("StoryProgression",
			new XAttribute("ID", "001"),
			new XElement("FirstConversation", storyProgression.firstConversation)));

			string directory = @".\Saves\" + player.name + @"\Story\";
			Directory.CreateDirectory(directory);
			CheckSetMaxSaves(directory);
			File.WriteAllText(GetStoryFileName(player), doc.ToString());
		}

		public static StoryProgression LoadStoryProgressionFromFile(PlayerCharacter player)
		{
			var doc = XDocument.Load(GetStoryFileName(player));
			bool firstConversation = Boolean.Parse(doc.Descendants("FirstConversation").Single().Value);
			return new StoryProgression(firstConversation);
		}

		public static string GetStoryFileName(PlayerCharacter player)
		{
			return @".\Saves\" + player.name + @"\Story\" + player.name + " " + player.ageYears + "Y-" + player.ageMonths + "M.xml";
		}
		#endregion

		#region World

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

			string directory = @".\Saves\" + player.name + @"\World\";
			Directory.CreateDirectory(directory);
			CheckSetMaxSaves(directory);
			File.WriteAllText(GetWorldFileName(player), doc.ToString());
		}

		public static World LoadWorldDetailsFromFile(PlayerCharacter player)
		{
			var doc = XDocument.Load(GetWorldFileName(player));
			string playerName = doc.Descendants("Name").Single().Value;
			int month = Int32.Parse(doc.Descendants("Month").Single().Value);
			int year = Int32.Parse(doc.Descendants("Year").Single().Value);
			string journal = doc.Descendants("Entry").Single().Value;

			return new World(player, month, year, journal);
		}

		public static string GetWorldFileName(PlayerCharacter player)
		{
			return @".\Saves\" + player.name + @"\World\" + player.name + " " + player.ageYears + "Y-" + player.ageMonths + "M.xml";
		}

		#endregion

		#region Player

		public static void SavePlayerDetailsToFile(PlayerCharacter player)
		{
			var doc = new XDocument(
			new XElement("Player",
			new XAttribute("ID", "001"),
			new XElement("Name", player.name),
			new XElement("Gender", player.gender),
			new XElement("Location", player.location),
			new XElement("Strength", player.strength),
			new XElement("Dexterity", player.dexterity),
			new XElement("Constitution", player.constitution),
			new XElement("Intelligence", player.intelligence),
			new XElement("Wisdom", player.wisdom),
			new XElement("Charisma", player.charisma),
			new XElement("Portrait", player.portraitNumber),
			new XElement("Weapons", player.weapons),
			new XElement("Unarmed", player.unarmed),
			new XElement("Swimming", player.swimming),
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
			new XElement("AgeMonths", player.ageMonths),
			new XElement("HappyDepressed", player.happyDepressed),
			new XElement("AngryAfraid", player.angryAfraid),
			new XElement("ExcitedBored", player.excitedBored),
			new XElement("LogicalCrazy", player.logicalCrazy)));

			string directory = @".\Saves\" + player.name + @"\Player\";
			Directory.CreateDirectory(directory);
			CheckSetMaxSaves(directory);
			File.WriteAllText(GetSaveFileName(player), doc.ToString());
		}



		public static PlayerCharacter LoadPlayerDetailsFromFile(string filename)
		{
			var doc = XDocument.Load(filename);
			string PlayerName = doc.Descendants("Name").Single().Value;
			int gender = Int32.Parse(doc.Descendants("Gender").Single().Value);
			string location = doc.Descendants("Location").Single().Value;
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
			int happyDepressed = Int32.Parse(doc.Descendants("HappyDepressed").Single().Value);
			int angryAfraid = Int32.Parse(doc.Descendants("AngryAfraid").Single().Value);
			int excitedBored = Int32.Parse(doc.Descendants("ExcitedBored").Single().Value);
			int logicalCrazy = Int32.Parse(doc.Descendants("LogicalCrazy").Single().Value);
			//etc

			return new PlayerCharacter(PlayerName, gender, location, strength, dexterity, constitution, intelligence, wisdom, charisma, portrait,
				weapons, unarmed, swimming, athletics, diplomacy, survival, crafting, faith, lockpicking, pickpocketing,
				animalEmpathy, medicine, science, ageYears, ageMonths, happyDepressed, angryAfraid, excitedBored, logicalCrazy);
		}

		public static string GetSaveFileName(PlayerCharacter player)
		{
			return @".\Saves\" + player.name + @"\Player\" + player.name + " " + player.ageYears + "Y-" + player.ageMonths + "M.xml";
		}

		#endregion

		private static void CheckSetMaxSaves(string directory)
		{
			//Stolen Linq. Read how this works later :)
			var files = new DirectoryInfo(directory).EnumerateFiles()
			.OrderByDescending(f => f.CreationTime)
			.Skip(9)
			.ToList();
			files.ForEach(f => f.Delete());
		}
	}
}
