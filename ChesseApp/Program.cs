using Packt.Shared;
using Functional;
using static System.Console;

WriteLine("Chess App No.8/14/2023");
string[,] ChessBoard;
Chess_Pices Pice;
Cord newCord;
List<Chess_Pices> pices = new List<Chess_Pices>();
bool closeAppCheck = true;
ChessBoard = BuildAnArea.StartBuild();
while(closeAppCheck)
{
    WriteLine("Press Any ket to continue or press Q for Quit:");
    string? Start = ReadLine();
    if(Start == "q")
    {
        closeAppCheck = false;
    }
    else
    {
        Pice = AddAndPlacePices.SelectPice();
        AddAndPlacePices.SelectColor(Pice);
        newCord = AddAndPlacePices.PlacePice(Pice,ChessBoard);

        pices = Save.PicesList(pices,Pice,newCord);

        BuildAnArea.ShowBoard(ChessBoard,pices);

        WriteLine("Select cordinates for move and i show you is it true or false");
        string? movePice = ReadLine();
        WriteLine($"The move is` {Pice.MoveChecker(movePice, Pice)}");

        ChessInfo.ShowInfo(pices);
    }
}

