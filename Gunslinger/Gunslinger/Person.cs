using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gunslinger
{
    public class Person
    {
        public bool isAlive;
        public bool isFriend;
        public string name;
        public bool diedThisTurn;
        public bool hasAmmo;

        public Person(bool isAlive, bool Friendly, string name)
        {
            this.isAlive = isAlive;
            this.isFriend = Friendly;
            this.name = name;
            this.diedThisTurn = false;
            this.hasAmmo = true;
        }
        
        public string TryAndShoot(Person TryAndShootTarget)
        {
            if (this.isAlive)
            {
                if (hasAmmo == true)
                {
                    return Shoot(TryAndShootTarget);
                }
                else
                {
                    return ShoutInsult(TryAndShootTarget);
                }
            }
            else
            {
                this.hasAmmo = false;
                return this.name + " is dead and can't shoot!" + Environment.NewLine;
            }
        }

        public string Shoot(Person target)
        {
            string report = "";
            this.hasAmmo = false;
            {
                if (Helper.nextRandomNumber(1, 50) >= 30)
                {
                    if (target.isAlive)
                    {
                        target.isAlive = false;
                        target.diedThisTurn = true;
                        report += this.name + " shoots and kills " + target.name + "."+ Environment.NewLine;
                        return report;
                    }
                    else
                    {
                        report += this.name + " shoots " + target.name + "'s corpse." + Environment.NewLine;
                        return report;
                    }
                    
                }
                else report += this.name + " misses " + target.name + "." + Environment.NewLine;
                return report;
            }
        }

        public string ShoutInsult(Person target)
        {
            string filepath = @"ListofInsults.txt";
            string[] insult = System.IO.File.ReadAllLines(filepath);


            return this.name + ": " + insult[Helper.nextRandomNumber(0, insult.Count())] + " at " + target.name + Environment.NewLine ;
        }
    }
}
