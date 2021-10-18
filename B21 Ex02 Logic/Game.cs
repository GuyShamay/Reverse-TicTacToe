using System;
using System.Collections.Generic;

namespace B21_Ex05_Logic
{
    public delegate void TieGame();

    public delegate void WinGame(string i_Name);

    public class Game
    {
        private readonly Board r_Board;
        private readonly List<Player> r_Players;
        private bool m_HasWinner;
        private bool m_IsTie;
        private bool m_MatchOver;
        private int m_CurrentPlayerIndex;
        private int m_MovesPlayed;
        private int? m_WinnerPlayerIndex;

        public event WinGame Win;

        public event TieGame Tie;

        public Game(int i_BoardSize)
        {
            r_Board = new Board(i_BoardSize, i_BoardSize);
            r_Players = new List<Player>();
            m_HasWinner = false;
            m_IsTie = false;
            m_MatchOver = false;
            m_CurrentPlayerIndex = 0;
            m_MovesPlayed = 0;
            m_WinnerPlayerIndex = null;
        }

        public void InitializePlayers(Player i_Player1, Player i_Player2)
        {
            r_Players.Add(i_Player1);
            r_Players.Add(i_Player2);
            setSignForPlayers();
            if (i_Player2.AutoPlay && r_Board.Rows % 2 == 1)
            {
                CurrentPlayer = 1;
            }
        }

        public void AddCell(Cell i_Cell)
        {
            r_Board[i_Cell.Row, i_Cell.Col] = i_Cell;
        }

        public List<Player> Players
        {
            get { return r_Players; }
        }

        public bool MatchOver
        {
            get
            {
                return m_MatchOver;
            }
        }

        public int Player1Score
        {
            get
            {
                return r_Players[0].Score;
            }
        }

        public int Player2Score
        {
            get
            {
                return r_Players[1].Score;
            }
        }

        public Board GameBoard
        {
            get
            {
                return r_Board;
            }
        }

        public int CurrentPlayer
        {
            get
            {
                return m_CurrentPlayerIndex;
            }

            set
            {
                m_CurrentPlayerIndex = value;
            }
        }

        private void setSignForPlayers()
        {
            r_Players[0].Sign = "X";
            r_Players[1].Sign = "O";
        }

        private void changePlayer()
        {
            CurrentPlayer = CurrentPlayer == 0 ? 1 : 0;
        }

        public void MakeMove(Cell i_Cell)
        {
            r_Board.MakeMove(Players[CurrentPlayer].Sign, i_Cell);
            m_MovesPlayed++;
            if (m_MovesPlayed >= r_Board.Rows)
            {
                checkWin(i_Cell);
            }

            if (!m_HasWinner)
            {
                this.changePlayer();
            }

            if (m_MovesPlayed == r_Board.Rows * r_Board.Columns && !m_HasWinner)
            {
                updateTie();
            }

            if (m_IsTie || m_HasWinner)
            {
                m_MatchOver = true;
                clearMatch();
            }
        }

        private void checkWin(Cell i_Cell)
        {
            bool isWin = false;
            isWin = GameChecks.CheckWinByMove(GameBoard, i_Cell);
            if (isWin)
            {
                changePlayer();
                updateWin();
            }
        }

        private void updateWin()
        {
            r_Players[m_CurrentPlayerIndex].Score++;
            m_WinnerPlayerIndex = m_CurrentPlayerIndex;
            m_HasWinner = true;
            OnWin(Players[m_CurrentPlayerIndex].Nickname);
        }

        protected virtual void OnWin(string i_WinnerName)
        {
            Win?.Invoke(i_WinnerName);
        }

        private void updateTie()
        {
            m_IsTie = true;
            OnTie();
        }

        protected virtual void OnTie()
        {
            Tie?.Invoke();
        }

        private void clearMatch()
        {
            r_Board.Clear();
            m_MovesPlayed = 0;
            if (r_Board.Rows % 2 == 1 && Players[1].AutoPlay)
            {
                m_CurrentPlayerIndex = 1;
            }
            else
            {
                m_CurrentPlayerIndex = 0;
            }

            m_HasWinner = false;
            m_IsTie = false;
            m_WinnerPlayerIndex = null;
        }

        public void NewMatch()
        {
            m_MatchOver = false;
        }

        public void MakeMoveAI(Cell i_PostCell)
        {
            int col, row, boardSize;

            boardSize = r_Board.Columns;
            if (boardSize % 2 == 1 && i_PostCell.Col == i_PostCell.Row)
            {
                col = boardSize - i_PostCell.Col - 1;
                row = col;
            }
            else
            {
                col = boardSize - i_PostCell.Col - 1;
                row = boardSize - i_PostCell.Row - 1;
            }

            Cell myCell = new Cell(row, col);
            MakeMove(myCell);
        }
    }
}