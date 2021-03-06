﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG
{
    public interface ILogger
    {
        void Print(Message output, bool end = true);
        string Input(string hint = "");
        int Parse(int min, int max, string hint = "");
    }
}
