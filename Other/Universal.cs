namespace Dewey_Decimal_System_Library.Other
{
    internal class Universal
    {

        // global class that contains properties which can be accessed throughout the 
        public static class Global
        {
            public static int CountdownTime { get; set; } = 60;
            public static int BonusPoints { get; set; } = 0;
            public static int Points { get; set; } = 0;
            public static int countAlt { get; set; }
            public static bool UpdateUserControl { get; set; } = false;
            public static bool SortCallingNos { get; set; } = false;
            public static bool SaveScore { get; set; } = false;
            public static string Username { get; set; } = null;
            public static bool isAltGame { get; set; } = false;
            public static bool Game1 { get; set; } = false;
            public static bool Game2 { get; set; } = false;
            public static bool Game3 { get; set; } = false;


        }
    }
}
