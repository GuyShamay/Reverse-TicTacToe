using System;

namespace B21_Ex05_Logic
{
    public class Player
    {
        private bool m_AutoPlay;
        private string m_Nickname; // Two different players can't have the same Nickname
        private int m_Score;
        private string m_PlayerSign;

        public Player(string i_Nickname)
        {
            m_Nickname = i_Nickname;
            m_Score = 0;
            m_PlayerSign = null;
        }

        // Properties:
        public string Nickname
        {
            get
            {
                return m_Nickname;
            }

            set
            {
                m_Nickname = value;
            }
        }

        public string Sign
        {
            get
            {
                return m_PlayerSign;
            }

            set
            {
                m_PlayerSign = value;
            }
        }

        public int Score
        {
            get
            {
                return m_Score;
            }

            set
            {
                m_Score = value;
            }
        }

        public bool AutoPlay
        {
            get
            {
                return m_AutoPlay;
            }

            set
            {
                m_AutoPlay = value;
            }
        }
    }
}
