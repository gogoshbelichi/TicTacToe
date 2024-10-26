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
        public GameForm()
        {
            InitializeComponent();
            player = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    player = 0;
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "O");
                    player = 1;
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            isWinner();
        }
        private void isWinner()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show(button1.Text + "'s victory");
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text != "")
                    MessageBox.Show(button5.Text + "'s victory");
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text != "")
                    MessageBox.Show(button7.Text + "'s victory");
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button7.Text != "")
                    MessageBox.Show(button7.Text + "'s victory");
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text != "")
                    MessageBox.Show(button7.Text + "'s victory");
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show(button9.Text + "'s victory");
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button5.Text != "")
                    MessageBox.Show(button9.Text + "'s victory");
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show(button7.Text + "'s victory");
            }
        }
    }
}
