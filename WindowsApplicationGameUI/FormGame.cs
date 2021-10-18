using System.Windows.Forms;
using System.Drawing;

namespace WindowsApplicationGameUI
{
    public partial class FormGame : Form
    {
        private FormGameSettings m_FormGameSettings = new FormGameSettings();
        private ButtonGame[,] m_Buttons;
        private Label m_LabelPlayer1Score;
        private Label m_LabelPlayer2Score;
        private Font m_FontBold;
        private Font m_FontRegular;

        public event TurnPlayed Play;

        public FormGame()
        {
            m_FontBold = new Font(this.Font, FontStyle.Bold);
            m_FontRegular = new Font(this.Font, FontStyle.Regular);
            InitializeComponent();
        }

        public void InitializeFormGame()
        {
            DialogResult settingDialog = m_FormGameSettings.ShowDialog();
            if (settingDialog == DialogResult.OK)
            {
                createFormGame(m_FormGameSettings.Rows);
            }
            else
            {
                closingGameSettings();
            }
        }

        private void createFormGame(int i_Size)
        {
            m_Buttons = new ButtonGame[i_Size, i_Size];

            this.createBoardBySettings(i_Size);
            this.updatePlayersLabels();
        }

        public string Player1
        {
            get { return m_FormGameSettings.Player1; }
        }

        public string Player2
        {
            get { return m_FormGameSettings.Player2; }
        }

        public bool IsComputerPlayer
        {
            get { return m_FormGameSettings.IsComputerPlayer; }
        }

        public int BoardSize
        {
            get { return m_FormGameSettings.Rows; }
        }

        private void updatePlayersLabels()
        {
            this.updatePlayersLabelsLocation(this.Top + 10);
            this.UpdatePlayersLabelsText(0, 0);
        }

        private void updatePlayersLabelsLocation(int i_Top)
        {
            m_LabelPlayer1Score = new Label();
            this.Controls.Add(m_LabelPlayer1Score);
            m_LabelPlayer2Score = new Label();
            this.Controls.Add(m_LabelPlayer2Score);

            m_LabelPlayer1Score.Top = i_Top;
            m_LabelPlayer2Score.Top = m_LabelPlayer1Score.Top;

            m_LabelPlayer1Score.Left = (this.Width / 2) - 100;
            m_LabelPlayer2Score.Left = (this.Width / 2) + 15;
        }

        public void UpdatePlayersLabelsText(int i_Player1Score, int i_Player2Score)
        {
            m_LabelPlayer1Score.Text = string.Format("{0}: {1}", m_FormGameSettings.Player1, i_Player1Score);
            m_LabelPlayer2Score.Text = string.Format("{0}: {1}", m_FormGameSettings.Player2, i_Player2Score);
        }

        public void UpdatePlayersLabelFont(int i_CurrentPlayer)
        {
            if (i_CurrentPlayer == 0)
            {
                m_LabelPlayer1Score.Font = m_FontBold;
                m_LabelPlayer2Score.Font = m_FontRegular;
            }
            else
            {
                m_LabelPlayer2Score.Font = m_FontBold;
                m_LabelPlayer1Score.Font = m_FontRegular;
            }
        }

        public void ChangeButtonText(int i_Row, int i_Col, string i_Sign)
        {
            m_Buttons[i_Row, i_Col].Enabled = false;
            m_Buttons[i_Row, i_Col].Text = i_Sign;
        }

        private void closingGameSettings()
        {
            DialogResult closingSettingsResult = MessageBox.Show("Are you sure you want to cancel the game?", "Cancel Game", MessageBoxButtons.YesNo);
            if (closingSettingsResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                InitializeFormGame();
            }
        }

        private void createBoardBySettings(int i_BoardSize)
        {
            const int k_ButtonSize = 40;
            const int k_SpaceBetweenButtons = 8, k_SpaceFromClientSize = 30;
            int formClientSize = (2 * k_SpaceFromClientSize) + (i_BoardSize * k_ButtonSize) +
                                 ((i_BoardSize - 1) * k_SpaceBetweenButtons);

            this.ClientSize = new Size(formClientSize, formClientSize);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            for (int i = 0; i < i_BoardSize; i++)
            {
                for (int j = 0; j < i_BoardSize; j++)
                {
                    m_Buttons[i, j] = new ButtonGame(i, j);
                    m_Buttons[i, j].Height = k_ButtonSize;
                    m_Buttons[i, j].Width = k_ButtonSize;
                    m_Buttons[i, j].Top = (i * k_ButtonSize) + k_SpaceFromClientSize + (k_SpaceBetweenButtons * i);
                    m_Buttons[i, j].Left = (j * k_ButtonSize) + k_SpaceFromClientSize + (k_SpaceBetweenButtons * j);
                    m_Buttons[i, j].Click += buttons_Clicked;
                    m_Buttons[i, j].TabStop = false;
                    this.Controls.Add(m_Buttons[i, j]);
                }
            }
        }

        private void buttons_Clicked(object sender, System.EventArgs e)
        {
            ButtonGame myButton = sender as ButtonGame;

            OnPlayed(myButton.Row, myButton.Col);
        }

        protected virtual void OnPlayed(int i_Row, int i_Col)
        {
            Play?.Invoke(i_Row, i_Col);
        }

        public void ShowWinner(string i_WinnerName, int i_Player1Score, int i_Player2Score)
        {
            string output = string.Format(@"{0} is the winner!
Would you like to play another round?", i_WinnerName);

            DialogResult closingSettingsResult = MessageBox.Show(output, "A Win!", MessageBoxButtons.YesNo);
            if (closingSettingsResult == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                UpdatePlayersLabelsText(i_Player1Score, i_Player2Score);
            }
        }

        public void EndInTie()
        {
            DialogResult closingSettingsResult = MessageBox.Show(@"It's a tie!
Would you like to play another round?", "A Tie!", MessageBoxButtons.YesNo);

            if (closingSettingsResult == DialogResult.No)
            {
                this.Close();
            }
        }

        public void EnableAllButtons()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    m_Buttons[i, j].Enabled = true;
                }
            }
        }
    }
}