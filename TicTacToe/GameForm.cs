using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameForm : Form
    {
        private int player; 
        private int steps; 
        public GameForm()
        {
            InitializeComponent();
            player = 1; 
            steps = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    player = 0;
                    steps++;
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "O");
                    player = 1;
                    steps++;
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            isWinner();
        }
        private void isWinner()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                MessageBox.Show(button1.Text + "'s victory");
                this.Hide();
                mainMenu mainmenu = new();
                mainmenu.Show();

            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                MessageBox.Show(button5.Text + "'s victory");
                this.Hide();
                mainMenu mainmenu = new();
                mainmenu.Show();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show(button7.Text + "'s victory");
                this.Hide();
                mainMenu mainmenu = new();
                mainmenu.Show();
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                MessageBox.Show(button7.Text + "'s victory");
                this.Hide();
                mainMenu mainmenu = new();
                mainmenu.Show();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                MessageBox.Show(button2.Text + "'s victory");
                this.Hide();
                mainMenu mainmenu = new();
                mainmenu.Show();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                MessageBox.Show(button3.Text + "'s victory");
                this.Hide();
                mainMenu mainmenu = new();
                mainmenu.Show();
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                MessageBox.Show(button9.Text + "'s victory");
                this.Hide();
                mainMenu mainmenu = new();
                mainmenu.Show();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                MessageBox.Show(button7.Text + "'s victory");
                this.Hide();
                mainMenu mainmenu = new();
                mainmenu.Show();
            }
            if (steps == 9)
            {
                MessageBox.Show("Draw");
                this.Hide();
                mainMenu mainmenu = new();
                mainmenu.Show();
                steps = 0;
            }
        }
    }
}
