namespace TicTacToe
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hui");
            this.Hide();
            GameForm gameForm = new();
            gameForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}