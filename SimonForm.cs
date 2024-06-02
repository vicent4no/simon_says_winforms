namespace SimonVicentin
{
    enum SimonColors
    {
        GREEN, RED, BLUE, YELLOW
    }
    public partial class SimonForm : Form
    {

        private List<SimonColors> GameColors { get; set; }
        private List<SimonColors> UserColors { get; set; }


        private bool SkipTick { get; set; }

        private int MaximumCount { get; set; }

       public SimonForm() { 
            InitializeComponent();
            GameColors = [];
            UserColors = [];
            SkipTick = false;
            MaximumCount = GetInitialGameCount();
        }

        private int GetInitialGameCount()
        {
            return 3;
        }

        private void RestartColors()
        {
            greenButton.BackColor = Color.ForestGreen;
            redButton.BackColor = Color.DarkRed;
            blueButton.BackColor = Color.SteelBlue;
            yellowButton.BackColor = Color.DarkKhaki;
        }

        private void EnableButtons()
        {
            greenButton.Enabled = true;
            redButton.Enabled = true;
            blueButton.Enabled = true;
            yellowButton.Enabled = true;
        }


        private void DisableButtons()
        {
            greenButton.Enabled = false;
            redButton.Enabled = false;
            blueButton.Enabled = false;
            yellowButton.Enabled = false;
        }


        private void ResetUserMessage()
        {
            DisableButtons();
            GameColors.Clear();
            UserColors.Clear();
            MaximumCount = GetInitialGameCount();
            endGameText.Text = null;
            endGamePanel.Visible = false;
        }

        private void ShowUserLostMessage()
        {
            startButton.Enabled = true;
            endGameText.Text = $"Has llegado a {GameColors.Count - GetInitialGameCount() + 1} intentos.\nClickea comenzar para volver a jugar.";
            endGamePanel.Show();
        }

        private void ContinueGame()
        {
            DisableButtons();
            GameColors.Clear();
            UserColors.Clear();
            MaximumCount += 1;
            timer.Start();
        }

        private void DecideUserContinues()
        {
            if (UserColors.Count == GameColors.Count)
            {
                // vemos si el usuario sigue jugando
                bool userLost = false;
                for (int i = 0; i < GameColors.Count; i++)
                {
                    if (GameColors[i] != UserColors[i]) {
                        userLost = true;
                        break;
                    }
                }

                if (userLost)
                {
                    ShowUserLostMessage();
                }
                else {
                    ContinueGame();
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RestartColors();

            if (SkipTick)
            {
                SkipTick = false;
                return;
            }
            if (GameColors.Count == MaximumCount)
            {
                timer.Stop();
                EnableButtons();
                return;
            }


            // obtengo enum aleatorio
            SimonColors color = (SimonColors)new Random().Next(4);

            if (color is SimonColors.GREEN)
            {
                greenButton.BackColor = Color.LawnGreen;
            }
            else if (color is SimonColors.RED)
            {
                redButton.BackColor = Color.Red;
            }
            else if (color is SimonColors.BLUE)
            {
                blueButton.BackColor = Color.Blue;
            }
            else
            {
                yellowButton.BackColor = Color.Yellow;
            }
            GameColors.Add(color);
            SkipTick = true;

        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            UserColors.Add(SimonColors.GREEN);
            DecideUserContinues();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            UserColors.Add(SimonColors.RED);
            DecideUserContinues();

        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            UserColors.Add(SimonColors.YELLOW);
            DecideUserContinues();
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            UserColors.Add(SimonColors.BLUE);
            DecideUserContinues();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ResetUserMessage();
            startButton.Enabled = false;
            timer.Start();
        }
    }
}
