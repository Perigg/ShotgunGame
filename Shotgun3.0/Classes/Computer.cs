using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun3._0.Classes
{
    public class Computer
    {

        public int ComputerShots { get; set; }
        public string ComputerAction { get; set; }
        
        string[] computerActions;

        public Computer()
        {
            ComputerShots = 0;
            ComputerAction = "Action";
            
        }

        public void ComputerRandomAction()
        {
            
            Random random = new Random();
            
            if (ComputerShots == 0)
            {
                computerActions = new string[] { "Load" };
            }
            else if (ComputerShots >= 1 && ComputerShots < 3)
            {
                computerActions = new string[] { "Load", "Block", "Shoot", "Load" };
            }
            else if (ComputerShots >= 3)
            {
                computerActions = new string[] { "Shotgun" };
            }
            int randomIndex = random.Next(computerActions.Length);
            ComputerAction = computerActions[randomIndex];
        }

       
    }
}
