using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun3._0.Classes
{
    public class Player
    {
        public int PlayerShots { get; set; }
        public string PlayerAction { get; set; }
        

        public Player()
        {
            PlayerShots = 0;
            PlayerAction = "Action";
           
        }
        public void PlayerShoots()
        {
                PlayerShots--;
                PlayerAction = "Shoot";
            
        }

        public void PlayerBlocks()
        {
            PlayerAction = "Block";
        }

        public void PlayerLoads()
        {
            PlayerShots++;
            PlayerAction = "Load";
        }
        public void PlayerShotgun() 
        {
            PlayerShots = PlayerShots - 3;
            PlayerAction = "Shotgun";
        }
    }
}
