using System;
using System.Collections.Generic;
using System.Text;

namespace TictactestBacke
{
    public class Game
    {

        Board TheBoard;
        string winner;
        
        public Game() // Konstruktor för nytt Game. 1 bräde och 2 spelare
        {
 
        }     
        
        public Board GetList()
        {
            return TheBoard;    
        }

        public Player XorO(Player player1, Player player2) // FÖrsök till metod att byta plats på spelarna för att köra RunGame
        {
            Player player = new Player("O");
            if (player.Name == "O")
            {
                return player1;
            }
            else
            {
                return player2;
            }
        }

        
        public string RunGame(Player player1, Player player2, Board board, string input) // Kör programmet på hela argumentet som passas in för att starta spelet, lång string
        {
            string[] arr = input.Split(',', StringSplitOptions.RemoveEmptyEntries); // splittar stringen till koordinater med 2 värden, tex NE.SW
           
            foreach (string DoubleCoord in arr)
            {
                string[] temp = DoubleCoord.Trim().Split('.');  // Splittar koordinaten till en för square och en för position
                board.GetSquare(XorO(player1, player2), board, temp[0]).GetPosition(player1, board, (board.GetSquare(XorO(player1, player2), board, temp[0])));

                // TODO: Metoden ovanför hämtar rätt stor ruta för att göra move. Nästa metod bör därför köra en metod som hämtar rätt position utifrån resultatet av metoden ovan.
                
            }

            string winner = "";
            return winner;
        }

        public void RunGameNew(string input)
        {
            string[] arr = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        //Player1 makes move
                    }
                    else
                    {
                        //Player2 makes move
                    }
                }
            }
        }

        
    }
}
