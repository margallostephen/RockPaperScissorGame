namespace RockPaperScissorGame
{
    public partial class MessageForm : Form
    {
        public MessageForm(String info, String message)
        {
            InitializeComponent();

            Message.Text = message; // Display message

            // Set appearance base on the info
            if (info == "Name")
            {
                MessagePic.Image = Resource.Warning;
                CloseBtn.BackColor = Color.Gold;
            }
            else if (info == "Sql")
            {
                
                MessagePic.Image = Resource.Error;
                CloseBtn.BackColor = Color.Red;  

            }
            else if (info == "Pick")
            {
                MessagePic.Image = Resource.Alert;
                panel1.BackColor = panel2.BackColor = Color.DodgerBlue;
            }
            else
            {
                MessagePic.Image = Resource.Question;
                CloseBtn.Hide();
            }

            if (info == "Sql" || info == "Exit")
                panel1.BackColor = panel2.BackColor = Color.Red;

            if (info == "Name" || info == "Sql" || info == "Pick")
            {
                YesBtn.Hide();
                NoBtn.Hide();
            }
        }

        // Button Functions
        private void MainBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            GameForm.close = "Yes";
            this.Close();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            GameForm.close = "No";
            this.Close();
        }
    }
}
