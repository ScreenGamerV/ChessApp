using System.IO.Pipes;
using Packt.Shared;

public class Save
{
    public static List<Chess_Pices> PicesList(List<Chess_Pices> pices, Chess_Pices pice, Cord cord)
    {
        pice.cord1 = cord.Cord1 + 1;
        pice.cord2 = (char)(cord.Cord2 + 'a');
        pices.Add(pice);
        return pices;
    }
}







