using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuizApp
{
    public partial class MainMenu : Form
    {
        private string username;

        public MainMenu()
        {
            InitializeComponent();
            this.username = "user";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void trackBarQuestions_Scroll(object sender, EventArgs e)
        {
            labelNumQuestions.Text = "Number of questions: " + trackBarQuestions.Value.ToString();
        }

        private void pbDevOps_MouseEnter(object sender, EventArgs e)
        {
            this.pbDevOps.Cursor = Cursors.Hand;
        }

        private void pbDevOps_MouseLeave(object sender, EventArgs e)
        {
            this.pbDevOps.Cursor = Cursors.Default;
        }

        private void pbDevOps_Click(object sender, EventArgs e)
        {
            QuizForm form = new QuizForm(trackBarQuestions.Value, "DevOps", username);
            form.ShowDialog();
        }

        private void pbLinux_MouseEnter(object sender, EventArgs e)
        {
            this.pbLinux.Cursor = Cursors.Hand;
        }

        private void pbLinux_MouseLeave(object sender, EventArgs e)
        {
            this.pbLinux.Cursor = Cursors.Default;
        }
        private void pbLinux_Click(object sender, EventArgs e)
        {
            QuizForm form = new QuizForm(trackBarQuestions.Value, "Linux", username);
            form.ShowDialog();
        }

        private void pbMixed_MouseEnter(object sender, EventArgs e)
        {
            this.pbMixed.Cursor = Cursors.Hand;
        }

        private void pbMixed_MouseLeave(object sender, EventArgs e)
        {
            this.pbMixed.Cursor = Cursors.Default;
        }

        private void pbMixed_Click(object sender, EventArgs e)
        {
            QuizForm form = new QuizForm(trackBarQuestions.Value, "", username);
            form.ShowDialog();
        }

        private void pbLeaderboard_MouseEnter(object sender, EventArgs e)
        {
            this.pbLeaderboard.Cursor = Cursors.Hand;

        }

        private void pbLeaderboard_MouseLeave(object sender, EventArgs e)
        {
            this.pbLeaderboard.Cursor = Cursors.Default;

        }

        private void pbLeaderboard_Click(object sender, EventArgs e)
        {
            Leaderboard.ShowLeaderboard();
        }

        private void txtBoxUsername_Enter(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text.Equals("Enter your username here"))
            {
                txtBoxUsername.Text = "";
                txtBoxUsername.ForeColor = System.Drawing.SystemColors.WindowText; 
            }

        }

        private void txtBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUsername.Text))
            {
                txtBoxUsername.Text = "Enter your username here";
                txtBoxUsername.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void btnUsername_Click(object sender, EventArgs e)
        {
            if(txtBoxUsername.Text.Equals("Enter your username here"))
            {
                username = "user";
            }
            else
            {
                username = txtBoxUsername.Text;
            }
            lblUsername.Text = $"Your username: {username}";
        }
    }
}