namespace PROG7312_GuessingGame
{
    public partial class Form1 : Form
    {
        int score = 0;
        int round = 0;
        string[] regions = new string[4];
        string[,] countries = { { "South Africa", "Zimbabwe", "Namibia", "Mozambique" }, { "China", "Korea", "Japan", "Vietnam" }, { "Germany", "France", "Italy", "Russia" }, { "United States", "Mexico", "Argentina", "Chile" } };
        int guesses = 5;
        string answer = "";
        string context = "";
        string hint = "";
        public Form1()
        {
            regions = ["Africa", "Asia", "Europe", "America"];
            InitializeComponent();
            reset_game();
            GuessLabel.Text = "Waiting for Something to Happen";
        }

        public void reset_game()
        {
            RoundLabel.Visible = false;
            ScoreLabel.Visible = false;
          
            SubmissionBox.Visible = false;
            SubmissionButton.Visible = false;
            ContextLabel.Visible = false;
            HintLabel.Visible = false;
        }

        public void start_game()
        {
            RoundLabel.Visible = true;
            ScoreLabel.Visible = true;
            GuessLabel.Text = "Topic: Countries";
            SubmissionBox.Visible = true;
            SubmissionButton.Visible = true;
            ContextLabel.Visible = true;
            HintLabel.Visible = true;
            hint = "";
            guesses = 5;
            score = 0;
            round = 0;
            start_round();
        }

        public void init_elements()
        {
            RoundLabel.Text = "Round: " + round;
            ScoreLabel.Text = "Score: " + score;
            ContextLabel.Text = "Country in " + context;
            HintLabel.Text = "Starts With: " + hint;
        }

        public void start_round()
        {
            Random rand = new Random();
            int choice = rand.Next(0, 3);
            int choice2 = rand.Next(0, 3);
            context = regions[choice];
            answer = countries[choice, choice2];

            init_elements();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            start_game();
        }

        public void lose_game()
        {
            GuessLabel.Text = "Game Over! You reached round: " + round + ", Score: " + score;
            reset_game();
        }

        private void SubmissionButton_Click(object sender, EventArgs e)
        {
            string guess = SubmissionBox.Text;
            if (guess == answer.ToString())
            {
                score += 10;
                round += 1;
                hint = "";
                start_round();
            }
            else
            {
                guesses -= 1;
                score -= 1;
                hint = answer.Substring(0, 1);
                init_elements();

                if (guesses <= 0)
                {
                    lose_game();
                }
            }
        }
    }
}
