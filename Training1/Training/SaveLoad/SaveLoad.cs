using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Training.SaveLoad
{
	public static class SaveLoad
	{
		internal static void SaveWorld(World world)
		{
			string directory = @".\Saves\";
			Directory.CreateDirectory(directory);

			XmlSerializer mySerializer = new XmlSerializer(typeof(World));
			using (StreamWriter myWriter = new StreamWriter(directory + world.Date()))
			{
				mySerializer.Serialize(myWriter, world);
			}
		}

		internal static World LoadWorld(string filename)
		{
			//string directory = @".\Saves\";
			XmlSerializer mySerializer = new XmlSerializer(typeof(World));
			World world = new World();
			using (FileStream myFileStream = new FileStream(filename, FileMode.Open))
			{
				world = (World)mySerializer.Deserialize(myFileStream);
			}
			return world;
		}
	}
}
