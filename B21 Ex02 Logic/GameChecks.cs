namespace B21_Ex05_Logic
{
    public class GameChecks
    {
        public static bool CheckWinByMove(Board i_Board, Cell i_Cell)
        {
            return (checkRow(i_Board, i_Cell) || checkColumn(i_Board, i_Cell) || checkDiagonal(i_Board, i_Cell));
        }

        private static bool checkRow(Board i_Board, Cell i_Cell)
        {
            string signToCheck = i_Board[i_Cell.Row, i_Cell.Col].Sign;
            bool isWin = true;

            for (int i = 0; i < i_Board.Columns && isWin; i++)
            {
                if (i_Board[i_Cell.Row, i].Sign != signToCheck)
                {
                    isWin = false;
                }
            }

            return isWin;
        }

        private static bool checkColumn(Board i_Board, Cell i_Cell)
        {
            string signToCheck = i_Board[i_Cell.Row, i_Cell.Col].Sign;
            bool isWin = true;

            for (int i = 0; i < i_Board.Rows && isWin; i++)
            {
                if (i_Board[i, i_Cell.Col].Sign != signToCheck)
                {
                    isWin = false;
                }
            }

            return isWin;
        }

        private static bool checkDiagonal(Board i_Board, Cell i_Cell)
        {
            string signToCheck = i_Board[i_Cell.Row, i_Cell.Col].Sign;
            bool isWin = false;

            if (i_Cell.Row == i_Cell.Col)
            {
                //// diagonal \
                isWin = true;
                for (int i = 0; i < i_Board.Rows && isWin; i++)
                {
                    if (i_Board[i, i].Sign != signToCheck)
                    {
                        isWin = false;
                    }
                }
            }

            if ((i_Cell.Row + i_Cell.Col == i_Board.Rows - 1) && (!isWin))
            {
                //// diagonal /
                isWin = true;
                for (int i = 0; i < i_Board.Rows && isWin; i++)
                {
                    if (i_Board[i, i_Board.Columns - 1 - i].Sign != signToCheck)
                    {
                        isWin = false;
                    }
                }
            }

            return isWin;
        }
    }
}
