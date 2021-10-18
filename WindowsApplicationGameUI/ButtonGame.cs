using System.Windows.Forms;

namespace WindowsApplicationGameUI
{
    public class ButtonGame : Button
    {
        private readonly int r_Row;
        private readonly int r_Col;

        public ButtonGame(int i_Row, int i_Col) : base()
        {
            r_Col = i_Col;
            r_Row = i_Row;
        }

        public int Row
        {
            get { return r_Row; }
        }
        
        public int Col
        {
            get { return r_Col; }
        }
    }
}
