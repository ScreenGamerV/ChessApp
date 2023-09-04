using System.Drawing;
using System.Net.NetworkInformation;
using System.Xml;
using Packt.Shared;
using static System.Console;

namespace Functional
{
    public static class BuildAnArea
    {
        public static string[,] StartBuild()
        {
            WriteLine("Chessboard pattern:");

            Write("   ");
            for (char col = 'a'; col <= 'h'; col++)
            {
                Write(col + " ");
            }
            WriteLine();

            string[,] Chessboard = new string[8, 8];

            for (int row = 0; row < 8; row++)
            {
                Write((row + 1) + " "); 

                for (int col = 0; col < 8; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Chessboard[row,col] = " ";
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Chessboard[row,col] = " ";
                    }
                    Write(Chessboard[row, col] + " ");
                    Console.ResetColor();
                }
                WriteLine();
            }
            return Chessboard;
        }

        public static void ShowBoard(string[,] Chessboard, List<Chess_Pices> pices)
        {
            WriteLine("Chessboard pattern:");

            Write("   ");
            for (char col = 'a'; col <= 'h'; col++)
            {
            Write(col + " ");
            }
            WriteLine();

            for (int row = 0; row < 8; row++)
            {
                Write((row + 1) + " "); 

                for (int col = 0; col < 8; col++)
                {
                    if(Chessboard[row, col] == " ")
                    {
                        if ((row + col) % 2 == 0)
                        {
                            BackgroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            BackgroundColor = ConsoleColor.DarkGreen;
                        }
                    }
                    else
                    {
                        foreach(Chess_Pices pice in pices)
                        {
                            if(pice.keycode == Chessboard[row, col])
                            {
                                if(pice.color == Color.White)
                                {
                                    BackgroundColor = ConsoleColor.White;
                                    ForegroundColor = ConsoleColor.Black;
                                }
                                else if(pice.color == Color.Black)
                                {
                                    BackgroundColor = ConsoleColor.Black;
                                    ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                    }
                    Write(Chessboard[row, col] + " ");
                    ResetColor();
                }
                WriteLine();
            }
        }
    }
}


