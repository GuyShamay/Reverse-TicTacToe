using System;
using B21_Ex05_Logic;

namespace WindowsApplicationGameUI
{
    public delegate void TurnPlayed(int i_Row, int i_Col);
   
    public class GameManager
    {
        private Game m_Game;
        private FormGame m_FormGame = new FormGame();

        public void Run()
        {
            m_FormGame.InitializeFormGame();
            this.initializeGame();
            playGame();
        }

        private void playGame()
        {
            computerPlaysFirst();
            m_FormGame.ShowDialog();
        }

        private void computerPlaysFirst()
        {
            if (m_FormGame.BoardSize % 2 == 1 && m_FormGame.IsComputerPlayer)
            {
                int position = m_FormGame.BoardSize / 2;
                Cell firstCell = new Cell(position, position);
                m_Game.MakeMove(firstCell);
            }
        }

        private void initializeGame()
        {
            m_Game = new Game(m_FormGame.BoardSize);

            m_Game.Win += game_Win;
            m_Game.Tie += game_Tie;
            m_FormGame.Play += turn_Played;
            this.updateCellToButtons();
            this.addPlayers();
            if (m_FormGame.IsComputerPlayer)
            {
                m_FormGame.UpdatePlayersLabelFont(0);
            }
        }

        private void game_Tie()
        {
            m_FormGame.EndInTie();
        }

        private void game_Win(string i_Name)
        {
            m_FormGame.ShowWinner(i_Name, m_Game.Player1Score, m_Game.Player2Score);
        }
        
        private void turn_Played(int i_Row, int i_Col)
        {
            Cell myCell = new Cell(i_Row, i_Col);
            m_Game.MakeMove(myCell);
            if (m_FormGame.IsComputerPlayer && !m_Game.MatchOver)
            {
                m_Game.MakeMoveAI(myCell);
            }

            if(!m_FormGame.IsComputerPlayer)
            {
                m_FormGame.UpdatePlayersLabelFont(m_Game.CurrentPlayer);
            }

            if (m_Game.MatchOver)
            {
                restartFormGame();
                m_Game.NewMatch();
                computerPlaysFirst();
            }
        }

        private void addPlayers()
        {
            const bool v_IsAutoPlayer = true;
            Player player1 = new Player(m_FormGame.Player1);
            Player player2 = new Player(m_FormGame.Player2);

            player1.AutoPlay = !v_IsAutoPlayer;
            player2.AutoPlay = m_FormGame.IsComputerPlayer ? v_IsAutoPlayer : !v_IsAutoPlayer;
            m_Game.InitializePlayers(player1, player2);
        }
        
        private void cell_Selected(string i_Sign, Cell i_Cell)
        { 
            m_FormGame.ChangeButtonText(i_Cell.Row, i_Cell.Col, i_Sign);
        }

        private void updateCellToButtons()
        {
            for (int i = 0; i < m_FormGame.BoardSize; i++)
            {
                for (int j = 0; j < m_FormGame.BoardSize; j++)
                {
                    Cell myCell = new Cell(i, j);
                    myCell.Selected += cell_Selected;
                    m_Game.AddCell(myCell);
                }
            }
        }

        private void restartFormGame()
        {
            m_FormGame.EnableAllButtons();
        }
    }
}