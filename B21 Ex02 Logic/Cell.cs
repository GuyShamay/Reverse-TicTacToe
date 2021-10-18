using System;
using System.Collections.Generic;
using System.Text;

namespace B21_Ex05_Logic
{
    public class Cell
    {
        private readonly int r_Row;
        private readonly int r_Col;
        private string m_Sign;

        public event CellSelected Selected;

        public Cell(int i_Row, int i_Col)
        {
            r_Col = i_Col;
            r_Row = i_Row;
            m_Sign = null;
        }

        public string Sign
        {
            get { return m_Sign; }
        }

        public int Row
        {
            get { return r_Row; }
        }

        public int Col
        {
            get { return r_Col; }
        }

        public void UpdateCell(string i_Sign)
        {
            this.m_Sign = i_Sign;
            OnSelected(i_Sign);
        }

        protected virtual void OnSelected(string i_Sign)
        {
            Selected?.Invoke(i_Sign, this);
        }
    }
}
