﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Dewey_Decimal_System_Library.Model;
using JsonSerializer = System.Text.Json.JsonSerializer;
using Dewey_Decimal_System_Library.Tree_Structure;

namespace Dewey_Decimal_System_Library.JSON
{
    public class JsonFileWorker
    {

        //File Names
        public static string IdentifyingAreasCallNo = "IdentifyingAreasCallNo.json";
        public static string IdentifyingAreasFile = "IdentifyingAreasLeaderboard.json";
        public static string ReplacingBooksFile = "ReplacingBooksLeaderboard.json";
        public static string TreeGameDataFile = "Tree.json";
        public static string TreeHighScoreFile = "FindingCallNumbersLeaderboard.json";



        #region Get All Scores
        // Returns all existing score in json file
        public static List<HighScoreModel> GetAllScores(string filename)
        {
            return JsonSerializer.Deserialize<List<HighScoreModel>>(File.ReadAllText(filename));
        }
        #endregion


        #region File Exists
        // Checks to see if the json file exists before it can be used
        public static bool FileExists(string fileName)
        {
            if (File.Exists(fileName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Sorting Call Numbers
        // creates the json file
        public static void CreateJsonFile(string filename)
        {

            // instantiate random object
            Random rnd = new Random();

            // initialised list with random pre populated data
            List<HighScoreModel> initializeHighScore = new List<HighScoreModel>()
            {
                new HighScoreModel( "Trever",     rnd.Next(1, 101)),
                new HighScoreModel( "Alex",     rnd.Next(1, 101)),
                new HighScoreModel( "Phil",   rnd.Next(1, 101)),
                new HighScoreModel( "Brendt",     rnd.Next(1, 101)),
                new HighScoreModel( "Marta",    rnd.Next(1, 101)),
                new HighScoreModel( "Raisa",    rnd.Next(1, 101)),
                new HighScoreModel( "Sean",  rnd.Next(1, 101)),
                new HighScoreModel( "Mary",     rnd.Next(1, 101)),
            };

            File.WriteAllText(filename, JsonSerializer.Serialize(initializeHighScore));
        }

        // appends data to existing json file
        public static void AppendScores(HighScoreModel highScore, string filename)
        {
            List<HighScoreModel> lstHighScore = GetAllScores(filename);

            lstHighScore.Add(highScore);

            File.WriteAllText(filename, JsonSerializer.Serialize(lstHighScore));
        }

     

        
        #endregion




        #region Identifying Areas
        // Check if the Json file exists
        public static bool CallNumFileExists()
        {
            if (File.Exists(IdentifyingAreasCallNo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Creating the JSON file
        public static void CreateCallNumFile()
        {
            // Declare dictionary
            Dictionary<string, string> callNums = new Dictionary<string, string>();

            // Populate dictionary
            callNums.Add("000", "General Knowledge");
            callNums.Add("100", "Philosophy & Psychology");
            callNums.Add("200", "Religion");
            callNums.Add("300", "Social Sciences");
            callNums.Add("400", "Language");
            callNums.Add("500", "Natural Sciences & Mathematics");
            callNums.Add("600", "Technology (Applied Sciences)");
            callNums.Add("700", "The Arts");
            callNums.Add("800", "Literature & Rhetoric");
            callNums.Add("900", "Geography & History");

            // Serialize using System.Text.Json
            string jsonString = System.Text.Json.JsonSerializer.Serialize(callNums);

            File.WriteAllText(IdentifyingAreasCallNo, jsonString);

        }

        // Json file deserialization from  dictionary 
        public static Dictionary<string, string> GetKeyValuePairs()
        {
            return System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(IdentifyingAreasCallNo));
        }
        #endregion



        #region Finding Call Numbers

        //checks if the data file exists
        public static bool TreeGameDataExists()
        {
            if (File.Exists(TreeHighScoreFile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //checks if the score file exists
        public static bool TreeGameScoresExists()
        {
            if (File.Exists(TreeHighScoreFile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //creates a score file
        public static void CreateJsonFileCallNumber()
        {
            // Specify a constant filename or generate dynamically as needed
            string filename = TreeHighScoreFile;

            // instantiate random object
            Random rnd = new Random();

            // initialise list with random pre-populated data
            List<HighScoreModel> initializeHighScore = new List<HighScoreModel>()
            {
              new HighScoreModel("Trever", rnd.Next(1, 101)),
              new HighScoreModel("Alex", rnd.Next(1, 101)),
              new HighScoreModel("Phil", rnd.Next(1, 101)),
              new HighScoreModel("Brendt", rnd.Next(1, 101)),
              new HighScoreModel("Marta", rnd.Next(1, 101)),
              new HighScoreModel("Raisa", rnd.Next(1, 101)),
              new HighScoreModel("Sean", rnd.Next(1, 101)),
              new HighScoreModel("Mary", rnd.Next(1, 101)),
            };

            // Serialize and write to the file
            File.WriteAllText(filename, JsonSerializer.Serialize(initializeHighScore));
          }


        //creates the tree data
        public static void CreateTreeDataFile()
        {
            //gets a tree from the generator file
            Tree<DeweyPair> tree = MakeTree.GrowATree();

            //well, this file cant be a one liner, for the sake of my sanity
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

            //make json string
            string treeJSON = JsonSerializer.Serialize(tree, options);

            //writes tree to file
            using (StreamWriter sw = File.CreateText(TreeGameDataFile))
            {
                sw.WriteLine(treeJSON);
            }
        }

        public static Tree<DeweyPair> GetTree()
        {
            return JsonSerializer.Deserialize<Tree<DeweyPair>>(File.ReadAllText(TreeGameDataFile));
        }

        //adds a new highscore to the score file
        public static void AddTreeScore(HighScoreModel newScore)
        {
            List<HighScoreModel> highScores = GetTreeScores();

            highScores.Add(newScore);

            string scoreList = JsonSerializer.Serialize(highScores);

            File.WriteAllText(TreeHighScoreFile, scoreList);
        }

        //gets the list of highscores
        public static List<HighScoreModel> GetTreeScores()
        {
            return JsonSerializer.Deserialize<List<HighScoreModel>>(File.ReadAllText(TreeHighScoreFile));
        }
        #endregion

    }
}
