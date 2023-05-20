using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Сhess_Сompetitions
{
    class Game
    {
        static private Random rand = new Random();
        private static string DoGame(ChessPlayer chessPlayer1, ChessPlayer chessPlayer2)
        {
            int WhoWin = rand.Next(3);
            switch (WhoWin)
            {
                case 0:
                    chessPlayer1.NumberOfWins++;
                    chessPlayer2.NumberOFLose++;
                    chessPlayer1.Score += 2;
                    return ("Шахматист " + chessPlayer1.FirstName + " " + chessPlayer1.SecondName + " выиграл шахматиста " + chessPlayer2.FirstName + " " + chessPlayer2.SecondName + "!\r\n");
                case 1:
                    chessPlayer2.NumberOfWins++;
                    chessPlayer1.NumberOFLose++;
                    chessPlayer2.Score += 2;
                    return ("Шахматист " + chessPlayer2.FirstName + " " + chessPlayer2.SecondName + " выиграл шахматиста " + chessPlayer1.FirstName + " " + chessPlayer1.SecondName + "!\r\n");
                case 2:
                    chessPlayer1.NumberOfDraw++;
                    chessPlayer2.NumberOfDraw++;
                    chessPlayer1.Score++;
                    chessPlayer2.Score++;
                    return ("Шахматисты " + chessPlayer1.FirstName + " " + chessPlayer1.SecondName + " и " + chessPlayer2.FirstName + " " + chessPlayer2.SecondName + " сыграли вничью!\r\n");
            }
            return null;
        }

        public static string DoTournament(List<ChessPlayer> players)
        {
            string Report = "";
            for (int i = 0; i < players.Count(); ++i)
            {
                for (int j = i + 1; j < players.Count(); ++j)
                {
                    Report += DoGame(players[i], players[j]);
                }
            }
            return Report;
        }
    }
}
