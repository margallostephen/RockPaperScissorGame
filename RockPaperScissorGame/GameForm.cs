using MySqlConnector;
using System.Data;

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
        public static string close;
        private int playerHP,
                    computerHP;

        private void StartBtn_Click(object sender, EventArgs e)
        {
            // Check if the user already entered a name
            if (!string.IsNullOrWhiteSpace(InputName.Text))
            {
                // Inserting player name to database
                try
                {
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
                    MessageForm warningMessage = new MessageForm("Sql", ex.Message.ToString());
                    warningMessage.ShowDialog();
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

        private void RockBtn_Click(object sender, EventArgs e)
        {

        }

        private void PaperBtn_Click(object sender, EventArgs e)
        {

        }

        private void ScissorBtn_Click(object sender, EventArgs e)
        {

        }

        private void PickBtn_Click(object sender, EventArgs e)
        {

        }

        private void PlayAgainBtn_Click(object sender, EventArgs e)
        {

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