namespace Packt.Shared;

public interface IMoveCheck
{
    bool MoveCheck(string movePice, Chess_Pices pice);
}

public partial class Soldier : IMoveCheck
{
    public bool MoveCheck(string movePice, Chess_Pices pice)
    {
        string[] move_Pice = movePice.Split(',');
        if (move_Pice.Length > 1 && int.TryParse(move_Pice[0], out int move1) && char.TryParse(move_Pice[1], out char move2))
        {
            if (move1 >= 1 && move1 <= 8 && move2 >= 'a' && move2 <= 'h')
            {
                if (Math.Abs(move1 - pice.cord1) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}

public partial class Elephant : IMoveCheck
{
    public bool MoveCheck(string movePice, Chess_Pices pice)
    {
        string[] move_Pice = movePice.Split(',');
        if (move_Pice.Length > 1 && int.TryParse(move_Pice[0], out int move1) && char.TryParse(move_Pice[1], out char move2))
        {
            if (move1 >= 1 && move1 <= 8 && move2 >= 'a' && move2 <= 'h')
            {
                if (Math.Abs(move1 - pice.cord1) == Math.Abs(move2 - pice.cord2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}

public partial class Ship : IMoveCheck
{
    public bool MoveCheck(string movePice, Chess_Pices pice)
    {
        string[] move_Pice = movePice.Split(',');
        if (move_Pice.Length > 1 && int.TryParse(move_Pice[0], out int move1) && char.TryParse(move_Pice[1], out char move2))
        {
            if (move1 >= 1 && move1 <= 8 && move2 >= 'a' && move2 <= 'h')
            {
                if (move2 == pice.cord2 || move1 == pice.cord1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}

public partial class Horse : IMoveCheck
{
    public bool MoveCheck(string movePice, Chess_Pices pice)
    {
        string[] move_Pice = movePice.Split(',');
        if (move_Pice.Length > 1 && int.TryParse(move_Pice[0], out int move1) && char.TryParse(move_Pice[1], out char move2))
        {
            if (move1 >= 1 && move1 <= 8 && move2 >= 'a' && move2 <= 'h')
            {
                if ((Math.Abs(move1 - pice.cord1) == 2 && Math.Abs(move2 - pice.cord2) == 1) ||
                    (Math.Abs(move1 - pice.cord1) == 1 && Math.Abs(move2 - pice.cord2) == 2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}

public partial class Queen : IMoveCheck
{
    public bool MoveCheck(string movePice, Chess_Pices pice)
    {
        string[] move_Pice = movePice.Split(',');
        if (move_Pice.Length > 1 && int.TryParse(move_Pice[0], out int move1) && char.TryParse(move_Pice[1], out char move2))
        {
            if (move1 >= 1 && move1 <= 8 && move2 >= 'a' && move2 <= 'h')
            {
                if (move2 == pice.cord2 || move1 == pice.cord1)
                {
                    return true;
                }
                else if (Math.Abs(move1 - pice.cord1) == Math.Abs(move2 - pice.cord2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}

public partial class King : IMoveCheck
{
    public bool MoveCheck(string movePice, Chess_Pices pice)
    {
        string[] move_Pice = movePice.Split(',');
        if (move_Pice.Length > 1 && int.TryParse(move_Pice[0], out int move1) && char.TryParse(move_Pice[1], out char move2))
        {
            if (move1 >= 1 && move1 <= 8 && move2 >= 'a' && move2 <= 'h')
            {
                if (Math.Abs(move1 - pice.cord1) <= 1 && Math.Abs(move2 - pice.cord2) <= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}