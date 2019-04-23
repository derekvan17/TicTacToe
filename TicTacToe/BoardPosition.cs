using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class BoardPosition
    {
        private Dictionary<int, string> _positions  { get; set; } 

        public BoardPosition()
        {
            _positions = new Dictionary<int, string>()
            {
                { 1, "1" },
                { 2, "2" },
                { 3, "3" },
                { 4, "4" },
                { 5, "5" },
                { 6, "6" },
                { 7, "7" },
                { 8, "8" },
                { 9, "9" },
            };
        }

        public string GetChoiceAtPosition(int choiceOneThroughNine)
        {
            return _positions[choiceOneThroughNine];
        }

        public void SetChoiceAtPosition(int choiceOneThroughNine, bool isPlayerOneTurn)
        {
            _positions[choiceOneThroughNine] = isPlayerOneTurn ? "X" : "O";
        }

        public void WriteLine(int lineNumber)
        {
            var argument = 3 * (lineNumber - 1);
            Console.WriteLine("         |        |");
            Console.WriteLine($"      {_positions[argument + 1]}  |    {_positions[argument + 2]}   |   {_positions[argument + 3]}  "); //string interpolation
            Console.WriteLine("         |        |");
        }
    }
}
