namespace Dewey_Decimal_System_Library.Model
{
    public class HighScoreModel
    {
        public string Username { get; set; }
        public int Score { get; set; }
        public HighScoreModel() { }
        public HighScoreModel(string username, int score) { Username = username; Score = score; }

    }


}

