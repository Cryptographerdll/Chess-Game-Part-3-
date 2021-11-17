using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Chess_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Print a 2-Dimensional Chessboard
              Continually ask the user for coordinates
              Always overwrite the destination with the target
              Always replace the target with an empty string
              End the program if any of the coordinates are out of range
              Technical Requirements
              The board must actually be a 2-Dimensional Array of strings.
              The board you display must be a true representation of the 2D Array.
           */

            ChessBoard chessBoard = new ChessBoard();
            chessBoard.DisplayChessBoard();

            PieceMoved pieceMoved = new PieceMoved();
           
        }
    }
}
