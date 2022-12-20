namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private const int labelSize = 70;
        private const int distanceBetweenLabel = 6;
        private const int borderFormSize = 9;
        private const int topVerticalPadding = 40;
        private const int topWindowSize = 36;
        private const int cancelMoveButtonHeight = 30;
        private Label[,] labelsPlayngField;
        private int gameStep = 0;
        private Random random = new Random();
        private int score = 0;
        private User user = new User("Неизвестно");
        private int fieldSize = 4;
        private bool undoLimitChecked = true;
        private int undoMaximumStep = 1;
        private int configUndoMaximumStep = 1;
        private List<CurrentGameLog> currentGameLog = new List<CurrentGameLog>();

        public MainForm()
        {
            InitializeComponent();
            SetSettings();
            SetSize();
        }

        private void SetSettings()
        {
            var allSettings = Game.GetSettings();

            SetSettings(allSettings);
        }

        private void SetSettings(List<Settings> allSettings)
        {
            foreach (var setting in allSettings)
            {
                if (setting.Name == "fieldSize")
                {
                    fieldSize = Convert.ToInt32(setting.Value);
                }

                if (setting.Name == "undoLimitChecked")
                {
                    undoLimitChecked = Convert.ToBoolean(setting.Value);
                }

                if (setting.Name == "undoMaximumStep")
                {
                    configUndoMaximumStep = undoMaximumStep = Convert.ToInt32(setting.Value);
                }
            }
        }

        private void SetSize()
        {
            var widthForm = (labelSize * fieldSize) + ((fieldSize + 1) * distanceBetweenLabel) + (borderFormSize * 2);
            Width = widthForm;
            var heightForm = (labelSize * fieldSize) + ((fieldSize + 1) * distanceBetweenLabel) + topWindowSize + topVerticalPadding + cancelMoveButtonHeight;
            Height = heightForm;

            var toolStripMenuHeight = 24;
            var userNameLabelWidth = 130;

            userNameLabel.Location = new Point(widthForm - (borderFormSize * 2 + userNameLabelWidth), toolStripMenuHeight);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var userNameForm = new UserNameForm();

            if (userNameForm.ShowDialog() == DialogResult.OK)
            {
                user.Name = userNameForm.UserName;
            }

            userNameLabel.Text = user.Name;

            InitPlayingField();
            GenerateNumber();
        }

        private void InitPlayingField()
        {
            labelsPlayngField = new Label[fieldSize, fieldSize];

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    labelsPlayngField[i, j] = newLabel;
                }
            }
        }

        private void GenerateNumber()
        {
            while (EmptyCellExist())
            {
                var randomNumberLable = random.Next(fieldSize * fieldSize);
                var indexRow = randomNumberLable / fieldSize;
                var indexCol = randomNumberLable % fieldSize;

                if (labelsPlayngField[indexRow, indexCol].Text == string.Empty)
                {
                    labelsPlayngField[indexRow, indexCol].Text = GenerateRandomTwoFour().ToString();
                    return;
                }
            }

            GameOver();
        }

        private int GenerateRandomTwoFour()
        {
            var randomPercent = random.Next(101);

            return randomPercent <= 75 ? 2 : 4;
        }

        private void GameOver()
        {
            user.Score = score;

            Game.SaveResultTesting(user);

            var userAnswer = MessageBox.Show(
                $"Конец игры!\r\n{user.Name}, хотите начать новую игру?",
                "Конец игры!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1
                );

            if (userAnswer == DialogResult.Yes)
            {
                restartToolStripMenuItem.PerformClick();
            }
        }

        private bool EmptyCellExist()
        {
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    if (labelsPlayngField[i, j].Text == string.Empty)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private Label CreateLabel(int row, int column)
        {
            var positionX = distanceBetweenLabel + column * (labelSize + distanceBetweenLabel);
            var positionY = topVerticalPadding + row * (labelSize + distanceBetweenLabel);

            var label = new Label();
            label.BackColor = GetColor(0);
            label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label.Location = new Point(positionX, positionY);
            label.Size = new Size(labelSize, labelSize);
            label.Text = string.Empty;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.TextChanged += new EventHandler(ChangeColor);
            Controls.Add(label);

            return label;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            SaveStepGameLog();

            if (gameStep > 0)
            {
                canceMovelButton.Enabled = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                RightKey();
            }

            if (e.KeyCode == Keys.Left)
            {
                LeftKey();
            }

            if (e.KeyCode == Keys.Up)
            {
                UpKey();
            }

            if (e.KeyCode == Keys.Down)
            {
                DownKey();
            }

            scoreLabel.Text = score.ToString();

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                if (undoMaximumStep < configUndoMaximumStep)
                {
                    undoMaximumStep++;

                    undoStepLabel.Text = undoMaximumStep.ToString();
                }

                GenerateNumber();
            }
        }

        private void SaveStepGameLog()
        {
            string[,] tempGameLog = new string[fieldSize, fieldSize];

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    tempGameLog[i, j] = labelsPlayngField[i, j].Text;
                }
            }

            currentGameLog.Add(new CurrentGameLog(tempGameLog, score));

            gameStep++;

            if (!undoLimitChecked)
            {
                undoStepLabel.Text = currentGameLog.Count.ToString();
                return;
            }

            if (gameStep <= configUndoMaximumStep)
            {
                var tempUndoStep = Convert.ToInt32(undoStepLabel.Text);
                tempUndoStep++;

                undoStepLabel.Text = tempUndoStep.ToString();
            }
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            var currentLabel = (Label)sender;

            if (string.IsNullOrEmpty(currentLabel.Text))
            {
                currentLabel.BackColor = GetColor(0);
                return;
            }

            currentLabel.BackColor = GetColor(Convert.ToInt32(currentLabel.Text));
        }

        private void DownKey()
        {
            for (int j = 0; j < fieldSize; j++)
            {
                for (int i = fieldSize - 1; i >= 0; i--)
                {
                    if (labelsPlayngField[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsPlayngField[k, j].Text != string.Empty)
                            {
                                if (labelsPlayngField[i, j].Text == labelsPlayngField[k, j].Text)
                                {
                                    var newNumber = Convert.ToInt32(labelsPlayngField[i, j].Text);
                                    labelsPlayngField[i, j].Text = (newNumber * 2).ToString();
                                    labelsPlayngField[k, j].Text = string.Empty;
                                    score += newNumber * 2;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < fieldSize; j++)
            {
                for (int i = fieldSize - 1; i >= 0; i--)
                {
                    if (labelsPlayngField[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsPlayngField[k, j].Text != string.Empty)
                            {
                                labelsPlayngField[i, j].Text = labelsPlayngField[k, j].Text;
                                labelsPlayngField[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void UpKey()
        {
            for (int j = 0; j < fieldSize; j++)
            {
                for (int i = 0; i < fieldSize; i++)
                {
                    if (labelsPlayngField[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < fieldSize; k++)
                        {
                            if (labelsPlayngField[k, j].Text != string.Empty)
                            {
                                if (labelsPlayngField[i, j].Text == labelsPlayngField[k, j].Text)
                                {
                                    var newNumber = Convert.ToInt32(labelsPlayngField[i, j].Text);
                                    labelsPlayngField[i, j].Text = (newNumber * 2).ToString();
                                    labelsPlayngField[k, j].Text = string.Empty;
                                    score += newNumber * 2;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < fieldSize; j++)
            {
                for (int i = 0; i < fieldSize; i++)
                {
                    if (labelsPlayngField[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < fieldSize; k++)
                        {
                            if (labelsPlayngField[k, j].Text != string.Empty)
                            {
                                labelsPlayngField[i, j].Text = labelsPlayngField[k, j].Text;
                                labelsPlayngField[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void LeftKey()
        {
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    if (labelsPlayngField[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < fieldSize; k++)
                        {
                            if (labelsPlayngField[i, k].Text != string.Empty)
                            {
                                if (labelsPlayngField[i, j].Text == labelsPlayngField[i, k].Text)
                                {
                                    var newNumber = Convert.ToInt32(labelsPlayngField[i, j].Text);
                                    labelsPlayngField[i, j].Text = (newNumber * 2).ToString();
                                    labelsPlayngField[i, k].Text = string.Empty;
                                    score += newNumber * 2;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    if (labelsPlayngField[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < fieldSize; k++)
                        {
                            if (labelsPlayngField[i, k].Text != string.Empty)
                            {
                                labelsPlayngField[i, j].Text = labelsPlayngField[i, k].Text;
                                labelsPlayngField[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void RightKey()
        {
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = fieldSize - 1; j >= 0; j--)
                {
                    if (labelsPlayngField[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsPlayngField[i, k].Text != string.Empty)
                            {
                                if (labelsPlayngField[i, j].Text == labelsPlayngField[i, k].Text)
                                {
                                    var newNumber = Convert.ToInt32(labelsPlayngField[i, j].Text);
                                    labelsPlayngField[i, j].Text = (newNumber * 2).ToString();
                                    labelsPlayngField[i, k].Text = string.Empty;
                                    score += newNumber * 2;
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = fieldSize - 1; j >= 0; j--)
                {
                    if (labelsPlayngField[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsPlayngField[i, k].Text != string.Empty)
                            {
                                labelsPlayngField[i, j].Text = labelsPlayngField[i, k].Text;
                                labelsPlayngField[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentGameLog.Clear();

            canceMovelButton.Enabled = false;
            gameStep = 0;
            undoStepLabel.Text = "0";

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    labelsPlayngField[i, j].Text = string.Empty;
                }
            }

            score = 0;
            scoreLabel.Text = score.ToString();
            GenerateNumber();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RulesForm().ShowDialog();
        }

        private void allResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AllResultsForm().ShowDialog();
        }

        private void resultsCurrentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AllResultsForm(user.Name).ShowDialog();
        }

        private void bestResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var allResults = Game.GetUserResults();

            if (allResults.Count == 0)
            {
                MessageBox.Show($"Пока нет результатов игры.", "Лучший результат");
                return;
            }

            allResults = Game.SortingUsers(allResults);

            MessageBox.Show($"Лучший результат игры:\r\n{allResults[0].Name} - {allResults[0].Score}", "Лучший результат");
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();

            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                var actualSettings = settingsForm.AllSettings;

                Game.RemoveLables(labelsPlayngField);
                Game.SaveSettings(actualSettings);
                SetSettings(actualSettings);
                SetSize();
                InitPlayingField();
                restartToolStripMenuItem.PerformClick();
            }
        }

        private Color GetColor(int number)
        {
            return number switch
            {
                0 => Color.FromArgb(255, 255, 255),
                2 => Color.FromArgb(229, 242, 255),
                4 => Color.FromArgb(203, 229, 242),
                8 => Color.FromArgb(190, 203, 229),
                16 => Color.FromArgb(177, 190, 203),
                32 => Color.FromArgb(190, 177, 138),
                64 => Color.FromArgb(151, 150, 120),
                128 => Color.FromArgb(138, 100, 100),
                256 => Color.FromArgb(90, 100, 90),
                512 => Color.FromArgb(50, 100, 80),
                1024 => Color.FromArgb(30, 100, 30),
                2048 => Color.FromArgb(10, 40, 30),
                _ => Color.BlanchedAlmond
            };
        }

        private void MainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void cancelMoveButton_Click(object sender, EventArgs e)
        {
            if (!undoLimitChecked)
            {
                UndoStep();

                undoStepLabel.Text = gameStep.ToString();

                return;
            }

            if (undoMaximumStep > 0)
            {
                UndoStep();

                undoMaximumStep--;

                undoStepLabel.Text = undoMaximumStep.ToString();

                if (undoMaximumStep == 0)
                {
                    canceMovelButton.Enabled = false;
                }
            }
        }

        private void UndoStep()
        {
            gameStep--;

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    labelsPlayngField[i, j].Text = currentGameLog[gameStep].State[i, j];
                }
            }

            scoreLabel.Text = currentGameLog[gameStep].Score.ToString();
            score = currentGameLog[gameStep].Score;

            currentGameLog.RemoveAt(gameStep);

            if (gameStep == 0)
            {
                canceMovelButton.Enabled = false;
            }
        }
    }
}