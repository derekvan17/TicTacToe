using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
         static void Main()
         {
            while (true)
            {
                var winningPlayer = -1; //-1 null, 0 tie, 1 player 1 (X), 2 player 2 (O)
                var totalTurns = 0;
                var isGameOver = false;
                var board = new Board();

                while (!isGameOver)
                {
                    var currentPlayersTurn = ((totalTurns + 1) % 2) != 0 ? 1 : 2;  //ternary statements (cond ? if true : if false)/modulus operator (remainder from division)
                    var isCurrentPlayersTurn = true;
                    var validMove = false;
                    
                    while (isCurrentPlayersTurn)
                    {
                        board.DrawBoard();

                        Console.WriteLine($"Player {currentPlayersTurn}'s turn. Pick a number:"); //player 1 is X

                        var entry = Console.ReadLine();

                        Console.WriteLine("You entered: " + entry);

                        if (int.TryParse(entry, out var intChoice))
                        {
                            if (intChoice > 0 && intChoice < 10)
                            {
                                var statusOfBoardAtChoice = board.Position.GetChoiceAtPosition(intChoice);

                                if (statusOfBoardAtChoice.ToLower() != "x" && statusOfBoardAtChoice.ToLower() != "o")
                                {
                                    board.Position.SetChoiceAtPosition(intChoice, currentPlayersTurn == 1);
                                    
                                    validMove = true;
                                }
                            }
                        }
                        
                        if (!validMove)
                        {
                            Console.WriteLine("Incorrect Entry. Enter a number 1 - 9 in a square that has not been selected.");
                        }
                        else
                        {
                            totalTurns++;

                            isCurrentPlayersTurn = false;
                            
                            var endGameCheck = board.CheckIfWinningBoard(currentPlayersTurn == 1);

                            if (endGameCheck.HasValue)
                            {
                                winningPlayer = endGameCheck.Value;
                            }
                            else if (totalTurns == 9)
                            {
                                winningPlayer = 0;
                            }

                            if (winningPlayer > -1)
                            {
                                isGameOver = true;
                            }
                        }

                        Console.Clear();
                    }
                }

                board.DrawBoard();

                if (winningPlayer == 0)
                {
                    Console.WriteLine("Tie game!");
                }
                else if (winningPlayer == 1)
                {
                    Console.WriteLine("Player 1 (X) wins!!");
                }
                else if (winningPlayer == 2)
                {
                    Console.WriteLine("Player 2 (O) wins!!");
                }

                Console.WriteLine("Press any key to play again. Press ctrl-c to exit");
                Console.ReadLine();
                Console.Clear();
            }
        }
     }
}
