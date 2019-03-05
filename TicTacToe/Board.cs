using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        public BoardPosition Position { get; set; }

        public static List<Tuple<int, int, int>> WinningPermutations => new List<Tuple<int, int, int>>
        {
             new Tuple<int, int, int>(1,2,3),
             new Tuple<int, int, int>(4,5,6),
             new Tuple<int, int, int>(7,8,9),
             new Tuple<int, int, int>(1,4,7),
             new Tuple<int, int, int>(2,5,8),
             new Tuple<int, int, int>(3,6,9),
             new Tuple<int, int, int>(1,5,9),
             new Tuple<int, int, int>(3,5,7)
        };

        public Board()
        {
            Position = new BoardPosition();
        }

        public void DrawBoard()
        {
            WriteLines(1);
            Console.WriteLine("    -*-TIC-*-TAC-*-TOE-*-");
            WriteLines(3);
            Position.WriteLine(1);
            WriteSeparatorLine();
            Position.WriteLine(2);
            WriteSeparatorLine();
            Position.WriteLine(3);
            WriteLines(3);
        }

        public int? CheckIfWinningBoard(bool isPlayerOneTurn)
        {
            foreach (var permutation in WinningPermutations)
            {
                var squareOne = Position.GetChoiceAtPosition(permutation.Item1).ToLower();
                var squareTwo = Position.GetChoiceAtPosition(permutation.Item2).ToLower();
                var squareThree = Position.GetChoiceAtPosition(permutation.Item3).ToLower();
                
                if (squareOne == squareTwo && squareTwo == squareThree && squareThree == squareOne)
                {
                    return squareOne == "x" ? 1 : 2;
                }
            }

            return null;
        }

        private void WriteLines(int amount)
        {
            for (var index = 0; index < amount; index++)
            {
                Console.WriteLine();
            }
        }

        private void WriteSeparatorLine()
        {
            Console.WriteLine("  ------------------------");
        }
    }
}
