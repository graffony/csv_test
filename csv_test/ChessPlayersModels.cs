using LINQtoCSV;
using System;


namespace csv_test
{
    [Serializable]
    public class ChessPlayersModels 
    {
        [CsvColumn(Name = "Rank", FieldIndex = 1)]
        public string ChessPlayersRank { get; set; }

        [CsvColumn(Name = "Name", FieldIndex = 2)]
        public string ChessPlayersName { get; set; }

        [CsvColumn(Name = "Title", FieldIndex = 3)]
        public string ChessPlayersTitle { get; set; }

        [CsvColumn(Name = "Country", FieldIndex = 4)]
        public string ChessPlayersCountry { get; set; }

        [CsvColumn(Name = "Rating", FieldIndex = 5)]
        public string ChessPlayersRating { get; set; }

        [CsvColumn(Name = "Games", FieldIndex = 6)]
        public string ChessPlayersGames { get; set; }

        [CsvColumn(Name = "B-Year,", FieldIndex = 7)]
        public int ChessPlayersBirthYear { get; set; }
    }
}
