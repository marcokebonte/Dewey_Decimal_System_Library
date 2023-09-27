using static Dewey_Decimal_System_Library.Other.Universal;

namespace Dewey_Decimal_System_Library.Logic
{
    public static class ScoreSystem
    {

        #region Calculate Score
        public static int CalculateScore(int timeLeft)
        {
            // initialise properties - Game 1
            int timeCompleted = 30 - timeLeft, score = 0;

            // logic structure of points system
            if (timeCompleted < 10)
            {
                score = 100;
            }
            else if (timeCompleted >= 10 || timeCompleted <= 15)
            {
                score = 75;
            }
            else if (timeCompleted >= 16 || timeCompleted <= 21)
            {
                score = 50;
            }
            else if (timeCompleted >= 22 || timeCompleted <= 25)
            {
                score = 25;
            }
            else if (timeCompleted > 26)
            {
                score = 10;
            }

            return score;
        }

        // calculate score for game 2
        public static int CalculateScore(int timeLeft, int count)
        {
            return ((count / 4) * 100) + Global.BonusPoints + timeLeft;
        }


        #endregion
    }



}

