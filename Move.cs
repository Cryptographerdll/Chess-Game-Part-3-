using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Game
{
    public class Move : PieceMoved
    {
        private int Target_X;
        private int Target_Y;
        private int Destination_X;
        private int Destination_Y;

        public Move()
        {
            this.Target_X = 0;
            this.Target_Y = 0;
            this.Destination_X = 0;
            this.Destination_Y = 0;
            Exit = false;
        }

        public bool Exit { get; set; }
    }
}
