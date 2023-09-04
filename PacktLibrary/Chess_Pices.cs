using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace Packt.Shared;

public class Chess_Pices
{
    public IMoveCheck? IMover { get; set; }
    private string? pice_Name;
    private string? key_code;
    private Color pice_color;
    private int cord_1;
    private char cord_2;
    public string Name
    {
        get { return pice_Name; }
        set { pice_Name = value; }
    }

    public string keycode
    {
        get { return key_code; }
        set { key_code = value; }
    }

    public Color color
    {
        get { return pice_color; }
        set { pice_color = value; }
    }

    public int cord1
    {
        get { return cord_1; }
        set { cord_1 = value; }
    }

    public char cord2
    {
        get { return cord_2; }
        set { cord_2 = value; } 
    }

    public bool MoveChecker(string movePice, Chess_Pices pice)
    {
        return IMover.MoveCheck(movePice, pice);
    }
}

public partial class Soldier : Chess_Pices
{
    public Soldier()
    {
        Name = "Soldier";
        keycode = "SD";
    }
    
}
public partial class Ship : Chess_Pices
{
    public Ship()
    {
        Name = "Ship";
        keycode = "SH";
    }
    
}

public partial class Elephant : Chess_Pices
{
    public Elephant()
    {
        Name = "Elephant";
        keycode = "E";
    }
    
}

public partial class Horse : Chess_Pices
{
    public Horse()
    {
        Name = "Horse";
        keycode = "H";
    }

}

public partial class Queen : Chess_Pices
{
    public Queen()
    {
        Name = "Queen";
        keycode = "Q";
    }

}

public partial class King : Chess_Pices
{
    public King()
    {
        Name = "King";
        keycode = "K";
    }

}




