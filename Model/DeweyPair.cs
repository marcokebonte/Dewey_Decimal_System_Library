﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dewey_Decimal_System_Library.Model
{
    public class DeweyPair : IComparable<DeweyPair>
    {
        // properties
        public string Number { get; set; }
        public string Description { get; set; }

        // constructor
        public DeweyPair()
        {

        }

        // implementation
        public int CompareTo(DeweyPair other)
        {
            return this.Number.CompareTo(other.Number);
        }

    }
}
