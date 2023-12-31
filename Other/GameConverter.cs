﻿using Dewey_Decimal_System_Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dewey_Decimal_System_Library.Other
{
    class GameConverter
    {
        public static DeweyPairGameModel ConvertToGameModel(DeweyPair deweyPair)
        {
            return new DeweyPairGameModel { Number = deweyPair.Number, Description = deweyPair.Description };
        }

        public static List<DeweyPairGameModel> ConvertListToGameModel(List<DeweyPair> pairs)
        {
            List<DeweyPairGameModel> gmList = new List<DeweyPairGameModel>();

            pairs.ForEach(x => gmList.Add(ConvertToGameModel(x)));

            return gmList;
        }
    }
}
