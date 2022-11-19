namespace RockPaperScissorGame
{
    public partial class MessageForm : Form
    {
        public MessageForm(String info, String message)
        {
            InitializeComponent();

            Message.Text = message;

            if (info == "Name")
            {
                MessagePic.Image = Resource.Warning;
                MainBtn.BackColor = Color.Gold;
            }
            else if (info == "Sql")
            {
                
                MessagePic.Image = Resource.Error;
                MainBtn.BackColor = Color.Crimson;  

            }
            else if (info == "Pick")
            {
                MessagePic.Image = Resource.Alert;
                panel1.BackColor = panel2.BackColor = Color.DodgerBlue;
            }
            else
            {
                MessagePic.Image = Resource.Question;
                MainBtn.Hide();
            }

            if (info == "Sql" || info == "Exit")
                panel1.BackColor = panel2.BackColor = Color.Crimson;

            if (info == "Name" || info == "Sql" || info == "Pick")
            {
                YesBtn.Hide();
                NoBtn.Hide();
            }
        }

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
