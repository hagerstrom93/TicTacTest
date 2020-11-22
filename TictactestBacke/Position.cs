using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TictactestBacke
{
    public class Position
    {
        public string name {  get; private set; }
        public int status;
        public Position(string name)
        {
            this.name = name;
            this.status = 0;
        }

        public int ChangeStatus(Player player, Board theboard, Square thesquare, Position theposition) // Ändrar status på en specifik position. Värdet beror på spelare.
        {
            return theposition.status += player.status; 
        }
    }
}
