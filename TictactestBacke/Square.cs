using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TictactestBacke
{
    public class Square
    {
        public string name; //2-bokstavigt namnet för rutan, alltså ex. NE eller CW
        public int status; // Värdet som avgör om rutan är spelad och i såfall av vem
        public List<Position> Positions; //Listan av Positioner som finns i varje Square

        public Square(string name) // Ta emot ett namn för vad varje ruta ska heta
        {
            this.name = name;
            status = 0;
            Positions = new List<Position>(9); // skapa en lista med 9 platser som heter som string inputen
            Position NW = new Position("NW");
            Positions.Add(NW);
            Position NC = new Position("NC");
            Positions.Add(NC);
            Position NE = new Position("NE");
            Positions.Add(NE);
            Position CW = new Position("CW");
            Positions.Add(CW);
            Position CC = new Position("CC");
            Positions.Add(CC);
            Position CE = new Position("CE");
            Positions.Add(CE);
            Position SW = new Position("SW");
            Positions.Add(SW);
            Position SC = new Position("SC");
            Positions.Add(SC);
            Position SE = new Position("SE");
            Positions.Add(SE);
        }

        public Position GetPosition(Player player, Board theboard, Square thesquare) // Hittar rätt position att ändra på.
        {
            foreach (Position position in thesquare.Positions)
            {
                if (thesquare.name == position.name)
                {
                    position.ChangeStatus(player, theboard, thesquare, position);
                    return position;
                }
            }
            return null; // Bra???
        }

        public int WinCondition()
        {
            while (Positions[0].status + Positions[1].status + Positions[2].status > 2)
            {
                if (Positions[0].status == Positions[1].status && Positions[1].status == Positions[2].status && Positions[2].status == Positions[0].status)
                {
                    
                    return Positions[0].status;
                }
                else if (Positions[3].status == Positions[4].status && Positions[4].status == Positions[5].status && Positions[5].status == Positions[3].status)
                {
                    
                    return Positions[3].status;
                }
                else if (Positions[6].status == Positions[7].status && Positions[7].status == Positions[8].status && Positions[8].status == Positions[6].status)
                {
                    
                    return Positions[6].status;
                }
                else if (Positions[0].status == Positions[3].status && Positions[3].status == Positions[6].status && Positions[6].status == Positions[0].status)
                {
                   
                }
                else
                {
                   
                }
            }

            return 0;
        }
    }
}
