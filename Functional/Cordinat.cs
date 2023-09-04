public struct Cord
{
    public int Cord1;
    public char Cord2;

    public Cord(int cord1, char cord2)
    {
        this.Cord1 = cord1 - 1;
        this.Cord2 = (char)(cord2 - 'a');
    }
}