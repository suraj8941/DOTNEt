﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_net_test
{

    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string s) : base(s)
        {

        }
    }
}
