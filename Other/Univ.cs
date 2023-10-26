using Dewey_Decimal_System_Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dewey_Decimal_System_Library.Other
{
    public static class Univ
    {
        #region Global Variables
        public static int CountdownTime { get; set; } = 60;
        public static int BonusPoints { get; set; } = 0;
        public static int Points { get; set; } = 0;
        public static int countAlt { get; set; }
        public static bool UpdateUserControl { get; set; } = false;
        public static bool ReplacingBooks { get; set; } = false;
        public static bool SaveScore { get; set; } = false;
        public static string Username { get; set; } = null;
        public static bool isAltGame { get; set; } = false;
        public static bool Game1 { get; set; } = false;
        public static bool Game2 { get; set; } = false;
        public static bool Game3 { get; set; } = false;
        #endregion

        // Declaring generic collections
        public static List<IdentifyingAreasModel> listDescription = new List<IdentifyingAreasModel>();
        public static List<string> listCallNos = new List<string>();
        public static Dictionary<string, string> dictCallNoDescription = new Dictionary<string, string>();

    }
}
