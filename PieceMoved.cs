using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Game
{
   public class PieceMoved
    {
        public const char PieceName = 'P'; 
        public const char Space = ' ';
        public static char[ , ] pawns;

        public PieceMoved()
        {
            pawns = new char[ChessBoard.Dimension, ChessBoard.Dimension];
            InitializedPawn();
        }

        private void InitializedPawn()
        {
            for (int r = 0; r < ChessBoard.Dimension; r++)
            {
                for (int c = 0; c < ChessBoard.Dimension; c++)
                {
                    if (r == 0 || r == 1 || r == ChessBoard.Dimension - 2 || r == ChessBoard.Dimension - 1)
                        pawns[r, c] = PieceName;
                    else
                        pawns[r, c] = Space;
                }
            }
        }
    }
}
