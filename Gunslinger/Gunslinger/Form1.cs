using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gunslinger
{
    public partial class Form1 : Form
    {
         List<Person> friendlyList;
         List<Person> enemyList;
         Person player;
         Person enemy;
         Person bystander;
         Person cockmuncher;
         int TurnCount;
         bool continueTurn;
         bool friendsDoneShooting;
         bool enemyDoneShooting;
            
        public Form1()
        {
            friendlyList = new List<Person>();
            enemyList = new List<Person>();
            player = new Person(true, true, "Goodie");
            enemy = new Person(true, false, "Baddie");
            bystander = new Person(true, true, "Innocent Bystander");
            cockmuncher = new Person(true, false, "Cock Muncher");

            friendlyList.Add(player);
            friendlyList.Add(bystander);
            enemyList.Add(enemy);
            enemyList.Add(cockmuncher);

            continueTurn = false;
            friendsDoneShooting = false;
            enemyDoneShooting = false;

            TurnCount = 0;

            InitializeComponent();

            RefreshFormList();
        }

        public void RefreshFormList()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            foreach (Person personfromlist in friendlyList)
            {
                if (personfromlist.isAlive)
                {
                    textBox2.AppendText(personfromlist.name + " (Alive)." + Environment.NewLine);
                }
                else
                {
                    textBox2.AppendText(personfromlist.name + " (Dead)." + Environment.NewLine);
                }
            }

            foreach (Person personfromlist in enemyList)
            {
                if (personfromlist.isAlive)
                {
                    textBox3.AppendText(personfromlist.name + " (Alive)." + Environment.NewLine);
                }
                else
                {
                    textBox3.AppendText(personfromlist.name + " (Dead)." + Environment.NewLine);
                }
            }
        }


        public void FriendStartsShooting()
        {
            int iFriend = Helper.nextRandomNumber(0, friendlyList.Count());
            int iEnemy = Helper.nextRandomNumber(0, enemyList.Count());
            Person proposedShooter = friendlyList[iFriend];
            textBox1.AppendText(proposedShooter.TryAndShoot(enemyList[iEnemy]));
        }

        public void EnemyStartsShooting()
        {
            int iFriend = Helper.nextRandomNumber(0, friendlyList.Count());
            int iEnemy = Helper.nextRandomNumber(0, enemyList.Count());
            Person proposedShooter = enemyList[iEnemy];
            textBox1.AppendText(proposedShooter.TryAndShoot(friendlyList[iFriend]));
        }

        public bool EachSideShoots()
        {
            while ((!friendsDoneShooting) || (!enemyDoneShooting))
            {

                int numberOfShotsLeft = 0;
                foreach (Person lastShooter in friendlyList)
                {
                    if (lastShooter.hasAmmo)
                    {
                        numberOfShotsLeft++;
                    }
                }
                if (numberOfShotsLeft > 0)
                {
                    FriendStartsShooting();
                    numberOfShotsLeft = 0;
                }
                else if (numberOfShotsLeft == 0)
                {
                    friendsDoneShooting = true;
                    textBox1.AppendText("The friendly side has fired all their shots!" + Environment.NewLine);
                }

                foreach (Person lastShooter in enemyList)
                {
                    if (lastShooter.hasAmmo)
                    {
                        numberOfShotsLeft++;
                    }
                }
                if (numberOfShotsLeft > 0)
                {
                    EnemyStartsShooting();
                    numberOfShotsLeft = 0;
                }
                else if (numberOfShotsLeft == 0)
                {
                    textBox1.AppendText("The enemy side has fired all their shots!" + Environment.NewLine);
                    enemyDoneShooting = true;
                }

                if ((friendsDoneShooting) && (enemyDoneShooting))
                {
                    textBox1.AppendText("Both sides have finished shooting!" + Environment.NewLine);
                    return true;
                }
                else return false;
            }
            return true;
        }

        public void CheckForVictory()
        {
            int friendliesAlive = 0;
            int enemiesAlive = 0;

            foreach (Person living in friendlyList)
            {
                if (living.isAlive)
                { friendliesAlive++; }
            }
            foreach (Person living in enemyList)
            {
                if (living.isAlive)
                { enemiesAlive++; }
            }
            if (enemiesAlive == 0)
            {
                MessageBox.Show("Take That Forces of Evil!!! (You Win!)");
            }
            if (friendliesAlive == 0)
            {
                MessageBox.Show("Today is a good day to die... I guess... (You Lose!)");
            }
        }

        public void CheckWhoDied()
        {
            foreach (Person freshCorpse in friendlyList)
            {
                if (freshCorpse.diedThisTurn)
                {
                    textBox4.AppendText(freshCorpse.name + " died on turn " + TurnCount + "." + Environment.NewLine);
                    freshCorpse.diedThisTurn = false;
                }
            }
            foreach (Person freshCorpse in enemyList)
            {
                if (freshCorpse.diedThisTurn)
                {
                    textBox4.AppendText(freshCorpse.name + " died on turn " + TurnCount + "." + Environment.NewLine);
                    freshCorpse.diedThisTurn = false;
                }
            }
        }

        public void ReloadAmmo()
        {
            foreach (Person loader in friendlyList)
            {
                if (loader.isAlive)
                {
                    loader.hasAmmo = true;
                }
            }
            foreach (Person loader in enemyList)
            {
                if (loader.isAlive)
                {
                    loader.hasAmmo = true;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //int i = Helper.nextRandomNumber(0, enemyList.Count());
            //Person ChosenEnemy = enemyList[i];
            //int i2 = Helper.nextRandomNumber(0, friendlyList.Count());
            //Person ChosenFriend = friendlyList[i2];

            TurnCount++;
            textBox1.Text = "Turn: " + TurnCount + Environment.NewLine;

            while (continueTurn == false)
            {
                continueTurn = EachSideShoots();
            }


            //textBox1.AppendText(player.TryAndShoot(ChosenEnemy));
            //textBox1.AppendText(enemy.TryAndShoot(ChosenFriend));
            //textBox1.AppendText(bystander.TryAndShoot(ChosenEnemy));
            //textBox1.AppendText(cockmuncher.TryAndShoot(ChosenFriend));
            //checkBox1.Checked = player.isAlive;
            //checkBox2.Checked = enemy.isAlive;

            RefreshFormList();
            

            CheckWhoDied();
            CheckForVictory();
            friendsDoneShooting = false;
            enemyDoneShooting = false;
            continueTurn = false;
            ReloadAmmo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person NewFriend = new Person(true, true, Helper.RandomName());
            friendlyList.Add(NewFriend);
            RefreshFormList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Person NewEnemy = new Person(true, false, Helper.RandomName());
            enemyList.Add(NewEnemy);
            RefreshFormList();
        }
    }
}
