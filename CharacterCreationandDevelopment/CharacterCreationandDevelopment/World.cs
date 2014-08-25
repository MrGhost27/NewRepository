using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public class World
    {
        private string Year;
        private string Month;
        private PlayerCharacter player;
        
        public World(PlayerCharacter playerInWorld)
        {
            this.player = playerInWorld;
        }

    }
}
