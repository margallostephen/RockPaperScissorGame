using MySqlConnector;

namespace RockPaperScissorGame
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            StartPanel.Show();
            GamePanel.Hide();
            EndPanel.Hide();
            this.FormClosing += GameForm_FormClosing;
        }

        readonly private MySqlConnection connection = new MySqlConnection("Server=localhost;Database=pick_game;User=root;Password=password;");
        readonly private Random random = new Random();
        public static string close = "";
        private int playerPick = -1,
                    computerPick,
                    playerHP,
                    computerHP;

        private void StartBtn_Click(object sender, EventArgs e)
        {
            // Check if the user already entered a name
            if (!string.IsNullOrWhiteSpace(InputName.Text))
            {
                try
                {
                    // Inserting player name to database
                    connection.Open();
                    var insertRecord = new MySqlCommand("INSERT INTO game_record (`player_name`, `player_hp`, `computer_hp`) " +
                        "VALUES('" + InputName.Text.Trim() + "', '" + 100 + "', '" + 100 + "');", connection);
                    insertRecord.ExecuteNonQuery();

                    // Displaying the player name to the label
                    var getData = new MySqlCommand("SELECT player_name, player_hp, computer_hp FROM game_record ORDER BY game_id DESC LIMIT 1;", connection);
                    var reader = getData.ExecuteReader();
                    reader.Read();
                    PlayerName.Text = reader.GetString(0);
                    playerHP = computerHP = reader.GetInt32(1);
                    PlayerHL.Text = playerHP + " HP";
                    ComputerHL.Text = computerHP + " HP";
                    connection.Close();

                    // Redirect the player to the game panel
                    GamePanel.Show();
                    StartPanel.Hide();
                }
                catch (Exception ex)
                {
                    MessageForm errorMessage = new MessageForm("Sql", ex.Message.ToString());
                    errorMessage.ShowDialog();
                }
            }
            else
            {
                // Display error message
                MessageForm warningMessage = new MessageForm("Name", "Please enter a player name first.");
                warningMessage.ShowDialog();
            }

            InputName.Text = "";
        }

        // Buttons for players pick
        private void RockBtn_Click(object sender, EventArgs e)
        {
            playerPick = 0;
            PickBtn.BackColor = RockBtn.BackColor = Color.LimeGreen;
            PaperBtn.BackColor = ScissorBtn.BackColor = Color.DodgerBlue;
        }

        private void PaperBtn_Click(object sender, EventArgs e)
        {
            playerPick = 1;
            PickBtn.BackColor = PaperBtn.BackColor = Color.LimeGreen;
            RockBtn.BackColor = ScissorBtn.BackColor = Color.DodgerBlue;
        }

        private void ScissorBtn_Click(object sender, EventArgs e)
        {
            playerPick = 2;
            PickBtn.BackColor = ScissorBtn.BackColor = Color.LimeGreen;
            RockBtn.BackColor = PaperBtn.BackColor = Color.DodgerBlue;
        }

        // Function for displaying image
        private void DisplayPickedImage(int pick, PictureBox picBox)
        {
            if (pick == 0)
                if (picBox == PlayerPicBox)
                    picBox.Image = Resource.RockLeft;
                else
                    picBox.Image = Resource.Rock;
            else if (pick == 1)
                if (picBox == PlayerPicBox)
                    picBox.Image = Resource.PaperGreen;
                else
                    picBox.Image = Resource.PaperLeft;
            else
                picBox.Image = Resource.Scissor;
        }

        // Function for decreasing health
        private void DecreasedHealth(String who)
        {
            // Check all of the panel background image if its not null it will be remove
            if (Controls.Find(who + "H1", true)[0].BackgroundImage != null)
                Controls.Find(who + "H1", true)[0].BackgroundImage = null;
            else if (Controls.Find(who + "H2", true)[0].BackgroundImage != null)
                Controls.Find(who + "H2", true)[0].BackgroundImage = null;
            else if (Controls.Find(who + "H3", true)[0].BackgroundImage != null)
                Controls.Find(who + "H3", true)[0].BackgroundImage = null;
            else if (Controls.Find(who + "H4", true)[0].BackgroundImage != null)
                Controls.Find(who + "H4", true)[0].BackgroundImage = null;
            else
                Controls.Find(who + "H5", true)[0].BackgroundImage = null;

            // Decreased the health of the player or computer and display it to the label
            if (who == "Player")
            {
                playerHP -= 20;
                PlayerHL.Text = playerHP.ToString() + " HP";
            }
            else
            {
                computerHP -= 20;
                ComputerHL.Text = computerHP.ToString() + " HP";
            }
        }

        // Button for showing player and computer pick
        private void PickBtn_Click(object sender, EventArgs e)
        {
            // Check if the player already pick from rock, paper, or scissors
            if (playerPick != -1)
            {
                // Display the image of player and computer pick
                DisplayPickedImage(playerPick, PlayerPicBox);

                computerPick = random.Next(3);

                DisplayPickedImage(computerPick, ComputerPicBox);

                // Decrease health base on the pick of the player and computer
                if (playerPick == 0)
                {
                    if (computerPick == 1) DecreasedHealth("Player");

                    if (computerPick == 2) DecreasedHealth("Computer");
                }
                else if (playerPick == 1)
                {
                    if (computerPick == 0) DecreasedHealth("Computer");

                    if (computerPick == 2) DecreasedHealth("Player");
                }
                else
                {
                    if (computerPick == 0) DecreasedHealth("Player");

                    if (computerPick == 1) DecreasedHealth("Computer");
                }

                playerPick = -1; // Reset the player pick
                PickBtn.BackColor = RockBtn.BackColor = PaperBtn.BackColor = ScissorBtn.BackColor = Color.DodgerBlue;

                // Check if the game is finish
                if (playerHP == 0 || computerHP == 0)
                {
                    String result; // Storage for the result of the game

                    if (playerHP == 0)
                    {
                        result = "Lose";
                        EndPicBox.Image = Resource.Lose;
                    }
                    else
                    {
                        result = "Win";
                        EndPicBox.Image = Resource.Win;
                    }

                    // Update the result of the current game
                    connection.Open();
                    var updateRecord = new MySqlCommand(
                        "UPDATE game_record SET result='" + result + "', player_hp=" + playerHP + ", computer_hp=" + computerHP + " WHERE game_id IN (SELECT game_id " +
                        "FROM (SELECT game_id FROM game_record ORDER BY game_id DESC LIMIT 1) tbl_game_record);", connection);
                    updateRecord.ExecuteNonQuery();
                    connection.Close();

                    Task.Delay(1500).Wait();
                    EndPanel.Show();
                    GamePanel.Hide();
                }
            }
            else
            {
                // Display error message
                MessageForm alertMessage = new MessageForm("Pick", "Choose between rock, paper, or scissors first.");
                alertMessage.ShowDialog();
            }
        }

        private void PlayAgainBtn_Click(object sender, EventArgs e)
        {
            // Reseting the health label
            playerHP = computerHP = 100;
            PlayerHL.Text = ComputerHL.Text = "100 HP";

            // Reseting the health bar of player and computer
            PlayerH1.BackgroundImage = PlayerH2.BackgroundImage =
            PlayerH3.BackgroundImage = PlayerH4.BackgroundImage =
            PlayerH5.BackgroundImage = Resource.HeartBlack;

            ComputerH1.BackgroundImage = ComputerH2.BackgroundImage =
            ComputerH3.BackgroundImage = ComputerH4.BackgroundImage =
            ComputerH5.BackgroundImage = Resource.HeartGreen;

            // Removing the image in two picture box 
            PlayerPicBox.Image = ComputerPicBox.Image = null;

            // Redirect the user to the start panel
            StartPanel.Show();
            EndPanel.Hide();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageForm exitMessage = new MessageForm("Exit", "Do you really want to exit the game?");
            exitMessage.ShowDialog();

            if (close == "Yes") 
                e.Cancel = false;
        }
    }
}