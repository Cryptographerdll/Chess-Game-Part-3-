using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Game
{
    public class ChessBoard
    {
        private String[,] chessBoard;

        public const int Dimension = 8;

        private Move move;

        public ChessBoard()
        {
            move = new Move();

            chessBoard = new string[Dimension, Dimension];
            this.ChessBoardHorizoontalSymbol = "+---";
            this.ChessBoardVerticalSymbol = "| ";
        }

        public String ChessBoardHorizoontalSymbol { get; set; }
        public String ChessBoardVerticalSymbol { get; set; }

        public void DisplayChessBoard()
        {
            Console.Clear();
            Console.WriteLine("    0   1   2   3   4   6   5   7");

            for (int r = 0; r < Dimension; r++)
            {
                Console.Write("  ");

                for (int c = 0; c < Dimension; c++)
                {
                    Console.Write(ChessBoardHorizoontalSymbol);
                }

                Console.Write("+\n");

                for (int c = 0; c < Dimension; c++)
                {
                    if (c == 0)
                        Console.Write(r + " ");
                        Console.Write(ChessBoardVerticalSymbol + PieceMoved.pawns[r, c] + " ");
                }

                Console.Write("|\n");
            }

            Console.Write("  ");

            for (int c = 0; c < Dimension; c++)
            {
                Console.Write(ChessBoardHorizoontalSymbol);
            }

            Console.Write("+\n\n");
        }
    }
}
