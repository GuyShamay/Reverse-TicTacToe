using System;
using System.Windows.Forms;

namespace WindowsApplicationGameUI
{
    public partial class FormGameSettings : Form
    {
        public FormGameSettings()
        {
            InitializeComponent();
            m_ButtonStart.Click += buttonStart_Click;
            m_NumericRows.ValueChanged += numerics_ValueChanged;
            m_NumericCols.ValueChanged += numerics_ValueChanged;
        }

        private void numerics_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown theSender = sender as NumericUpDown;
            m_NumericRows.Value = theSender.Value;
            m_NumericCols.Value = theSender.Value;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (ensurePlayersNames())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter names correctly.", "Wrong Input", MessageBoxButtons.OK);
            }
        }
        
        private bool ensurePlayersNames()
        {
            bool validNames = true;
            if (m_TextBoxPlayer1.Text == string.Empty)
            {
                validNames = false;
            }
            else
            {
                if (m_CheckBoxPlayer2.Checked && m_TextBoxPlayer2.Text == string.Empty)
                {
                    validNames = false;
                }
            }

            return validNames;
        }
        
        private void checkBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                m_TextBoxPlayer2.Text = null;        
                m_TextBoxPlayer2.Enabled = true;
            }
            else
            {
                m_TextBoxPlayer2.Text = "(Computer)";
                m_TextBoxPlayer2.Enabled = false;
            }
        } 

        public int Rows
        {
            get
            {
                return (int)m_NumericRows.Value;
            }
        }

        public int Cols
        {
            get
            {
                return (int)m_NumericCols.Value;
            }
        }

        public string Player1
        {
            get
            {
                return m_TextBoxPlayer1.Text;
            }
        }
        
        public string Player2
        {
            get
            {
                if (!m_CheckBoxPlayer2.Checked)
                {
                    m_TextBoxPlayer2.Text = "Computer";
                }

                return m_TextBoxPlayer2.Text;
            }
        }

        public bool IsComputerPlayer
        {
            get
            {
                return !m_CheckBoxPlayer2.Checked; // if its check - player 2 is human
            }
        }
    }
}
