using static System.Console;
using Packt.Shared;

public static class ChessInfo
{
    public static void ShowInfo(List<Chess_Pices> pices)
    {
        foreach(Chess_Pices pice in pices)
        {
            WriteLine(format:"Name: {0}\nKeyCode: {1}\nColor: {2}\n",
            arg0: pice.Name,
            arg1: pice.keycode,
            arg2: pice.color
            );

            WriteLine();
        }
        
    }
}

