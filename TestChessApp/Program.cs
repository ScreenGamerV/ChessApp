using Packt.Shared;
using Functional;
using static System.Console;

var horse1 = new Horse();
int result = 0;
int first = 4;
char second = 'd';
string cord = ("5,c");
string[] cords = cord.Split(',');
if (cords.Length > 1 && int.TryParse(cords[0], out int move1) && char.TryParse(cords[1], out char move2))
{
    if (move1 >= 1 && move1 <= 8 && move2 >= 'a' && move2 <= 'h')
    {
        if (Math.Abs(move1 - first) == 1 || Math.Abs(move2 - second) == 1)
        {
            if (Math.Abs(move1 - first) == Math.Abs(move2 - second))
            {
                result = 2;
            }
            else
            {
                result = 3;
            }
        }

        if (horse1.MoveCheck(cord, horse1))
        {
            result = 1;
        }

        if (Math.Abs(move1 - first) == 2 || Math.Abs(move2 - second) == 2)
        {
            if (Math.Abs(move1 - first) == Math.Abs(move2 - second))
            {
                result = 4;
            }
            else
            {
                result = 2;
            }
        }
    }
}

WriteLine(result);
