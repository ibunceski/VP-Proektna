using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class QuizForm : Form
    {
        private string category;
        private int numQuestions;
        private QuizAPIClient quizAPIClient;
        private List<Question> questions;
        private int currentQuestionIndex;
        private Dictionary<int, Button> questionButtons;
        private Button currentQuestionButton;
        private Button submitButton;
        private Button previousButton;
        private Button nextButton;
        private ProgressBar progressBar;
        private bool isReviewMode = false;
        private int score;
        private string username = "user";
        private int secondsPassed;

        public QuizForm(int numQuestions, string category, string username)
        {
            InitializeComponent();
            this.category = category;
            this.numQuestions = numQuestions;
            this.username = username;
            this.secondsPassed = 0;
            quizAPIClient = new QuizAPIClient();
            questionButtons = new Dictionary<int, Button>();
        }

        private async void QuizForm_Load(object sender, EventArgs e)
        {
            try
            {
                questions = await quizAPIClient.GetQuestions(numQuestions, category);
                currentQuestionIndex = 0;
                timerTimePassed.Start();
                CreateSubmitButton();
                CreateNavigationButtons();
                InitializeProgressBar();
                DisplayQuestion();
                UpdateCurrentButtonOutline(questionButtons[currentQuestionIndex]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void CreateSubmitButton()
        {
            submitButton = new Button
            {
                Text = "Submit",
                Width = 100,
                Height = 40,
                Location = new System.Drawing.Point(this.Width / 2 - 50, panelAnswers.Bottom + 100),
                Visible = false
            };
            submitButton.Click += SubmitButton_Click;
            this.Controls.Add(submitButton);
        }

        private void CreateNavigationButtons()
        {
            for (int i = 0; i < numQuestions; i++)
            {
                if (i == 0)
                {
                    previousButton = new Button
                    {
                        Text = "Previous",
                        Width = 80,
                        Height = 40,
                        Location = new System.Drawing.Point(10 + i * 45, panelAnswers.Bottom + 75),
                        FlatStyle = FlatStyle.Flat
                    };
                    this.Controls.Add(previousButton);
                    previousButton.Click += PreviousButton_Click;

                }
                else if (i == numQuestions - 1)
                {
                    nextButton = new Button
                    {
                        Text = "Next",
                        Width = 80,
                        Height = 40,
                        Location = new System.Drawing.Point(this.Width - 110, panelAnswers.Bottom + 75),
                        FlatStyle = FlatStyle.Flat
                    };
                    this.Controls.Add(nextButton);
                    nextButton.Click += NextButton_Click;


                }
                Button button = new Button
                {
                    Text = (i + 1).ToString(),
                    Width = 40,
                    Height = 40,
                    Location = new System.Drawing.Point(10 + i * 45, panelAnswers.Bottom + 30),
                    Tag = i,
                    FlatStyle = FlatStyle.Flat
                };
                this.Controls.Add(button);

                button.Click += NavigationButton_Click;

                questionButtons[i] = button;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            SaveCurrentQuestionAnswers();
            currentQuestionIndex--;
            DisplayQuestion();
            UpdateCurrentButtonOutline(questionButtons[currentQuestionIndex]);
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            SaveCurrentQuestionAnswers();
            currentQuestionIndex++;
            DisplayQuestion();
            UpdateCurrentButtonOutline(questionButtons[currentQuestionIndex]);

        }

        private void InitializeProgressBar()
        {
            progressBar = new ProgressBar
            {
                Minimum = 0,
                Maximum = numQuestions,
                Value = 0,
                Width = this.ClientSize.Width - 25,
                Location = new System.Drawing.Point(10, panelAnswers.Bottom + 150)
            };
            this.Controls.Add(progressBar);
        }

        private void NavigationButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                SaveCurrentQuestionAnswers();
                currentQuestionIndex = (int)button.Tag;
                DisplayQuestion();
                UpdateCurrentButtonOutline(button);
            }
        }

        private void DisplayQuestion()
        {
            panelAnswers.Controls.Clear();
            
            if (questions != null && questions.Count > 0)
            {
                Question question = questions[currentQuestionIndex];
                labelQuestion.Text = $"{currentQuestionIndex + 1}. {question.question}";

                if (currentQuestionIndex == 0) previousButton.Visible = false;
                else previousButton.Visible = true;

                if (currentQuestionIndex == numQuestions-1) nextButton.Visible = false;
                else nextButton.Visible = true;

                int yPos = 10;
                foreach (KeyValuePair<string, string> answer in question.answers)
                {
                    if (!string.IsNullOrEmpty(answer.Value))
                    {
                        if (question.multiple_correct_answers)
                        {
                            CheckBox checkBox = new CheckBox
                            {
                                Text = answer.Value,
                                Tag = answer.Key,
                                AutoSize = true,
                                Location = new System.Drawing.Point(10, yPos),
                                Checked = question.QuestionsSelectedByUser.Contains(answer.Value),
                                Enabled = !isReviewMode
                            };
                            panelAnswers.Controls.Add(checkBox);
                        }
                        else
                        {
                            RadioButton radioButton = new RadioButton
                            {
                                Text = answer.Value,
                                Tag = answer.Key,
                                AutoSize = true,
                                Location = new System.Drawing.Point(10, yPos),
                                Checked = question.QuestionsSelectedByUser.Contains(answer.Value),
                                Enabled = !isReviewMode
                            };
                            panelAnswers.Controls.Add(radioButton);
                        }
                        yPos += 30;
                    }
                }

                if (isReviewMode)
                {
                    Label correctAnswersLabel = new Label
                    {
                        Text = $"Correct answers: {(question.GetCorrectAnswers().Count == 0 ? "There are no correct answers" : string.Join(", ", question.GetCorrectAnswers()))}, Points: {(AreAnswersCorrect(question) ? 5 : 0)}",
                        AutoSize = true,
                        Location = new System.Drawing.Point(10, yPos)
                    };
                    panelAnswers.Controls.Add(correctAnswersLabel);
                }

                if (currentQuestionIndex == questions.Count - 1 || isReviewMode)
                {
                    submitButton.Visible = true;
                }
                else
                {
                    submitButton.Visible = false;
                }
            }
        }

        private void SaveCurrentQuestionAnswers()
        {
            if (questions != null && questions.Count > 0)
            {
                Question question = questions[currentQuestionIndex];
                List<string> selectedAnswers = new List<string>();

                foreach (Control control in panelAnswers.Controls)
                {
                    if (control is CheckBox checkBox && checkBox.Checked)
                    {
                        selectedAnswers.Add(checkBox.Text);
                    }
                    else if (control is RadioButton radioButton && radioButton.Checked)
                    {
                        selectedAnswers.Add(radioButton.Text);
                    }
                }

                question.SaveSelectedAnswers(selectedAnswers);

                if(!isReviewMode)
                {
                    if (selectedAnswers.Count > 0)
                    {
                        questionButtons[currentQuestionIndex].BackColor = Color.Gray;
                    }
                    else
                    {
                        questionButtons[currentQuestionIndex].BackColor = SystemColors.Control;
                    }
                    UpdateProgressBar();
                }
            }
        }

        private void UpdateProgressBar()
        {
            int answeredQuestions = questions.Count(q => q.QuestionsSelectedByUser.Count > 0);
            progressBar.Value = answeredQuestions;
        }

        private void UpdateCurrentButtonOutline(Button button)
        {
            if (currentQuestionButton != null)
            {
                currentQuestionButton.FlatAppearance.BorderSize = 1;
                currentQuestionButton.FlatAppearance.BorderColor = Color.Black;
            }

            currentQuestionButton = button;
            currentQuestionButton.FlatStyle = FlatStyle.Flat;
            currentQuestionButton.FlatAppearance.BorderSize = 2;
            currentQuestionButton.FlatAppearance.BorderColor = Color.Blue;
        }

        private bool AreAnswersCorrect(Question question)
        {
            List<string> correctAnswers = question.GetCorrectAnswers();
            return question.QuestionsSelectedByUser.All(correctAnswers.Contains) &&
                   correctAnswers.All(question.QuestionsSelectedByUser.Contains);
        }

        private void HighlightAnswerButtons()
        {
            foreach (KeyValuePair<int, Button> kvp in questionButtons)
            {
                int index = kvp.Key;
                Button button = kvp.Value;
                Question question = questions[index];
                if (AreAnswersCorrect(question))
                {
                    button.BackColor = Color.Green;
                }
                else
                {
                    button.BackColor = Color.Red;
                }
            }
        }

        private void CalculateScore()
        {
            score = 0;
            foreach (var question in questions)
            {
                if (AreAnswersCorrect(question))
                {
                    score += 5;
                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (isReviewMode)
            {
                DialogResult result = MessageBox.Show("Do you want to play another quiz or exit the application?", "Review Done", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    Application.Exit();

                }
            }
            else
            {
                timerTimePassed.Stop();
                SaveCurrentQuestionAnswers();
                CalculateScore();
                Leaderboard leaderboard = new Leaderboard();
                double scoreToSave = ((double)score / (5.0 * numQuestions)) * 100.0 - (secondsPassed / 10.0);
                leaderboard.SaveScore(username, scoreToSave < 0 ? 0 : scoreToSave);
                DialogResult result = MessageBox.Show("Do you want to view the leaderboard or review your answers?", "Quiz Completed", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    ShowLeaderboard();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    labelPoints.Text = $"Total points: {score}/{questionButtons.Count*5}";
                    isReviewMode = true;
                    HighlightAnswerButtons();
                    submitButton.Text = "Finish review";
                    currentQuestionIndex = 0;
                    DisplayQuestion();
                    UpdateCurrentButtonOutline(questionButtons[currentQuestionIndex]);
                }
            }
        }

        private void ShowLeaderboard()
        {
            Leaderboard.ShowLeaderboard();
        }

        private void timerTimePassed_Tick(object sender, EventArgs e)
        {
            secondsPassed++;
            int minutes = secondsPassed / 60;
            int seconds = secondsPassed % 60;

            lblTimeLeft.Text = String.Format("Time passed: {0:D2}:{1:D2}", minutes, seconds);
        }
    }
}