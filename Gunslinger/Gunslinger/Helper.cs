using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gunslinger
{
    class Helper
    {
        static Random randomSeed = new Random();

        public static int nextRandomNumber(int min, int max)
        {
            return randomSeed.Next(min, max);
        }

        public static string RandomName()
        {
            /*Ensure you map this correctly in filepath. Also Ensure File properties has "embedded resource"
             * as the build action. Copy to Output directory if newer
             */

            string filepath = @"ListofNames.txt";
            string[] names = System.IO.File.ReadAllLines(filepath);


            return names[nextRandomNumber(0, names.Count())];
        }
    }
}
