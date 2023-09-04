using static System.Console;
using Packt.Shared;

namespace Functional
{
    public class AddAndPlacePices
    {
        public static Chess_Pices? SelectPice()
        {
            WriteLine("Select Pice` (SD` Soldier, SH` Ship, E` Elephant, H` Horse, Q` Queen, K` King)");
            while(true)
            {
                string? code = ReadLine();
                switch (code)
                {
                    case "SD":
                    var soldier = new Soldier();
                    soldier.IMover = new Soldier();
                    return soldier;

                    case "SH":
                    var ship = new Ship();
                    ship.IMover = new Ship();
                    return ship;

                    case "E":
                    var elephant = new Elephant();
                    elephant.IMover = new Elephant();
                    return elephant;
                    
                    case "H":
                    var horse = new Horse();
                    horse.IMover = new Horse();
                    return horse;
                    
                    case "Q":
                    var queen = new Queen();
                    queen.IMover = new Queen();
                    return queen;
                    
                    case "K":
                    var king = new King();
                    king.IMover = new King();
                    return king;
                    
                    default:
                    WriteLine("Invalid Pice. Try again");
                    break;
                }
            }
        }

        public static void SelectColor(Chess_Pices pice)
        {
            WriteLine("Select a color` (White or Black)");
            bool colorCheck = false;
            while(!colorCheck)
            {
                string? colorInput = ReadLine();
                switch(colorInput)
                {
                    case "White":
                    pice.color = Color.White;
                    colorCheck = true;
                    break;

                    case "Black":
                    pice.color = Color.Black;
                    colorCheck = true;
                    break;

                    default:
                    WriteLine("Invalid Color. Try again");
                    break;
                }
                ResetColor();
            }
        }
        public static Cord PlacePice(Chess_Pices pice, string[,] Chessboard)
        {
            WriteLine("Enter cordinat` (For example 4,g)");
            WriteLine(format: "Cordinates for using\n{0}\n{1}",
                arg0: "1,2,3,4,5,6,7,8",
                arg1: "a,b,c,d,e,f,g,h");

            while (true)
            {
                string? cord = ReadLine();
                string[] cords = cord.Split(',');
        
                if (cords.Length > 1 && int.TryParse(cords[0], out int cord1) && char.TryParse(cords[1], out char cord2))
                {
                    if (cord1 >= 1 && cord1 <= 8 && cord2 >= 'a' && cord2 <= 'h')
                    {
                        Cord newCord = new Cord(cord1, cord2);
                        Chessboard[newCord.Cord1, newCord.Cord2] = pice.keycode;
                        return newCord;
                    }
                    else
                    {
                        WriteLine("Invalid cordinat. Try again");
                    }
                }
                else
                {
                    WriteLine("Invalid cordinat. Try again");
                }
            }
        }
    }
}