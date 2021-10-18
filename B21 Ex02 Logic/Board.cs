using System;

namespace B21_Ex05_Logic
{
    public delegate void CellSelected(string i_Sign, Cell i_Cell);
    
    public class Board
    {
        private readonly Cell[,] r_Board;
        private readonly int r_Rows;
        private readonly int r_Columns;
        
        public Board(int i_Rows, int i_Columns)
        {
            r_Rows = i_Rows;
            r_Columns = i_Columns;
            r_Board = new Cell[r_Rows, r_Columns];
        }

        public Cell this[int i, int j]
        {
            get
            {
                return r_Board[i, j];
            }

            set
            {
                r_Board[i, j] = value;
            }
        }

        public int Rows
        {
            get
            {
                return r_Rows;
            }
        }

        public int Columns
        {
            get
            {
                return r_Columns;
            }
        }

        public void MakeMove(string i_Sign, Cell i_Cell)
        {
            r_Board[i_Cell.Row, i_Cell.Col].UpdateCell(i_Sign);
        }

        public void Clear()
        {
            for (int row = 0; row < r_Rows; row++)
            {
                for (int col = 0; col < r_Columns; col++)
                {
                    r_Board[row, col].UpdateCell(null);
                }
            }
        }
    }
}