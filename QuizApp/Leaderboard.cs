using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Leaderboard : Form
    {
	
	
        private string filePath = "leaderboard.txt";

        public Leaderboard()
        {
            InitializeComponent();
            LoadLeaderboard();
        }

        private void LoadLeaderboard()
        {
            var sortedScores = GetSortedScores();

            listBoxLeaderboard.Items.Clear();
            foreach (var entry in sortedScores)
            {
                listBoxLeaderboard.Items.Add($"{entry.UserName}: {entry.Score.ToString("0.0")} points on {entry.Date}");
            }
        }

        private List<(string UserName, double Score, string Date)> GetSortedScores()
        {
            var scores = new List<(string UserName, double Score, string Date)>();

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3 && double.TryParse(parts[1], out double score))
                    {
                        scores.Add((parts[0], score, parts[2]));
                    }
                }
            }

            return scores.OrderByDescending(s => s.Score).ToList();
        }

        public void SaveScore(string userName, double score)
        {
            string formattedScore = score.ToString("0.0");
            string date = DateTime.Now.ToString("MMMM dd, yyyy, HH:mm ", CultureInfo.InvariantCulture);
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{userName}|{formattedScore}|{date}");
            }
        }

        public static void ShowLeaderboard()
        {
            Leaderboard leaderboardForm = new Leaderboard();
            leaderboardForm.ShowDialog();
        }
	
    }
}
