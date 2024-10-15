using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun3._0.Classes
{
    
    public class Game
    {


        public Computer Computer;
        public Player Player;
        public bool win;

        public Game()
        {
            Player = new Player();
            Computer = new Computer();
            

        }

        
        public void GameMechanics()
        {
           

            if (Player.PlayerAction == "Load")
            {

                switch (Computer.ComputerAction)
                {
                    case "Load":
                        
                        Computer.ComputerShots++;
                        break;
                    case "Block":
                      
                        break;
                    case "Shoot":
                      
                        Computer.ComputerShots--;
                        win = false;
                        GameOver();
                        break;
                    case "Shotgun":
                       
                        Computer.ComputerShots = Computer.ComputerShots - 3;
                        win = false;
                        GameOver();
                        break;
                }
            }
            else if (Player.PlayerAction == "Shoot")
            {

                switch(Computer.ComputerAction)
                {
                    case "Load":
                        
                        win = true;
                        GameOver();
                        break;
                    case "Shoot":
                       
                        Computer.ComputerShots--;
                        break;
                    case "Block":
                        
                        break;
                    case "Shotgun":
                      
                        Computer.ComputerShots = Computer.ComputerShots - 3;
                        win = false;
                        GameOver();
                        break;
                }
            }
            else if (Player.PlayerAction == "Block")
            {
                
                switch (Computer.ComputerAction)
                {
                    case "Load":
                        
                        Computer.ComputerShots++;
                        break;
                    case "Shoot":
                      
                        Computer.ComputerShots--;
                        break;
                    case "Block":
                       
                        break;
                    case "Shotgun":
                        Computer.ComputerShots = Computer.ComputerShots - 3;
                        win = false;
                        GameOver();
                        break;
                }
            }
            else if (Player.PlayerAction == "Shotgun")
            {

                win = true;
                GameOver();
            }

        }
        public void GameOver()
        {
            
            if (win)
            {
                DialogResult result = MessageBox.Show("Congratulation, you WON\nDo you want to play again?", "Game Over", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else if (!win)
            {

                DialogResult result = MessageBox.Show("You loose.\nDo you want to play again?", "Game Over", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }

            }
            
        }
        
        


    }
    
}
