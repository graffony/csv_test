using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace csv_test
{
    internal class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            ReadTop100ChessPlayersCsvFile();
            Console.ReadKey();
        }

        private static void ReadTop100ChessPlayersCsvFile()
        {
            var CsvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ';',
                UseFieldIndexForReadingData = false,
            };

            var CsvChessPlayersContext = new CsvContext();
            var ChessPlayers = CsvChessPlayersContext.Read<ChessPlayersModels>("Top100ChessPlayers.csv", CsvFileDescription);

            int First10ChessPlayers = 0;

            string name1 = "ИД";
            string name2 = "Имя";
            string name3 = "Описание";
            string name4 = "Страна";
            string name5 = "Рейтинг";
            string name6 = "Игры";
            string name7 = "Год рождения";

            Console.ForegroundColor = ConsoleColor.Green;
            log.InfoFormat("{0, 4}\t{1, 25}\t{2,9}\t{3, 6}\t{4, 7}\t{5, 5}\t{6, 12}", name1, name2, name3, name4, name5, name6, name7);
            Console.ResetColor();

            foreach (var ChessPlayersFile in ChessPlayers)
            {


                if (ChessPlayersFile.ChessPlayersBirthYear < 1980 && First10ChessPlayers != 10)
                {
                    string str1 = ChessPlayersFile.ChessPlayersRank;
                    string str2 = ChessPlayersFile.ChessPlayersName;
                    string str3 = ChessPlayersFile.ChessPlayersTitle;
                    string str4 = ChessPlayersFile.ChessPlayersCountry;
                    string str5 = ChessPlayersFile.ChessPlayersRating;
                    string str6 = ChessPlayersFile.ChessPlayersGames;
                    int str7 = ChessPlayersFile.ChessPlayersBirthYear;
   
                    log.InfoFormat("{0, 4}\t{1, 25}\t{2, 9}\t{3, 6}\t{4, 7}\t{5, 5}\t{6, 12}", str1, str2, str3, str4, str5, str6, str7);
                    
                    First10ChessPlayers++;
                }
            }
        }
    }
}
