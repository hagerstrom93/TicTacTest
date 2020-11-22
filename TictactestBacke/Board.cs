using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TictactestBacke
{
    public class Board
    {
        List<Square> TheBoard;

        public Board() // Board ska innehålla en lista ELLER 2D array som innehåller 9 positioner, en för varje ruta.
        {
            TheBoard = new List<Square>(9);
            Square NW = new Square("NW");
            TheBoard.Add(NW);
            Square NC = new Square("NC");
            TheBoard.Add(NC);
            Square NE = new Square("NE");
            TheBoard.Add(NE);
            Square CW = new Square("CW");
            TheBoard.Add(CW);
            Square CC = new Square("CC");
            TheBoard.Add(CC);
            Square CE = new Square("CE");
            TheBoard.Add(CE);
            Square SW = new Square("SW");
            TheBoard.Add(SW);
            Square SC = new Square("SC");
            TheBoard.Add(SC);
            Square SE = new Square("SE");
            TheBoard.Add(SE);

        }

        public Square GetSquare(Player player, Board board, string input) // Tar emot namnet på en square, kollar igenom listan TheBoard efter en Square med detta namn,
        {                                                               // om det matchar, kör GetPosition på denna square.
            foreach (Square square in board.TheBoard)
            {
                if (input == square.name)
                {        
                    square.GetPosition(player, board, square);
                    return square;
                }    
            }
            return null; /// Bra+???
        }

        // Board ska känna av ifall 3 av dess squares som är i rad är ifyllda av samma spelare, och då deklarera vinst

        public int WinCondition()
        {
            while (TheBoard[0].status + TheBoard[1].status + TheBoard[2].status > 2)
            {
                if (TheBoard[0].status == TheBoard[1].status && TheBoard[1].status == TheBoard[2].status && TheBoard[2].status == TheBoard[0].status)
                {
                    Console.WriteLine("1");
                    return TheBoard[0].status;
                }
                else if (TheBoard[3].status == TheBoard[4].status && TheBoard[4].status == TheBoard[5].status && TheBoard[5].status == TheBoard[3].status)
                {
                    Console.WriteLine("2");
                    return TheBoard[3].status;
                }
                else if (TheBoard[6].status == TheBoard[7].status && TheBoard[7].status == TheBoard[8].status && TheBoard[8].status == TheBoard[6].status)
                {
                    Console.WriteLine("3");
                    return TheBoard[6].status;
                }
                else if (TheBoard[0].status == TheBoard[3].status && TheBoard[3].status == TheBoard[6].status && TheBoard[6].status == TheBoard[0].status)
                {
                    Console.WriteLine("You hit the motherload baby");
                }
                else
                {
                    Console.WriteLine("Hej");
                }
            }
            Console.WriteLine("4");
            return TheBoard[0].status;
        }
    }
}
