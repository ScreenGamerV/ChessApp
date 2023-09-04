using Packt.Shared;

namespace Functional
{
    public class AtoB
    {
        public void HorseCheck(string movePice, Chess_Pices pice)
        {
            string[] move_Pice = movePice.Split(',');
            if (move_Pice.Length > 1 && int.TryParse(move_Pice[0], out int move1) && char.TryParse(move_Pice[1], out char move2))
            {
                if (move1 >= 1 && move1 <= 8 && move2 >= 'a' && move2 <= 'h')
                {
                    
                }
            }
        }
    }
}