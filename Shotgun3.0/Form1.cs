using Shotgun3._0.Classes;

namespace Shotgun3._0

{
    public partial class Form1 : Form
    {

        private Game game;

        public Form1()
        {
            InitializeComponent();

            
            game = new Game();
            btnShotgun.Enabled = false;


        }

        public void PlayerActionLabel()
        {
            lblPlayerAction.Text = game.Player.PlayerAction.ToString();
        }
        public void PlayerShotsLabel()
        {
            lblPlayerShots.Text = game.Player.PlayerShots.ToString();
        }
        public void ComputerActionLabel()
        {
            lblComputerAction.Text = game.Computer.ComputerAction.ToString();
        }
        public void ComputerShotsLabel()
        {
            lblComputerShots.Text = game.Computer.ComputerShots.ToString();
        }




        private async void btnLoad_Click(object sender, EventArgs e)
        {
            game.Player.PlayerLoads();
            PlayerActionLabel();
            PlayerShotsLabel();

            if (game.Player.PlayerShots >= 3)
            {
                btnShotgun.Enabled = true;
            }
            await Task.Delay(1000);
            game.Computer.ComputerRandomAction();
            ComputerActionLabel();
            game.GameMechanics();
            ComputerShotsLabel();
        }

        private async void btnShoot_Click(object sender, EventArgs e)
        {
            if (game.Player.PlayerShots > 0)
            {

                game.Player.PlayerShoots();
                PlayerActionLabel();
                PlayerShotsLabel();
                await Task.Delay(1000);
                game.Computer.ComputerRandomAction();
                ComputerActionLabel();
                game.GameMechanics();
                ComputerShotsLabel();

                if (game.Player.PlayerShots < 3)
                {
                    btnShotgun.Enabled = false;
                }
            }
        }

        private async void btnBlock_Click(object sender, EventArgs e)
        {
            game.Player.PlayerBlocks();
            PlayerActionLabel();
            PlayerShotsLabel();
            await Task.Delay(1000);
            game.Computer.ComputerRandomAction();
            ComputerActionLabel();
            game.GameMechanics();
            ComputerShotsLabel();
        }

        private async void btnShotgun_Click(object sender, EventArgs e)
        {

            game.Player.PlayerShotgun();
            PlayerActionLabel();
            PlayerShotsLabel();
            await Task.Delay(1000);
            game.GameMechanics();
            ComputerActionLabel();
            ComputerShotsLabel();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}