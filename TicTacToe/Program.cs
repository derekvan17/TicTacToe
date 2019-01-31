using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
     {
        static string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //positions on board

         static void DrawBoard() //draws board
         {
            Console.WriteLine();
            Console.WriteLine("    -*-TIC-*-TAC-*-TOE-*-");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("         |        |");
            Console.WriteLine("      {0}  |    {1}   |   {2}  ", pos[1], pos[2], pos[3]);
            Console.WriteLine("         |        |");
            Console.WriteLine("  ------------------------");
            Console.WriteLine("         |        |");
            Console.WriteLine("      {0}  |    {1}   |   {2}  ", pos[4], pos[5], pos[6]);
            Console.WriteLine("         |        |");
            Console.WriteLine("  ------------------------");
            Console.WriteLine("         |        |");
            Console.WriteLine("      {0}  |    {1}   |   {2}  ", pos[7], pos[8], pos[9]);
            Console.WriteLine("         |        |");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private static bool WinLine (int index0, int index1, int index2, string player) //method to get winning combinations
        {
            return pos[index0] == player && pos[index1] == player && pos[index2] == player;
        }

        static bool CheckWin() //checks for a winner using WinLine
        {
            if (WinLine(1, 2, 3, "X")) //X wins horizontally
            {
                //pos[1] = " ";
                //pos[2] = " ";
                //pos[3] = " ";
                pos[4] = " ";
                pos[5] = " ";
                pos[6] = " ";
                pos[7] = " ";
                pos[8] = " ";
                pos[9] = " ";
                return true;
            }
            if (WinLine(4, 5, 6, "X"))
            {
                pos[1] = " ";
                pos[2] = " ";
                pos[3] = " ";
                //pos[4] = " ";
                //pos[5] = " ";
                //pos[6] = " ";
                pos[7] = " ";
                pos[8] = " ";
                pos[9] = " ";
                return true;
            }
            if (WinLine(7, 8, 9, "X"))
            {
                pos[1] = " ";
                pos[2] = " ";
                pos[3] = " ";
                pos[4] = " ";
                pos[5] = " ";
                pos[6] = " ";
                //pos[7] = " ";
                //pos[8] = " ";
                //pos[9] = " ";
                return true;
            }
            if (WinLine(1, 4, 7, "X")) //X wins vertically
            {
                //pos[1] = " ";
                pos[2] = " ";
                pos[3] = " ";
                //pos[4] = " ";
                pos[5] = " ";
                pos[6] = " ";
                //pos[7] = " ";
                pos[8] = " ";
                pos[9] = " ";
                return true;
            }
            if (WinLine(2, 5, 8, "X"))
            {
                pos[1] = " ";
                //pos[2] = " ";
                pos[3] = " ";
                pos[4] = " ";
                //pos[5] = " ";
                pos[6] = " ";
                pos[7] = " ";
                //pos[8] = " ";
                pos[9] = " ";
                return true;
            }
            if (WinLine(3, 6, 9, "X"))
            {
                pos[1] = " ";
                pos[2] = " ";
                //pos[3] = " ";
                pos[4] = " ";
                pos[5] = " ";
                //pos[6] = " ";
                pos[7] = " ";
                pos[8] = " ";
                //pos[9] = " ";
                return true;
            }
            if (WinLine(1, 5, 9, "X")) //X wins diagonally
            {
                //pos[1] = " ";
                pos[2] = " ";
                pos[3] = " ";
                pos[4] = " ";
                //pos[5] = " ";
                pos[6] = " ";
                pos[7] = " ";
                pos[8] = " ";
                //pos[9] = " ";
                return true;
            }
            if (WinLine(3, 5, 7, "X"))
            {
                pos[1] = " ";
                pos[2] = " ";
                //pos[3] = " ";
                pos[4] = " ";
                //pos[5] = " ";
                pos[6] = " ";
                //pos[7] = " ";
                pos[8] = " ";
                pos[9] = " ";
                return true;
            }
            if (WinLine(1, 2, 3, "O")) //O wins horizontally
            {
                //pos[1] = " ";
                //pos[2] = " ";
                //pos[3] = " ";
                pos[4] = " ";
                pos[5] = " ";
                pos[6] = " ";
                pos[7] = " ";
                pos[8] = " ";
                pos[9] = " ";
                return true;
            }
            if (WinLine(4, 5, 6, "O"))
            {
                pos[1] = " ";
                pos[2] = " ";
                pos[3] = " ";
                //pos[4] = " ";
                //pos[5] = " ";
                //pos[6] = " ";
                pos[7] = " ";
                pos[8] = " ";
                pos[9] = " ";
                return true;
            }
            if (WinLine(7, 8, 9, "O"))
            {
                pos[1] = " ";
                pos[2] = " ";
                pos[3] = " ";
                pos[4] = " ";
                pos[5] = " ";
                pos[6] = " ";
                //pos[7] = " ";
                //pos[8] = " ";
                //pos[9] = " ";
                return true;
            }
            if (WinLine(1, 4, 7, "O")) //O wins vertically
            {
                //pos[1] = " ";
                pos[2] = " ";
                pos[3] = " ";
                //pos[4] = " ";
                pos[5] = " ";
                pos[6] = " ";
                //pos[7] = " ";
                pos[8] = " ";
                pos[9] = " ";
                return true;
            }
            if (WinLine(2, 5, 8, "O"))
            {
                pos[1] = " ";
                //pos[2] = " ";
                pos[3] = " ";
                pos[4] = " ";
                //pos[5] = " ";
                pos[6] = " ";
                pos[7] = " ";
                //pos[8] = " ";
                pos[9] = " ";
                return true;
            }
            if (WinLine(3, 6, 9, "O"))
            {
                pos[1] = " ";
                pos[2] = " ";
                //pos[3] = " ";
                pos[4] = " ";
                pos[5] = " ";
                //pos[6] = " ";
                pos[7] = " ";
                pos[8] = " ";
                //pos[9] = " ";
                return true;
            }
            if (WinLine(1, 5, 9, "O")) //O wins diagonally
            {
                //pos[1] = " ";
                pos[2] = " ";
                pos[3] = " ";
                pos[4] = " ";
                //pos[5] = " ";
                pos[6] = " ";
                pos[7] = " ";
                pos[8] = " ";
                //pos[9] = " ";
                return true;
            }
            if (WinLine(3, 5, 7, "O"))
            {
                pos[1] = " ";
                pos[2] = " ";
                //pos[3] = " ";
                pos[4] = " ";
                //pos[5] = " ";
                pos[6] = " ";
                //pos[7] = " ";
                pos[8] = " ";
                pos[9] = " ";
                return true;
            }
            else
            {
                return false;
            }
        }

         static void Main()
         {
            StartGame: //restart from end of Main
            
            /* variable declaration:
             * choice: selects where on board
             * turn: toggles between x and o
             * num: counts number of turns
            */

            int choice = 0, turn = 1, num = 1;
            bool winFlag = false, playing = true;

            DrawBoard(); //show players board

            //game loop
            while (playing == true)
            {
               

                while (winFlag == false)
                {

                    
                    //player O turn
                    if (turn == 1 && num < 10)
                    {

                        Console.WriteLine("Player O's turn. Pick a number");
                        choice = int.Parse(Console.ReadLine());

                        if (choice > 0 && choice < 10)
                        {
                            if (pos[choice] != "X" && pos[choice] != "O")
                            {
                                pos[choice] = "O";
                                winFlag = CheckWin();
                                Console.Clear();
                                DrawBoard();
                                num++;

                                if (winFlag == false)
                                {
                                    turn = 2;
                                }

                                else
                                {
                                    playing = false;
                                }
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Spot taken. Enter Again");
                                DrawBoard();
                            }

                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Incorrect Entry. Enter a number 1 - 9.");
                            DrawBoard();
                        }
                    }

                    //player X turn
                    else if (turn == 2 && num < 10)
                    {
                        Console.WriteLine("Player X's turn. Pick a number");
                        choice = int.Parse(Console.ReadLine());

                        if (choice > 0 && choice < 10)
                        {
                            if (pos[choice] != "X" && pos[choice] != "O")
                            {
                                pos[choice] = "X";
                                winFlag = CheckWin();
                                Console.Clear();
                                DrawBoard();
                                num++;

                                if (winFlag == false)
                                {
                                    turn = 1;
                                }

                                else
                                {
                                    playing = false;
                                }
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Spot taken. Enter Again");
                                DrawBoard();
                            }

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Incorrect Entry. Enter a number.");
                            DrawBoard();
                        }
                    }

                    else //on 10th turn with no winner
                    {
                        playing = false;
                        goto EndGame;
                    }
                }
            }

            EndGame:

            if (winFlag == true)
            {
                if (turn == 1)
                {
                    Console.WriteLine("Player O wins!!");
                }

                else
                {
                    Console.WriteLine("Player X wins!!");
                }
            }

            if (winFlag == false)
            {
                Console.WriteLine("Tie game!");
            }

            Console.WriteLine("Play again? Y for Yes. Any other key will exit.");
            string key = Console.ReadLine();

            if (key == "y" || key == "Y") //restarts game
            {
                pos[1] = "1";
                pos[2] = "2";
                pos[3] = "3";
                pos[4] = "4";
                pos[5] = "5";
                pos[6] = "6";
                pos[7] = "7";
                pos[8] = "8";
                pos[9] = "9";
                Console.Clear();
                goto StartGame;
            }

            else //quits app
            {
                return;

            }
        }
     }
}
